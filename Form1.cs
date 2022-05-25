using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Collections;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;



namespace Refrigeracao
{
    public partial class Form1 : Form
    {
        ModbusClient modbus; 
        Thread Loop;
        DbAccess mydb;
        Grafico graph;

        public Form1()
        {
            InitializeComponent();
            modbus = new ModbusClient();
            string connstring = "Server=10.15.20.15; Port=5433; User Id=g10ene11820193 ; Password=dabsonehigor; Database=g10ene11820193db;";
            mydb = new DbAccess(connstring, "dados_sensores");
            graph = new Grafico();
            graph.Show();
            graph.Visible = false; 
        }



        public Dictionary<string, string> LerDados() 
        {
            int[] dadosTQ, dadosCA, dadosPR, dadosVZ, dadosVL, dadosF;
            float dataTQ, dataCA, dataca, dataPR, datapr, dataVZ, dataVL, dataF;

            Dictionary<string, string> dados = new Dictionary<string, string>();

            try
            {
                if (modbus.Connected)
                {
                    //TORQUE VENTILADOR RADIAL
                    dadosTQ = modbus.ReadHoldingRegisters(1422, 2);
                    dataTQ = ModbusClient.ConvertRegistersToFloat(dadosTQ, ModbusClient.RegisterOrder.LowHigh);
                    dados.Add("torque", dataTQ.ToString());


                    //TEMPERATURA DA CARCAÇA
                    dadosCA = modbus.ReadHoldingRegisters(706, 2);
                    dataCA = ModbusClient.ConvertRegistersToFloat(dadosCA, ModbusClient.RegisterOrder.LowHigh);
                    dataca = dataCA / 10;
                    dataCA = dataca;
                    dados.Add("temperatura", dataCA.ToString());


                    //PRESSAO DO AR ENTRADA
                    dadosPR = modbus.ReadHoldingRegisters(1226, 2);
                    dataPR = ModbusClient.ConvertRegistersToFloat(dadosPR, ModbusClient.RegisterOrder.LowHigh);
                    datapr = dataPR / 10;
                    dataPR = datapr;
                    dados.Add("pressao", dataPR.ToString());


                    //VAZAO AR DE SAIDA
                    dadosVZ = modbus.ReadHoldingRegisters(714, 2);
                    dataVZ = ModbusClient.ConvertRegistersToFloat(dadosVZ, ModbusClient.RegisterOrder.LowHigh);
                    dados.Add("vazao", dataVZ.ToString());


                    //VELOCIDADE AR DE SAIDA
                    dadosVL = modbus.ReadHoldingRegisters(712, 2);
                    dataVL = ModbusClient.ConvertRegistersToFloat(dadosVL, ModbusClient.RegisterOrder.LowHigh);
                    dados.Add("velocidade", dataVL.ToString());


                    //FREQUENCIA VENTILADOR RADIAL 
                    dadosF = modbus.ReadHoldingRegisters(884, 2);
                    dataF = ModbusClient.ConvertRegistersToFloat(dadosF, ModbusClient.RegisterOrder.LowHigh);
                    dados.Add("frequencia", dataF.ToString());

                    //TIMESTAMP
                    dados.Add("timestamp", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));

                    string[] cols_to_write = { "torque", "temperatura", "pressao", "vazao", "velocidade", "frequencia", "timestamp" };

                    List<string[]> vals = new List<string[]>();

                    string[] valores = { dataTQ.ToString().Replace(',', '.'), dataCA.ToString().Replace(',', '.'), dataPR.ToString().Replace(',', '.'), dataVZ.ToString().Replace(',', '.'), dataVL.ToString().Replace(',', '.'), dataF.ToString().Replace(',', '.'), "'" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "'" };
                    vals.Add(valores);

                    mydb.InsertData(cols_to_write, vals);

                }

                else
                {
                    MessageBox.Show("Servidor MODBUS TCP Desconectado");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro na leitura dos dados MODBUS. \r\nErro: " + err.Message);
            }

            return dados;
        }

        public void atualizaDados(Dictionary<string, string> dados)
        {

            try
            {
                this.Invoke((MethodInvoker)delegate { lb_torque.Text = dados["torque"]; });
                this.Invoke((MethodInvoker)delegate { lb_temp.Text = dados["temperatura"]; });
                this.Invoke((MethodInvoker)delegate { lb_pressao.Text = dados["pressao"]; });
                this.Invoke((MethodInvoker)delegate { lb_vazao.Text = dados["vazao"]; });
                this.Invoke((MethodInvoker)delegate { lb_velocidade.Text = dados["velocidade"]; });
                this.Invoke((MethodInvoker)delegate { lb_frequencia.Text = dados["frequencia"]; });
                this.graph.Invoke((MethodInvoker)delegate { this.graph.AtualizaGrafico(dados); });
            }
            catch 
            {
                modbus.Disconnect();
            }
        }


         public void armazenaDados(Dictionary<string, string> dicionario)
        {

        }

        public bool ValidateIPv4(string ipString)
        {
            if (String.IsNullOrWhiteSpace(ipString))
            {
                return false;
            }

            string[] splitValues = ipString.Split('.');
            if (splitValues.Length != 4)
            {
                return false;
            }

            byte tempForParsing;

            return splitValues.All(r => byte.TryParse(r, out tempForParsing));
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            short port;
            Loop = new Thread(Processamento);

            if (ValidateIPv4(tb_ip.Text) && Int16.TryParse(tb_porta.Text, out port))
            {
                modbus = new ModbusClient(tb_ip.Text, port);
                modbus.ConnectionTimeout = 3000;

                

                if (bt_connect.Text == "Conectar")
                {

                    try
                    {
                        modbus.Connect();
                        Loop.Start();
                        bt_connect.Text = "Desconectar";
                        mydb.Connect();

                        bt_ligar.Enabled = true;
                        bt_grafico.Enabled = true;
                        bt_refri.Enabled = true;


                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                        return;
                    }
                }
                else
                {
                    bt_connect.Text = "Conectar";
                    bt_ligar.Enabled = false;                    
                    bt_refri.Enabled = false;
                    lb_frequencia.Text = "0 rpm";
                    lb_pressao.Text = "- mmHg";
                    lb_temp.Text = "0 °C";
                    lb_torque.Text = "0 Nm";
                    lb_vazao.Text = "0 m³/h";
                    lb_velocidade.Text = "0 m/s";
                    modbus.Disconnect();
                }
            }
            else
            {
                MessageBox.Show("IP ou porta inválidos");
            }


        }

        private void Processamento()
        {
            Dictionary<string, string> dados = new Dictionary<string, string>();

            while (modbus.Connected)
            {
                dados = LerDados();
                atualizaDados(dados);
                armazenaDados(dados);
                Thread.Sleep(100);
            }
        }




        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            string[] cols_to_read = { "torque", "temperatura", "pressao", "vazao", "velocidade", "frequencia", "timestamp" };
            List<List<string>> resultado_busca = mydb.ReadData(cols_to_read, "timestamp between '" + tb_de.Text + "' and '" + tb_ate.Text + "'");
            
            
            foreach (List<string> batata in resultado_busca)
            {
                dataGridView1.Rows.Add(batata[0], batata[1], batata[2], batata[3], batata[4], batata[5], batata[6]);
               
            }

        }

        private void bt_ligar_Click(object sender, EventArgs e)
        {
            while (modbus.Connected)
            {
                bt_ligar.Enabled = true;
                if (bt_ligar.Text == "Ligar Ventilador")
                {
                    modbus.WriteSingleRegister(1319, 0);
                    bt_ligar.Text = "Desligar Ventilador";

                }
                else
              if (bt_ligar.Text == "Desligar Ventilador")
                {
                    bt_ligar.Text = "Ligar Ventilador";
                }
            }
                      
                

        }      

        private void bt_grafico_Click(object sender, EventArgs e)
        {
            
            
                graph.Visible = true;
            
        }


        private void bt_refri_Click(object sender, EventArgs e)
        {

            while (modbus.Connected)
            {
                bt_refri.Enabled = true;
                if (bt_refri.Text == "Ligar Compressor")
                {
                    modbus.ReadHoldingRegisters(1319, 1);
                    bt_refri.Text = "Desligar Compressor";
                }
                else
                     if (bt_refri.Text == "Desligar Compressor")
                    {
                    bt_refri.Text = "ligar Compressor";
                    }
            }
           
        }

    }

}

    class DbAccess 
    {
        public string tablename;
        private NpgsqlConnection con;

        public DbAccess(string cstr, string table)
        {
            tablename = table;
            con = new NpgsqlConnection(cstr);
        }

        public void Connect()
        {
            try
            {
                con.Open();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar conexão: " + e.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                con.Close();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao fechar conexão: " + e.Message);
            }
        }

        public void InsertData(string[] columns, List<string[]> values)
        {
            string cmd = "insert into " + tablename + " (";

            foreach (string col in columns)
            {
                cmd += col + ",";
            }
            cmd = cmd.Remove(cmd.Length - 1);
            cmd += ") values";

            foreach (string[] vet in values)
            {
                cmd += "(";
                foreach (string val in vet)
                {
                    cmd += val + ",";
                }
                cmd = cmd.Remove(cmd.Length - 1);
                cmd += "),";
            }
            cmd = cmd.Remove(cmd.Length - 1);
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cmd, con);
                command.ExecuteNonQuery();
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar inserção no banco: " + e.Message);
            }
        }

        public List<List<string>> ReadData(string[] columns, string filter_exp)
        {
            List<List<string>> result = new List<List<string>>();
            string cmd = "select ";
            foreach (string col in columns)
            {
                cmd += col + ",";
            }
            cmd = cmd.Remove(cmd.Length - 1) + " from " + tablename;
            if (filter_exp != null)
            {
                cmd += " where " + filter_exp;
            }
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(cmd, con);
                NpgsqlDataReader dr = command.ExecuteReader();
                List<string> row = new List<string>();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        row.Add(dr[i].ToString());
                    }
                    result.Add(new List<string>(row));
                    row.Clear();
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Erro ao realizar consulta no banco: " + e.Message);
            }
            return result;
        }


    }
