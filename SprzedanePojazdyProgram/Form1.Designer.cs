namespace SprzedanePojazdyProgram
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_sumuj = new FontAwesome.Sharp.IconButton();
            this.button_wyjdz = new FontAwesome.Sharp.IconButton();
            this.button_zapisz = new FontAwesome.Sharp.IconButton();
            this.button_generuj = new FontAwesome.Sharp.IconButton();
            this.button_wczytaj = new FontAwesome.Sharp.IconButton();
            this.button_Menu = new System.Windows.Forms.PictureBox();
            this.panelGlowny = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_Menu)).BeginInit();
            this.panelGlowny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(61)))), ((int)(((byte)(121)))));
            this.panelMenu.Controls.Add(this.button_sumuj);
            this.panelMenu.Controls.Add(this.button_wyjdz);
            this.panelMenu.Controls.Add(this.button_zapisz);
            this.panelMenu.Controls.Add(this.button_generuj);
            this.panelMenu.Controls.Add(this.button_wczytaj);
            this.panelMenu.Controls.Add(this.button_Menu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 594);
            this.panelMenu.TabIndex = 1;
            // 
            // button_sumuj
            // 
            this.button_sumuj.BackColor = System.Drawing.Color.Transparent;
            this.button_sumuj.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_sumuj.FlatAppearance.BorderSize = 0;
            this.button_sumuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sumuj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_sumuj.ForeColor = System.Drawing.Color.White;
            this.button_sumuj.IconChar = FontAwesome.Sharp.IconChar.Car;
            this.button_sumuj.IconColor = System.Drawing.Color.White;
            this.button_sumuj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_sumuj.IconSize = 25;
            this.button_sumuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sumuj.Location = new System.Drawing.Point(0, 348);
            this.button_sumuj.Name = "button_sumuj";
            this.button_sumuj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_sumuj.Size = new System.Drawing.Size(237, 67);
            this.button_sumuj.TabIndex = 10;
            this.button_sumuj.Tag = "SUMUJ";
            this.button_sumuj.Text = " SUMUJ";
            this.button_sumuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_sumuj.UseVisualStyleBackColor = false;
            this.button_sumuj.Click += new System.EventHandler(this.button_sumuj_Click);
            // 
            // button_wyjdz
            // 
            this.button_wyjdz.BackColor = System.Drawing.Color.Transparent;
            this.button_wyjdz.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_wyjdz.FlatAppearance.BorderSize = 0;
            this.button_wyjdz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wyjdz.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wyjdz.ForeColor = System.Drawing.Color.White;
            this.button_wyjdz.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.button_wyjdz.IconColor = System.Drawing.Color.White;
            this.button_wyjdz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_wyjdz.IconSize = 25;
            this.button_wyjdz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_wyjdz.Location = new System.Drawing.Point(0, 527);
            this.button_wyjdz.Name = "button_wyjdz";
            this.button_wyjdz.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_wyjdz.Size = new System.Drawing.Size(237, 67);
            this.button_wyjdz.TabIndex = 9;
            this.button_wyjdz.Tag = "WYJDŹ";
            this.button_wyjdz.Text = " WYJDŹ";
            this.button_wyjdz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_wyjdz.UseVisualStyleBackColor = false;
            this.button_wyjdz.Click += new System.EventHandler(this.button_wyjdz_Click);
            // 
            // button_zapisz
            // 
            this.button_zapisz.BackColor = System.Drawing.Color.Transparent;
            this.button_zapisz.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_zapisz.FlatAppearance.BorderSize = 0;
            this.button_zapisz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zapisz.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zapisz.ForeColor = System.Drawing.Color.White;
            this.button_zapisz.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.button_zapisz.IconColor = System.Drawing.Color.White;
            this.button_zapisz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_zapisz.IconSize = 25;
            this.button_zapisz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zapisz.Location = new System.Drawing.Point(0, 281);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_zapisz.Size = new System.Drawing.Size(237, 67);
            this.button_zapisz.TabIndex = 3;
            this.button_zapisz.Tag = "ZAPISZ";
            this.button_zapisz.Text = " ZAPISZ";
            this.button_zapisz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_zapisz.UseVisualStyleBackColor = false;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // button_generuj
            // 
            this.button_generuj.BackColor = System.Drawing.Color.Transparent;
            this.button_generuj.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_generuj.FlatAppearance.BorderSize = 0;
            this.button_generuj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_generuj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_generuj.ForeColor = System.Drawing.Color.White;
            this.button_generuj.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.button_generuj.IconColor = System.Drawing.Color.White;
            this.button_generuj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_generuj.IconSize = 25;
            this.button_generuj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_generuj.Location = new System.Drawing.Point(0, 214);
            this.button_generuj.Name = "button_generuj";
            this.button_generuj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_generuj.Size = new System.Drawing.Size(237, 67);
            this.button_generuj.TabIndex = 2;
            this.button_generuj.Tag = "GENERUJ";
            this.button_generuj.Text = " GENERUJ";
            this.button_generuj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_generuj.UseVisualStyleBackColor = false;
            this.button_generuj.Click += new System.EventHandler(this.button_generuj_Click);
            // 
            // button_wczytaj
            // 
            this.button_wczytaj.BackColor = System.Drawing.Color.Transparent;
            this.button_wczytaj.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_wczytaj.FlatAppearance.BorderSize = 0;
            this.button_wczytaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_wczytaj.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_wczytaj.ForeColor = System.Drawing.Color.White;
            this.button_wczytaj.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.button_wczytaj.IconColor = System.Drawing.Color.White;
            this.button_wczytaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button_wczytaj.IconSize = 25;
            this.button_wczytaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_wczytaj.Location = new System.Drawing.Point(0, 147);
            this.button_wczytaj.Name = "button_wczytaj";
            this.button_wczytaj.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_wczytaj.Size = new System.Drawing.Size(237, 67);
            this.button_wczytaj.TabIndex = 1;
            this.button_wczytaj.Tag = "WCZYTAJ";
            this.button_wczytaj.Text = " WCZYTAJ";
            this.button_wczytaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_wczytaj.UseVisualStyleBackColor = false;
            this.button_wczytaj.Click += new System.EventHandler(this.button_wczytaj_Click);
            // 
            // button_Menu
            // 
            this.button_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Menu.Image = global::SprzedanePojazdyProgram.Properties.Resources.wojewodzkispispojazdow2;
            this.button_Menu.Location = new System.Drawing.Point(0, 0);
            this.button_Menu.Name = "button_Menu";
            this.button_Menu.Size = new System.Drawing.Size(237, 147);
            this.button_Menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button_Menu.TabIndex = 1;
            this.button_Menu.TabStop = false;
            this.button_Menu.Click += new System.EventHandler(this.button_Menu_Click);
            // 
            // panelGlowny
            // 
            this.panelGlowny.BackColor = System.Drawing.Color.White;
            this.panelGlowny.Controls.Add(this.label2);
            this.panelGlowny.Controls.Add(this.label1);
            this.panelGlowny.Controls.Add(this.dataGridView1);
            this.panelGlowny.Controls.Add(this.comboBox1);
            this.panelGlowny.Controls.Add(this.chart1);
            this.panelGlowny.Controls.Add(this.chart);
            this.panelGlowny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGlowny.Location = new System.Drawing.Point(237, 0);
            this.panelGlowny.Name = "panelGlowny";
            this.panelGlowny.Size = new System.Drawing.Size(1092, 594);
            this.panelGlowny.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(287, 340);
            this.dataGridView1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(319, 323);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(747, 260);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(344, 23);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(722, 294);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1329, 594);
            this.Controls.Add(this.panelGlowny);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WOJEWÓDZKI SPIS POJAZDÓW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_Menu)).EndInit();
            this.panelGlowny.ResumeLayout(false);
            this.panelGlowny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelGlowny;
        private FontAwesome.Sharp.IconButton button_wyjdz;
        private FontAwesome.Sharp.IconButton button_zapisz;
        private FontAwesome.Sharp.IconButton button_generuj;
        private FontAwesome.Sharp.IconButton button_wczytaj;
        private System.Windows.Forms.PictureBox button_Menu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton button_sumuj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}

