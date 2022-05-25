namespace Refrigeracao
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_ligar = new System.Windows.Forms.Button();
            this.bt_connect = new System.Windows.Forms.Button();
            this.lb_pressao = new System.Windows.Forms.Label();
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_vazao = new System.Windows.Forms.Label();
            this.lb_torque = new System.Windows.Forms.Label();
            this.lb_velocidade = new System.Windows.Forms.Label();
            this.lb_frequencia = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_porta = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_refri = new System.Windows.Forms.Button();
            this.bt_grafico = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ate = new System.Windows.Forms.TextBox();
            this.tb_de = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ligar
            // 
            this.bt_ligar.BackColor = System.Drawing.Color.White;
            this.bt_ligar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ligar.ForeColor = System.Drawing.Color.LimeGreen;
            this.bt_ligar.Location = new System.Drawing.Point(679, 462);
            this.bt_ligar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_ligar.Name = "bt_ligar";
            this.bt_ligar.Size = new System.Drawing.Size(288, 79);
            this.bt_ligar.TabIndex = 0;
            this.bt_ligar.Text = "Ligar Ventilador";
            this.bt_ligar.UseVisualStyleBackColor = false;
            // 
            // bt_connect
            // 
            this.bt_connect.BackColor = System.Drawing.Color.White;
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_connect.Location = new System.Drawing.Point(1036, 474);
            this.bt_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(205, 95);
            this.bt_connect.TabIndex = 4;
            this.bt_connect.Text = "Conectar";
            this.bt_connect.UseVisualStyleBackColor = false;
            this.bt_connect.Click += new System.EventHandler(this.bt_connect_Click);
            // 
            // lb_pressao
            // 
            this.lb_pressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pressao.Location = new System.Drawing.Point(141, 60);
            this.lb_pressao.Name = "lb_pressao";
            this.lb_pressao.Size = new System.Drawing.Size(215, 36);
            this.lb_pressao.TabIndex = 5;
            this.lb_pressao.Text = "Pressão";
            this.lb_pressao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_temp
            // 
            this.lb_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_temp.Location = new System.Drawing.Point(809, 108);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(197, 30);
            this.lb_temp.TabIndex = 6;
            this.lb_temp.Text = "Temp Carcaça";
            this.lb_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_vazao
            // 
            this.lb_vazao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vazao.Location = new System.Drawing.Point(809, 79);
            this.lb_vazao.Name = "lb_vazao";
            this.lb_vazao.Size = new System.Drawing.Size(197, 30);
            this.lb_vazao.TabIndex = 7;
            this.lb_vazao.Text = "Vazão ar de saída";
            this.lb_vazao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_torque
            // 
            this.lb_torque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_torque.Location = new System.Drawing.Point(77, 352);
            this.lb_torque.Name = "lb_torque";
            this.lb_torque.Size = new System.Drawing.Size(177, 32);
            this.lb_torque.TabIndex = 8;
            this.lb_torque.Text = "Torque Radial";
            this.lb_torque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_velocidade
            // 
            this.lb_velocidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_velocidade.Location = new System.Drawing.Point(809, 138);
            this.lb_velocidade.Name = "lb_velocidade";
            this.lb_velocidade.Size = new System.Drawing.Size(197, 30);
            this.lb_velocidade.TabIndex = 9;
            this.lb_velocidade.Text = "Vel Ar Saida";
            this.lb_velocidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_frequencia
            // 
            this.lb_frequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_frequencia.Location = new System.Drawing.Point(56, 384);
            this.lb_frequencia.Name = "lb_frequencia";
            this.lb_frequencia.Size = new System.Drawing.Size(180, 37);
            this.lb_frequencia.TabIndex = 10;
            this.lb_frequencia.Text = "Freq vent Radial";
            this.lb_frequencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(1121, 401);
            this.tb_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(119, 22);
            this.tb_ip.TabIndex = 11;
            this.tb_ip.Text = "10.15.20.17";
            // 
            // tb_porta
            // 
            this.tb_porta.Location = new System.Drawing.Point(1121, 446);
            this.tb_porta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_porta.Name = "tb_porta";
            this.tb_porta.Size = new System.Drawing.Size(119, 22);
            this.tb_porta.TabIndex = 12;
            this.tb_porta.Text = "10012";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1285, 612);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.bt_refri);
            this.tabPage1.Controls.Add(this.bt_ligar);
            this.tabPage1.Controls.Add(this.bt_grafico);
            this.tabPage1.Controls.Add(this.lb_pressao);
            this.tabPage1.Controls.Add(this.tb_porta);
            this.tabPage1.Controls.Add(this.bt_connect);
            this.tabPage1.Controls.Add(this.lb_temp);
            this.tabPage1.Controls.Add(this.tb_ip);
            this.tabPage1.Controls.Add(this.lb_vazao);
            this.tabPage1.Controls.Add(this.lb_frequencia);
            this.tabPage1.Controls.Add(this.lb_torque);
            this.tabPage1.Controls.Add(this.lb_velocidade);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPage1.ImageKey = "(nenhum/a)";
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1277, 583);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Planta de Valores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1156, 427);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Porta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1168, 384);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "IP:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1011, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 117);
            this.label5.TabIndex = 17;
            this.label5.Text = "label5";
            // 
            // bt_refri
            // 
            this.bt_refri.BackColor = System.Drawing.Color.White;
            this.bt_refri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refri.ForeColor = System.Drawing.Color.LimeGreen;
            this.bt_refri.Location = new System.Drawing.Point(335, 462);
            this.bt_refri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_refri.Name = "bt_refri";
            this.bt_refri.Size = new System.Drawing.Size(305, 79);
            this.bt_refri.TabIndex = 14;
            this.bt_refri.Text = "Ligar Compressor";
            this.bt_refri.UseVisualStyleBackColor = false;
            this.bt_refri.Click += new System.EventHandler(this.bt_refri_Click);
            // 
            // bt_grafico
            // 
            this.bt_grafico.BackColor = System.Drawing.Color.White;
            this.bt_grafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_grafico.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_grafico.Location = new System.Drawing.Point(37, 462);
            this.bt_grafico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_grafico.Name = "bt_grafico";
            this.bt_grafico.Size = new System.Drawing.Size(261, 79);
            this.bt_grafico.TabIndex = 13;
            this.bt_grafico.Text = "Gráfico";
            this.bt_grafico.UseVisualStyleBackColor = false;
            this.bt_grafico.Click += new System.EventHandler(this.bt_grafico_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1061, 361);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_pesquisar);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_ate);
            this.tabPage2.Controls.Add(this.tb_de);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1277, 583);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busca de dados históricos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Location = new System.Drawing.Point(637, 79);
            this.bt_pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(100, 28);
            this.bt_pesquisar.TabIndex = 10;
            this.bt_pesquisar.Text = "PESQUISAR";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView1.Location = new System.Drawing.Point(8, 123);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 444);
            this.dataGridView1.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Torque Radial";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Temperatura da Carcaça";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Pressão do ar de entrada";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Vazão de saída do Ar";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Velocidade do ar de saída";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Frequencia de rotação do ventilador";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Data e Hora";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Formatação ( yyyy/MM/dd HH:mm:ss )";
            // 
            // tb_ate
            // 
            this.tb_ate.Location = new System.Drawing.Point(347, 91);
            this.tb_ate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ate.Name = "tb_ate";
            this.tb_ate.Size = new System.Drawing.Size(255, 22);
            this.tb_ate.TabIndex = 5;
            // 
            // tb_de
            // 
            this.tb_de.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_de.Location = new System.Drawing.Point(347, 59);
            this.tb_de.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_de.Name = "tb_de";
            this.tb_de.Size = new System.Drawing.Size(256, 22);
            this.tb_de.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa por Data e Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "De";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 609);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ligar;
        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.Label lb_pressao;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Label lb_vazao;
        private System.Windows.Forms.Label lb_torque;
        private System.Windows.Forms.Label lb_velocidade;
        private System.Windows.Forms.Label lb_frequencia;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_porta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bt_grafico;
        private System.Windows.Forms.TextBox tb_ate;
        private System.Windows.Forms.TextBox tb_de;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.Button bt_refri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

