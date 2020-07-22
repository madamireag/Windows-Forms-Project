using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Tema1.Models;

namespace Tema1
{
    public partial class Form1 : Form
    {
        List<Pariu> lista = new List<Pariu>();
        public Form1()
        {
            InitializeComponent();
            cbTip.DataSource = Enum.GetValues(typeof(TipMeci)); //data binding
            cbTip.SelectedIndex = 2; //valoare default
            //aduc valorile din BD in listview
            //PariuriContext pc = new PariuriContext();
            //lista = pc.Pariuri.ToList();
            //foreach(var p in lista)
            //{
            //    ListViewItem item = new ListViewItem(p.Suma.ToString());
            //    p.meci = new MeciSnooker();
            //   // p.meci = pc.MeciuriSnooker.First(m => m.Id == );
            //    item.SubItems.Add(p.meci.Sport.ToString()); 
            //   item.SubItems.Add(p.meci.Data.ToString()); //nu merge cum trebuie :(
            //   item.SubItems.Add(p.CastigatorSelectat);
            //   item.SubItems.Add(p.CotaCastigator.ToString());
            //    this.lvMeciuri.Items.Add(item);

            //}
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            String value = tbCastigator.Text;
            float suma = 0;
            try
            {
                suma = float.Parse(tbSuma.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Suma = valoare numerica", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                isValid = false;
            }

            Enum.TryParse(cbTip.Text, out TipMeci tip);
            DateTime DataMeci = dtpMeci.Value.Date;
            string player = tbJucator.Text;
            string opponent = tbOponent.Text;
            string winner = tbCastigator.Text;
            float cota = 0;
            try
            {
                cota = float.Parse(tbCotaCastig.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Cota e valoare numerica", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                isValid = false;
            }


            //Verificare castigator sa fie unul din jucatorii introdusi anterior 
            if (!winner.Equals(player) && !winner.Equals(opponent))
            {
                isValid = false;
                MessageBox.Show("Castigatorul nu este valid", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            if (isValid)

            {
                try
                {
                    MeciSnooker ms = new MeciSnooker(DataMeci, tip, player, opponent);
                    Pariu p = new Pariu(suma, winner, cota, ms);

                    lista.Add(p);

                    populareListView();

                    curataCampuri();

                }
                catch (CustomExceptionSuma ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

                MessageBox.Show("Formularul contine erori!", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            StripStatusLabel.Text = "Pariuri adaugate " + lista.Count();
   } 

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataCampuri();
        }
        #region MetodeAuxiliare 
        private void curataCampuri()
        {
            tbSuma.Clear();
            tbCastigator.Clear();
            tbCotaCastig.Clear();
            tbJucator.Clear();
            tbOponent.Clear();
            cbTip.SelectedIndex = -1;
            dtpMeci.Value = DateTime.Now;
        }
        private void populareListView()
        {
            lvMeciuri.Items.Clear();

            foreach (Pariu par in lista)
            {
                ListViewItem item = new ListViewItem(new String[] { par.Suma.ToString(),
                        par.meci.Sport.ToString(),par.meci.Data.ToString(),par.CastigatorSelectat,par.CotaCastigator.ToString()});
                lvMeciuri.Items.Add(item);
            }
        }
        #endregion

        #region ErrorProviders
        private void tbSuma_Validating(object sender, CancelEventArgs e)
        {
            String value = tbSuma.Text;
            if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
            {
                epSuma.SetError((Control)sender, "Completeaza suma!");
                e.Cancel = true;
            }
        }

        private void tbSuma_Validated(object sender, EventArgs e)
        {
            epSuma.Clear();
        }

        private void dtpMeci_Validating(object sender, CancelEventArgs e)
        {
            DateTime datas = dtpMeci.Value;
            DateTime dataCurenta = DateTime.Today;

            if (DateTime.Compare(datas, dataCurenta) < 0)
            {
                epData.SetError(dtpMeci, "Meciul nu poate avea o data din trecut!!");
                e.Cancel = true;
            }
        }

        private void dtpMeci_Validated(object sender, EventArgs e)
        {
            epData.Clear();
        }
        private void cbTip_Validating(object sender, CancelEventArgs e)
        {
            if (cbTip.SelectedIndex == -1)
            {
                epSport.SetError((Control)sender, "Selectati sportul!");
                e.Cancel = true;

            }
        }

        private void cbTip_Validated(object sender, EventArgs e)
        {
            epSport.Clear();
        }

        private void tbCastigator_Validating(object sender, CancelEventArgs e)
        {
            String c = tbCastigator.Text;
            if (String.IsNullOrEmpty(c) || String.IsNullOrWhiteSpace(c))
            {
                epCastigator.SetError((Control)sender, "Alege un castigator");
                e.Cancel = true;
            }
        }

        private void tbCastigator_Validated(object sender, EventArgs e)
        {
            epCastigator.Clear();
        }

        #endregion

        //Stergere 
        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (lvMeciuri.SelectedItems.Count != 0)
            {
                if (MessageBox.Show("Doresti sa stergi pariul?", "Stergere",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lista.RemoveAt(lvMeciuri.SelectedIndices[0]);
                    populareListView();
                }
            }
        }

        //Formular secundar editare
        private void btnEditeaza_Click(object sender, EventArgs e)
        {
            if (lvMeciuri.SelectedItems.Count != 0)
            {
                Pariu bet = lista.ElementAt(lvMeciuri.SelectedIndices[0]);

                EditarePariuri editarePariuri = new EditarePariuri(bet);
                editarePariuri.ShowDialog();

                populareListView();
            }

        }
        #region ContextMenuStrip
        private void cms__editeaza_Click(object sender, EventArgs e)
        {
            btnEditeaza_Click(sender, e);
        }

        private void cms_sterge_Click(object sender, EventArgs e)
        {
            btnSterge_Click(sender, e);
        }

        private void lvMeciuri_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cms.Show(Cursor.Position.X + 5, Cursor.Position.Y + 5);
            }
        }

        private void lvMeciuri_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left &&
                lvMeciuri.FocusedItem.Bounds.Contains(e.Location))
            {
                btnEditeaza_Click(sender, e);
            }
        }
        #endregion

        #region MenuBar
        private void detaliiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mireag Madalina 1052", "Detalii owner aplicatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #endregion


        #region Link Label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //utilizatorul poate vedea campionatele/meciurile pe site-ul oficial al federatiei de Snooker
            Process.Start("http://livescores.worldsnookerdata.com/");
        }
        #endregion

        #region Tool Bar(Strip)->Export txt
        //Export Txt
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Salveaza in fisier text";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 1;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                foreach (Pariu pariu in lista)
                {
                    sw.Write(pariu.Suma + "," + pariu.meci.Sport + "," + pariu.meci.Data + "," + pariu.CastigatorSelectat + "," + pariu.CotaCastigator + "\r\n");
                }

                sw.Close();
            }
        }


        #endregion

        #region Print
        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            pageSetupDialog.Document = printDocument;
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Brush brush = Brushes.DarkOrchid;
            Font font = new Font("Times New Roman", 20);

            Pen pen = new Pen(brush);

            PageSettings settings = printDocument.DefaultPageSettings;
            var totalLatime = settings.PaperSize.Width - settings.Margins.Left - settings.Margins.Right;
            var totalInaltime = settings.PaperSize.Height - settings.Margins.Bottom - settings.Margins.Top;

            if (settings.Landscape)
            {
                var temp = totalLatime;
                totalInaltime = totalLatime;
                totalLatime = temp;
            }
            int x = settings.Margins.Left;
            int y = 100;
            graphics.DrawString("Bilet Pariuri", font, brush, totalLatime / 3, y);
            y += 80;
            //lista cu pariuri
            foreach (Pariu p in lista)
            {
                graphics.DrawString("Suma pariata: " + p.Suma.ToString(), font, brush, x, y);
                graphics.DrawString(" Castigatorul: " + p.CastigatorSelectat, font, brush, x + 200, y);
                graphics.DrawString(" Cota: " + p.CotaCastigator.ToString(), font, brush, x + 500, y);
                y += 80;

            }
        }
        #endregion

        #region Alt Shortcuts
        private void lvMeciuri_KeyDown(object sender, KeyEventArgs e)
        {
            //print
            if (e.Control && e.KeyCode == Keys.P)
                printToolStripButton_Click(sender, e);
            //export txt
            if (e.Control && e.KeyCode == Keys.S)
                saveToolStripButton_Click(sender, e);
        }

        #endregion

        #region Serializare/Deserializare
        //Serializare XML
        private void SerializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pariu>));

            FileStream fs = File.Create("listaPariuri.xml");
            xmlSerializer.Serialize(fs, lista);

            fs.Close();

            MessageBox.Show("Serializare realizata cu succes in listaPariuri.xml");
        }

        //Deserializare XML
        private void DeserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Pariu>));

            try
            {
                FileStream fs = File.OpenRead("listaPariuri.xml");
                lista = xmlSerializer.Deserialize(fs) as List<Pariu>;

                fs.Close();
                populareListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #endregion

        #region Drag&Drop+Clipboard
        //ii spun utilizatorului formatul fisierului pt drag&drop
        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Formatul liniei din fisierul text:\nSuma,Sport,Data meci,Castigator,Cota castigator", "Informatii fisier", MessageBoxButtons.OK);
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            foreach (String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);
                foreach (String line in content)
                {
                    string[] tokens = line.Split(',');
                    Pariu p = new Pariu();
                     p.meci = new MeciSnooker();
                    float.TryParse(tokens[0], out float sum);
                    p.Suma = sum;
                    Enum.TryParse(tokens[1], out TipMeci tip);
                    p.meci.Sport = tip;
                    DateTime.TryParse(tokens[2], out DateTime dat);
                    p.meci.Data = dat;
                    p.CastigatorSelectat = tokens[3];
                    p.meci.Jucator1 = p.CastigatorSelectat;
                    float.TryParse(tokens[4], out float cota);
                    p.CotaCastigator = cota;
                    lista.Add(p);
                    populareListView();


                }
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        //cand apas Ctrl+C din tbJucator
        private void tbJucator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
                Clipboard.SetText(tbJucator.Text);
        }
        //il copiez in tbCastigator
        private void tbCastigator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V) {
                tbCastigator.Clear();
                tbCastigator.Text = Clipboard.GetText().Substring(0,tbJucator.Text.Length- tbJucator.Text.Length);
            }
        }
        #endregion

        //grafic 
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Grafic g = new Grafic(lista);
            g.ShowDialog();
        }

        #region Salvare lista in baza de date
        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriti sa salvati datele in baza de date?", "Salvare date", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (PariuriContext ctx = new PariuriContext())
                {
                    foreach (var p in lista)
                    { 
                                                 
                            ctx.Pariuri.Add(p);
                            ctx.Entry<Pariu>(p).State = System.Data.Entity.EntityState.Added;
                           
                                              

                    }
                    ctx.SaveChanges();
                    MessageBox.Show("Pariuri salvate cu succes", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
    }
}
