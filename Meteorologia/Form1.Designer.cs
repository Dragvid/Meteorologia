namespace Meteorologia
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_chamada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_td = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_cidades = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(155, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Temperatura";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(633, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btn_chamada
            // 
            this.btn_chamada.Location = new System.Drawing.Point(12, 12);
            this.btn_chamada.Name = "btn_chamada";
            this.btn_chamada.Size = new System.Drawing.Size(75, 23);
            this.btn_chamada.TabIndex = 1;
            this.btn_chamada.Text = "temperatura";
            this.btn_chamada.UseVisualStyleBackColor = true;
            this.btn_chamada.Click += new System.EventHandler(this.Btn_chamada_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nível de precipitação:";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(271, 395);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(13, 13);
            this.lbl_estado.TabIndex = 4;
            this.lbl_estado.Text = "[]";
            // 
            // lbl_td
            // 
            this.lbl_td.AutoSize = true;
            this.lbl_td.Location = new System.Drawing.Point(545, 395);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(13, 13);
            this.lbl_td.TabIndex = 10;
            this.lbl_td.Text = "[]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperatura do dia:";
            // 
            // cbb_cidades
            // 
            this.cbb_cidades.FormattingEnabled = true;
            this.cbb_cidades.Location = new System.Drawing.Point(12, 41);
            this.cbb_cidades.Name = "cbb_cidades";
            this.cbb_cidades.Size = new System.Drawing.Size(121, 21);
            this.cbb_cidades.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbb_cidades);
            this.Controls.Add(this.lbl_td);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_chamada);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_chamada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_td;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_cidades;
    }
}

