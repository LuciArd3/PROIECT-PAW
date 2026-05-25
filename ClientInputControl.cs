using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class ClientInputControl : UserControl
    {
        public ClientInputControl()
        {
            InitializeComponent();
        }

        public string NumeClient => tbNume.Text;
        public string Telefon => tbTelefon.Text;
        public char Sex => cbSex.Text.Length > 0
                                    ? Convert.ToChar(cbSex.Text) : 'N';

        public bool Valideaza()
        {
            if (tbNume.Text == "")
            { errorProvider1.SetError(tbNume, "Introduceti numele!"); return false; }
            if (cbSex.Text == "")
            { errorProvider1.SetError(cbSex, "Introduceti sexul!"); return false; }
            if (tbTelefon.Text == "")
            { errorProvider1.SetError(tbTelefon, "Introduceti telefonul!"); return false; }
            if (tbTelefon.Text.Length < 10)
            { errorProvider1.SetError(tbTelefon, "Telefonul trebuie sa aiba 10 cifre!"); return false; }
            errorProvider1.Clear();
            return true;
        }

        public void Goleste()
        {
            tbNume.Clear();
            tbTelefon.Clear();
            cbSex.Text = "";
            errorProvider1.Clear();
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}