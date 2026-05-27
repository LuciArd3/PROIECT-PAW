namespace PROIECT_PAW
{
    partial class ClientInputControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitlu.Location = new System.Drawing.Point(107, 2);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(113, 40);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Date Client";
            this.lblTitlu.Click += new System.EventHandler(this.lblTitlu_Click);
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(6, 48);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(43, 16);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "&Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(114, 45);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(171, 22);
            this.tbNume.TabIndex = 2;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(6, 85);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(30, 16);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "&Sex";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.cbSex.Location = new System.Drawing.Point(114, 82);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(171, 24);
            this.cbSex.TabIndex = 4;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 123);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "&Telefon";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(114, 119);
            this.tbTelefon.MaxLength = 10;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(171, 22);
            this.tbTelefon.TabIndex = 6;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ClientInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.tbTelefon);
            this.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Name = "ClientInputControl";
            this.Size = new System.Drawing.Size(320, 160);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
