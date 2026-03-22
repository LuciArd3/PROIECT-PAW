using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Form2 : Form
    {
        List<Rezervare> listaRezervari;
        public Form2(List<Rezervare> lista)
        {
            InitializeComponent();
            listaRezervari = lista;
        }

        private void adaugaInListView(Rezervare r)
        {
            ListViewItem itm = new ListViewItem(r.Id.ToString());
            itm.SubItems.Add(r.Client.Nume);
            itm.SubItems.Add(r.Camera.Numar.ToString());
            itm.SubItems.Add(r.Camera.Tip);
            itm.SubItems.Add(r.DataCheckIn.ToShortDateString());
            itm.SubItems.Add(r.DataCheckOut.ToShortDateString());
            itm.SubItems.Add(r.noptiSedere().ToString());
            itm.SubItems.Add(r.costTotal().ToString("F2"));
            itm.SubItems.Add(r.Status);
            listView1.Items.Add(itm);
        }

        private void stergeSelectate()
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.Checked)
                {
                    int id = Convert.ToInt32(itm.SubItems[0].Text);
                    listaRezervari.RemoveAll(r => r.Id == id);
                    itm.Remove();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            stergeSelectate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaRezervari.Sort(); 
            listView1.Items.Clear();
            foreach (Rezervare r in listaRezervari)
                adaugaInListView(r);
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("rezervari.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, listaRezervari);
            fs.Close();
            MessageBox.Show("Salvat cu succes!", "Serializare",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("rezervari.dat"))
            {
                MessageBox.Show("Nu exista fisier salvat!", "Eroare",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FileStream fs = new FileStream("rezervari.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaRezervari = (List<Rezervare>)bf.Deserialize(fs);
            fs.Close();
            listView1.Items.Clear();
            foreach (Rezervare r in listaRezervari)
                adaugaInListView(r);
            MessageBox.Show("Restaurat! Total: " + listaRezervari.Count + " rezervari.", "Deserializare",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAfisareLista_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu exista rezervari!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (Rezervare r in listaRezervari)
                adaugaInListView(r);
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            stergeSelectate();
        }
    }
}
