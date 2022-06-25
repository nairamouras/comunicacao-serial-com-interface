namespace InterfaceRadio
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Grafico2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.go = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.comserial = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafico1
            // 
            this.Grafico1.BackColor = System.Drawing.Color.Gray;
            chartArea3.Name = "ChartArea1";
            this.Grafico1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Grafico1.Legends.Add(legend3);
            this.Grafico1.Location = new System.Drawing.Point(12, 164);
            this.Grafico1.Name = "Grafico1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            series3.Legend = "Legend1";
            series3.Name = "Sensor1";
            this.Grafico1.Series.Add(series3);
            this.Grafico1.Size = new System.Drawing.Size(450, 263);
            this.Grafico1.TabIndex = 0;
            this.Grafico1.Text = "chart1";
            // 
            // Grafico2
            // 
            this.Grafico2.BackColor = System.Drawing.Color.Gray;
            chartArea4.Name = "ChartArea1";
            this.Grafico2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Grafico2.Legends.Add(legend4);
            this.Grafico2.Location = new System.Drawing.Point(476, 163);
            this.Grafico2.Name = "Grafico2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Sensor2";
            this.Grafico2.Series.Add(series4);
            this.Grafico2.Size = new System.Drawing.Size(450, 263);
            this.Grafico2.TabIndex = 1;
            this.Grafico2.Text = "chart1";
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Honeydew;
            this.go.Location = new System.Drawing.Point(690, 94);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(75, 23);
            this.go.TabIndex = 2;
            this.go.Text = "GO";
            this.go.UseVisualStyleBackColor = false;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Honeydew;
            this.stop.Location = new System.Drawing.Point(812, 94);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "STOP";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // comserial
            // 
            this.comserial.FormattingEnabled = true;
            this.comserial.Location = new System.Drawing.Point(766, 34);
            this.comserial.Name = "comserial";
            this.comserial.Size = new System.Drawing.Size(121, 21);
            this.comserial.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(687, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Porta Serial";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comserial);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.go);
            this.Controls.Add(this.Grafico2);
            this.Controls.Add(this.Grafico1);
            this.Name = "Form1";
            this.Text = "Comunicação Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico2;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ComboBox comserial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

