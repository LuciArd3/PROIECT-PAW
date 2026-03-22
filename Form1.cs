using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PROIECT_PAW
{
    public partial class Form1 : Form
    {
        List<Rezervare> listaRezervari = new List<Rezervare>();
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            tbPretCamera.KeyPress += tbPret_KeyPress; 
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                tbNumeClient.Clear();
                tbTelefon.Clear();
                tbNumarCamera.Clear();
                tbPretCamera.Clear();
                tbIdRezervare.Clear();
                cbSex.Text = "";
                cbTipCamera.Text = "";
                cbEtajCamera.Text = "";
                cbStatusRezervare.Text = "";
                dateTimePickerCheckIn.Value = DateTime.Now;
                dateTimePickerCheckOut.Value = DateTime.Now;
                tbSedereDurata.Clear();
                tbCostTotal.Clear();
            }
            if (e.KeyCode == Keys.F1)
            {
                Form2 f2 = new Form2(listaRezervari);
                f2.Show();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnAdaugaRezervare_Click(sender, e);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaugaRezervare_Click(object sender, EventArgs e)
        {
            if (tbNumeClient.Text == "")
                errorProvider1.SetError(tbNumeClient, "Introduceti numele!");
            else
                if (cbSex.Text == "")
                errorProvider1.SetError(cbSex, "Introduceti sexul!");
            else
                if (tbTelefon.Text == "")
                errorProvider1.SetError(tbTelefon, "Introduceti nr. de telefon !");
            else
            if (!tbTelefon.Text.All(char.IsDigit))
                errorProvider1.SetError(tbTelefon, "Numarul de telefon invalid!");
            else
                if (tbNumarCamera.Text == "")
                errorProvider1.SetError(tbNumarCamera, "Introduceti numarul camerei!");
            else
                if (cbTipCamera.Text == "")
                errorProvider1.SetError(cbTipCamera, "Introduceti tipul camerei!");
            else
                if (tbPretCamera.Text == "")
                errorProvider1.SetError(tbPretCamera, "Introduceti pretul!");
            else
                if (cbEtajCamera.Text == "")
                errorProvider1.SetError(cbEtajCamera, "Introduceti etajul!");
            else
                if (tbIdRezervare.Text == "")
                errorProvider1.SetError(tbIdRezervare, "Introduceti ID-ul rezervarii!");
            else
                if (cbStatusRezervare.Text == "")
                errorProvider1.SetError(cbStatusRezervare, "Introduceti statusul!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string nume = tbNumeClient.Text;
                    char sex = Convert.ToChar(cbSex.Text);
                    string telefon = tbTelefon.Text;
                
                    Client client = new Client(nume, sex, telefon);

                    int numar = Convert.ToInt32(tbNumarCamera.Text);
                    string tip = cbTipCamera.Text;
                    float pretNoapte = (float)Convert.ToDouble(tbPretCamera.Text);
                    int etaj = Convert.ToInt32(cbEtajCamera.Text);
                    Camera camera = new Camera(numar, tip, pretNoapte, etaj);

                    int id = Convert.ToInt32(tbIdRezervare.Text);
                    DateTime checkIn = dateTimePickerCheckIn.Value;
                    DateTime checkOut = dateTimePickerCheckOut.Value;
                    string status = cbStatusRezervare.Text;

                    if (checkOut < checkIn)
                        throw new Exception("Data de check-out are loc dupa data de check-in!");



                    Rezervare rezervare = new Rezervare(id, client, camera, checkIn, checkOut, status);
                    tbSedereDurata.Text = rezervare.noptiSedere().ToString();
                    tbCostTotal.Text = rezervare.costTotal().ToString();

                    MessageBox.Show(rezervare.ToString());
                    listaRezervari.Add(rezervare);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNumeClient.Clear();
              
                    tbTelefon.Clear();
                    tbNumarCamera.Clear();
                    tbPretCamera.Clear();
                    tbIdRezervare.Clear();
                    cbSex.Text = "";
                    cbTipCamera.Text = "";
                    cbEtajCamera.Text = "";
                    cbStatusRezervare.Text = "";
                    dateTimePickerCheckIn.Value = DateTime.Now;
                    dateTimePickerCheckOut.Value = DateTime.Now;
                }
            }
        }

        private void tbCifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true; 
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void afisareRezervari_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listaRezervari);
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriți să ieșiți?", "Confirmare",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void fisierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
