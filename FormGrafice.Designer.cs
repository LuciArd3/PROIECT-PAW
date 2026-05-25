namespace PROIECT_PAW
{
    partial class FormGrafice
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPie = new System.Windows.Forms.TabPage();
            this.chartTipuri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabBar1 = new System.Windows.Forms.TabPage();
            this.chartVenituri = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabBar2 = new System.Windows.Forms.TabPage();
            this.chartStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReincarca = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTipuri)).BeginInit();
            this.tabBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVenituri)).BeginInit();
            this.tabBar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPie);
            this.tabControl1.Controls.Add(this.tabBar1);
            this.tabControl1.Controls.Add(this.tabBar2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 625);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPie
            // 
            this.tabPie.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPie.Controls.Add(this.chartTipuri);
            this.tabPie.Location = new System.Drawing.Point(4, 32);
            this.tabPie.Name = "tabPie";
            this.tabPie.Size = new System.Drawing.Size(952, 589);
            this.tabPie.TabIndex = 0;
            this.tabPie.Text = "  Rezervari - Tip Camera";
            // 
            // chartTipuri
            // 
            this.chartTipuri.BackColor = System.Drawing.Color.Black;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            chartArea4.Name = "ChartArea1";
            this.chartTipuri.ChartAreas.Add(chartArea4);
            this.chartTipuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTipuri.Location = new System.Drawing.Point(0, 0);
            this.chartTipuri.Name = "chartTipuri";
            this.chartTipuri.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            this.chartTipuri.Size = new System.Drawing.Size(952, 589);
            this.chartTipuri.TabIndex = 0;
            this.chartTipuri.Click += new System.EventHandler(this.chartTipuri_Click);
            // 
            // tabBar1
            // 
            this.tabBar1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabBar1.Controls.Add(this.chartVenituri);
            this.tabBar1.Location = new System.Drawing.Point(4, 32);
            this.tabBar1.Name = "tabBar1";
            this.tabBar1.Size = new System.Drawing.Size(952, 589);
            this.tabBar1.TabIndex = 1;
            this.tabBar1.Text = "  Venituri - Tip Camera  ";
            // 
            // chartVenituri
            // 
            this.chartVenituri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            chartArea5.Name = "ChartArea1";
            this.chartVenituri.ChartAreas.Add(chartArea5);
            this.chartVenituri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartVenituri.Location = new System.Drawing.Point(0, 0);
            this.chartVenituri.Name = "chartVenituri";
            this.chartVenituri.Size = new System.Drawing.Size(952, 589);
            this.chartVenituri.TabIndex = 0;
            this.chartVenituri.Click += new System.EventHandler(this.chartVenituri_Click);
            // 
            // tabBar2
            // 
            this.tabBar2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabBar2.Controls.Add(this.chartStatus);
            this.tabBar2.Location = new System.Drawing.Point(4, 32);
            this.tabBar2.Name = "tabBar2";
            this.tabBar2.Size = new System.Drawing.Size(952, 589);
            this.tabBar2.TabIndex = 2;
            this.tabBar2.Text = "  Rezervari - Status  ";
            // 
            // chartStatus
            // 
            this.chartStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            chartArea6.Name = "ChartArea1";
            this.chartStatus.ChartAreas.Add(chartArea6);
            this.chartStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStatus.Location = new System.Drawing.Point(0, 0);
            this.chartStatus.Name = "chartStatus";
            this.chartStatus.Size = new System.Drawing.Size(952, 589);
            this.chartStatus.TabIndex = 0;
            // 
            // btnReincarca
            // 
            this.btnReincarca.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnReincarca.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReincarca.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnReincarca.Location = new System.Drawing.Point(790, 570);
            this.btnReincarca.Name = "btnReincarca";
            this.btnReincarca.Size = new System.Drawing.Size(160, 40);
            this.btnReincarca.TabIndex = 1;
            this.btnReincarca.Text = "⟳  Reîncarcă";
            this.btnReincarca.UseVisualStyleBackColor = false;
            this.btnReincarca.Click += new System.EventHandler(this.btnReincarca_Click);
            // 
            // FormGrafice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(960, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReincarca);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormGrafice";
            this.Text = "Statistici rezervari";
            this.tabControl1.ResumeLayout(false);
            this.tabPie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTipuri)).EndInit();
            this.tabBar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVenituri)).EndInit();
            this.tabBar2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPie;
        private System.Windows.Forms.TabPage tabBar1;
        private System.Windows.Forms.TabPage tabBar2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTipuri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVenituri;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatus;
        private System.Windows.Forms.Button btnReincarca;
    }
}
