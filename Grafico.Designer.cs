namespace Refrigeracao
{
    partial class Grafico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bt_torque = new System.Windows.Forms.Button();
            this.bt_temperatura = new System.Windows.Forms.Button();
            this.bt_vazao = new System.Windows.Forms.Button();
            this.bt_pressao = new System.Windows.Forms.Button();
            this.bt_frequencia = new System.Windows.Forms.Button();
            this.bt_velocidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(580, 426);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // bt_torque
            // 
            this.bt_torque.Location = new System.Drawing.Point(610, 70);
            this.bt_torque.Name = "bt_torque";
            this.bt_torque.Size = new System.Drawing.Size(178, 44);
            this.bt_torque.TabIndex = 1;
            this.bt_torque.Text = "Torque";
            this.bt_torque.UseVisualStyleBackColor = true;
            this.bt_torque.Click += new System.EventHandler(this.Bt_torque_Click);
            // 
            // bt_temperatura
            // 
            this.bt_temperatura.Location = new System.Drawing.Point(610, 130);
            this.bt_temperatura.Name = "bt_temperatura";
            this.bt_temperatura.Size = new System.Drawing.Size(178, 44);
            this.bt_temperatura.TabIndex = 2;
            this.bt_temperatura.Text = "Temperatura";
            this.bt_temperatura.UseVisualStyleBackColor = true;
            this.bt_temperatura.Click += new System.EventHandler(this.Bt_temperatura_Click);
            // 
            // bt_vazao
            // 
            this.bt_vazao.Location = new System.Drawing.Point(610, 249);
            this.bt_vazao.Name = "bt_vazao";
            this.bt_vazao.Size = new System.Drawing.Size(178, 44);
            this.bt_vazao.TabIndex = 3;
            this.bt_vazao.Text = "Vazão";
            this.bt_vazao.UseVisualStyleBackColor = true;
            this.bt_vazao.Click += new System.EventHandler(this.Bt_vazao_Click);
            // 
            // bt_pressao
            // 
            this.bt_pressao.Location = new System.Drawing.Point(610, 190);
            this.bt_pressao.Name = "bt_pressao";
            this.bt_pressao.Size = new System.Drawing.Size(178, 44);
            this.bt_pressao.TabIndex = 3;
            this.bt_pressao.Text = "Pressão";
            this.bt_pressao.UseVisualStyleBackColor = true;
            this.bt_pressao.Click += new System.EventHandler(this.Bt_pressao_Click);
            // 
            // bt_frequencia
            // 
            this.bt_frequencia.Location = new System.Drawing.Point(610, 369);
            this.bt_frequencia.Name = "bt_frequencia";
            this.bt_frequencia.Size = new System.Drawing.Size(178, 44);
            this.bt_frequencia.TabIndex = 4;
            this.bt_frequencia.Text = "Frequência";
            this.bt_frequencia.UseVisualStyleBackColor = true;
            this.bt_frequencia.Click += new System.EventHandler(this.Bt_frequencia_Click);
            // 
            // bt_velocidade
            // 
            this.bt_velocidade.Location = new System.Drawing.Point(610, 309);
            this.bt_velocidade.Name = "bt_velocidade";
            this.bt_velocidade.Size = new System.Drawing.Size(178, 44);
            this.bt_velocidade.TabIndex = 4;
            this.bt_velocidade.Text = "Velocidade";
            this.bt_velocidade.UseVisualStyleBackColor = true;
            this.bt_velocidade.Click += new System.EventHandler(this.Bt_velocidade_Click);
            // 
            // Grafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_velocidade);
            this.Controls.Add(this.bt_frequencia);
            this.Controls.Add(this.bt_pressao);
            this.Controls.Add(this.bt_vazao);
            this.Controls.Add(this.bt_temperatura);
            this.Controls.Add(this.bt_torque);
            this.Controls.Add(this.chart1);
            this.Name = "Grafico";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Grafico_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bt_torque;
        private System.Windows.Forms.Button bt_temperatura;
        private System.Windows.Forms.Button bt_vazao;
        private System.Windows.Forms.Button bt_pressao;
        private System.Windows.Forms.Button bt_frequencia;
        private System.Windows.Forms.Button bt_velocidade;
    }
}