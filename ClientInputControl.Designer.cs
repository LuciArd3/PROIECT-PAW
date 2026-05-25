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

            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitlu.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitlu.Location = new System.Drawing.Point(50, 8);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Text = "Date Client";

            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(5, 45);
            this.lblNume.Name = "lblNume";
            this.lblNume.Text = "&Nume";

            this.tbNume.Location = new System.Drawing.Point(100, 42);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(150, 23);

            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(5, 80);
            this.lblSex.Name = "lblSex";
            this.lblSex.Text = "&Sex";

            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] { "M", "F", "N" });
            this.cbSex.Location = new System.Drawing.Point(100, 77);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(150, 23);

            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(5, 115);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Text = "&Telefon";

            this.tbTelefon.Location = new System.Drawing.Point(100, 112);
            this.tbTelefon.MaxLength = 10;
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(150, 23);
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(
                                        this.tbTelefon_KeyPress);

            this.errorProvider1.ContainerControl = this;

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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
            this.Size = new System.Drawing.Size(280, 150);

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
