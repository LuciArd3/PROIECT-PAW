using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROIECT_PAW
{
    public partial class Form2 : Form
    {
        List<Rezervare> listaRezervari;
        private readonly DatabaseHelper db;

        private int _printIndex = 0;
        private PrintDocument _printDoc;


        private ListViewItem _dragItem = null;   
        private int _dropLineIndex = -1;     
        private Pen _dropLinePen = new Pen(Color.DarkGoldenrod, 2);

        public Form2(List<Rezervare> lista , DatabaseHelper db)
        {
            InitializeComponent();
            listaRezervari = lista;
            this.db = db;

            _printDoc = new PrintDocument();
            _printDoc.DocumentName = "Raport Rezervari Hotel";
            _printDoc.PrintPage += PrintDoc_PrintPage;
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
                    db.Sterge(id);
                }
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            _dragItem = (ListViewItem)e.Item;
            listView1.DoDragDrop(_dragItem, DragDropEffects.Move);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragOver(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(typeof(ListViewItem)))
            { e.Effect = DragDropEffects.None; return; }

            e.Effect = DragDropEffects.Move;

            Point pt = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem target = listView1.GetItemAt(pt.X, pt.Y);

            int newIndex = (target != null)
                ? target.Index
                : listView1.Items.Count - 1;

            if (newIndex != _dropLineIndex)
            {
                _dropLineIndex = newIndex;
                listView1.Invalidate();
            }
        }

   
        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

            if (e.ItemIndex == _dropLineIndex && _dragItem != null
                && e.ItemIndex != _dragItem.Index)
            {
      
                int y = e.Bounds.Top;
                e.Graphics.DrawLine(_dropLinePen,
                    e.Bounds.Left, y, e.Bounds.Right, y);
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            if (_dragItem == null) return;

            Point pt = listView1.PointToClient(new Point(e.X, e.Y));
            ListViewItem targetItm = listView1.GetItemAt(pt.X, pt.Y);

            int fromIdx = _dragItem.Index;
            int toIdx = (targetItm != null)
                ? targetItm.Index
                : listView1.Items.Count - 1;

            if (fromIdx == toIdx) { _dragItem = null; _dropLineIndex = -1; return; }

 
            listView1.BeginUpdate();
            ListViewItem clone = (ListViewItem)_dragItem.Clone();
            listView1.Items.RemoveAt(fromIdx);
            listView1.Items.Insert(toIdx, clone);
            clone.Selected = true;
            listView1.EndUpdate();

            Rezervare rMutata = listaRezervari[fromIdx];
            listaRezervari.RemoveAt(fromIdx);
            listaRezervari.Insert(toIdx, rMutata);

            _dragItem = null;
            _dropLineIndex = -1;
            listView1.Invalidate();
        }

        private void listView1_DragLeave(object sender, EventArgs e)
        {
            _dragItem = null;
            _dropLineIndex = -1;
            listView1.Invalidate();
        }


        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle margin = e.MarginBounds;
            int x = margin.Left, y = margin.Top, w = margin.Width;

            Font fontTitlu = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontSubtitlu = new Font("Segoe UI", 9, FontStyle.Italic);
            Font fontHeader = new Font("Segoe UI", 8, FontStyle.Bold);
            Font fontRand = new Font("Segoe UI", 8, FontStyle.Regular);
            Font fontTotal = new Font("Segoe UI", 9, FontStyle.Bold);
            Brush brushHeader = new SolidBrush(Color.FromArgb(45, 45, 48));
            Brush brushAlt = new SolidBrush(Color.FromArgb(240, 240, 240));

            if (_printIndex == 0)
            {
                string titlu = "RAPORT REZERVĂRI HOTEL";
                SizeF sz = g.MeasureString(titlu, fontTitlu);
                g.DrawString(titlu, fontTitlu, Brushes.Black,
                    x + (w - sz.Width) / 2, y);
                y += (int)sz.Height + 4;

                string sub = $"Generat la: {DateTime.Now:dd/MM/yyyy HH:mm}   |   " +
                             $"Total rezervări: {listaRezervari.Count}";
                SizeF szS = g.MeasureString(sub, fontSubtitlu);
                g.DrawString(sub, fontSubtitlu, Brushes.Gray,
                    x + (w - szS.Width) / 2, y);
                y += (int)szS.Height + 6;
                g.DrawLine(Pens.DarkGoldenrod, x, y, x + w, y);
                y += 10;
            }

            int[] colW = { 35, 130, 55, 80, 75, 75, 45, 75, 90 };
            string[] hdrs = { "ID","Client","Cameră","Tip",
                               "Check-In","Check-Out","Nopți","Cost (RON)","Status" };
            int rowH = 18;

            g.FillRectangle(brushHeader, x, y, w, rowH);
            int cx = x;
            foreach (var (h, cw) in Zip(hdrs, colW))
            {
                g.DrawString(h, fontHeader, Brushes.White,
                    new RectangleF(cx + 2, y + 2, cw - 2, rowH));
                cx += cw;
            }
            y += rowH;

            bool hasMore = false;
            int row = 0;
            while (_printIndex < listaRezervari.Count)
            {
                if (y + rowH * 3 > margin.Bottom) { hasMore = true; break; }

                Rezervare r = listaRezervari[_printIndex];
                g.FillRectangle(row % 2 == 0 ? Brushes.White : brushAlt, x, y, w, rowH);

                string[] vals = {
                    r.Id.ToString(), r.Client.Nume, r.Camera.Numar.ToString(),
                    r.Camera.Tip, r.DataCheckIn.ToShortDateString(),
                    r.DataCheckOut.ToShortDateString(),
                    r.noptiSedere().ToString(), r.costTotal().ToString("F2"), r.Status
                };

                cx = x;
                foreach (var (v, cw) in Zip(vals, colW))
                {
                    g.DrawString(v, fontRand, Brushes.Black,
                        new RectangleF(cx + 2, y + 2, cw - 2, rowH));
                    cx += cw;
                }
                g.DrawLine(Pens.LightGray, x, y + rowH, x + w, y + rowH);
                y += rowH; row++; _printIndex++;
            }

            if (!hasMore)
            {
                y += 6;
                g.DrawLine(Pens.DarkGoldenrod, x, y, x + w, y);
                y += 4;
                float total = 0;
                foreach (var r in listaRezervari) total += r.costTotal();
                g.DrawString($"TOTAL GENERAL:   {total:F2} RON   ({listaRezervari.Count} rezervări)",
                    fontTotal, Brushes.DarkGoldenrod, x, y);
                string footer = "Hotel Management System  •  Document generat automat";
                SizeF szF = g.MeasureString(footer, fontSubtitlu);
                g.DrawString(footer, fontSubtitlu, Brushes.Gray,
                    x + (w - szF.Width) / 2, margin.Bottom - 20);
            }

            e.HasMorePages = hasMore;
            fontTitlu.Dispose(); fontSubtitlu.Dispose();
            fontHeader.Dispose(); fontRand.Dispose(); fontTotal.Dispose();
            brushHeader.Dispose(); brushAlt.Dispose();
        }

        private IEnumerable<(T1, T2)> Zip<T1, T2>(T1[] a, T2[] b)
        {
            for (int i = 0; i < Math.Min(a.Length, b.Length); i++)
                yield return (a[i], b[i]);
        }

     

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            if (listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu există rezervări de printat!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            _printIndex = 0;
            using (var ppd = new PrintPreviewDialog())
            {
                ppd.Document = _printDoc;
                ppd.Width = 1000; ppd.Height = 750;
                ppd.Text = "Previzualizare Raport Rezervări";
                ppd.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu există rezervări de printat!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            using (var pd = new PrintDialog())
            {
                pd.Document = _printDoc;
                if (pd.ShowDialog() == DialogResult.OK)
                { _printIndex = 0; _printDoc.Print(); }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            => stergeSelectate();

        private void button1_Click(object sender, EventArgs e)
        {
            listaRezervari.Sort();
            listView1.Items.Clear();
            foreach (Rezervare r in listaRezervari) adaugaInListView(r);
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var fs = new FileStream("rezervari.dat", FileMode.Create, FileAccess.Write))
                new BinaryFormatter().Serialize(fs, listaRezervari);
            MessageBox.Show("Salvat cu succes!", "Serializare",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!File.Exists("rezervari.dat"))
            {
                MessageBox.Show("Nu exista fisier salvat!", "Eroare",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            using (var fs = new FileStream("rezervari.dat", FileMode.Open, FileAccess.Read))
                listaRezervari = (List<Rezervare>)new BinaryFormatter().Deserialize(fs);
            listView1.Items.Clear();
            foreach (Rezervare r in listaRezervari) adaugaInListView(r);
            MessageBox.Show("Restaurat! Total: " + listaRezervari.Count + " rezervari.",
                "Deserializare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAfisareLista_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (listaRezervari.Count == 0)
            {
                MessageBox.Show("Nu exista rezervari!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            foreach (Rezervare r in listaRezervari) adaugaInListView(r);
        }

        private void btnSterge_Click(object sender, EventArgs e) => stergeSelectate();
    }
}