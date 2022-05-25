using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Refrigeracao
{
    public partial class Grafico : Form
    {
        int graficoselecionado = 0;
        float valores;

        public Grafico()
        {
            InitializeComponent();
        }

        private void Bt_torque_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Torque");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Torque";
            graficoselecionado = 1;
        }

        private void Bt_temperatura_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Temperatura");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Temperatura";
            graficoselecionado = 2;
        }

        private void Bt_pressao_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Pressão do Ar");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Pressão do Ar";
            graficoselecionado = 3;
        }

        private void Bt_vazao_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Vazão");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Vazão";
            graficoselecionado = 4;
        }

        private void Bt_velocidade_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Velocidade");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Velocidade";
            graficoselecionado = 5;
        }

        private void Bt_frequencia_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Frequência de Rotação");
            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = "Frequência da Rotação";
            graficoselecionado = 6;
        }

        public void AtualizaGrafico(Dictionary<string, string> dicionariodevalores)
        {

            switch (graficoselecionado)
            {
                case 1:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["torque"]));
                    break;

                case 2:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["temperatura"]));
                    break;

                case 3:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["pressao"]));
                    break;

                case 4:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["vazao"]));
                    break;

                case 5:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["velocidade"]));
                    break;

                case 6:
                    chart1.Series[0].Points.Add(Convert.ToDouble(dicionariodevalores["frequencia"]));
                    break;

                case 0:
                    break;

            }
        }

        private void Grafico_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

    }
}