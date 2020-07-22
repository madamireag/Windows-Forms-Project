using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema1.Models;

namespace Tema1
{
    public partial class EditarePariuri : Form
    {
        Pariu _instance;
        public EditarePariuri(Pariu pariu)
        {
          
            InitializeComponent();
            _instance = pariu;

        }

       
        private void EditarePariuri_Load(object sender, EventArgs e)
        {
            tbSuma.Text = _instance.Suma.ToString();
            cbTip.Text = _instance.meci.Sport.ToString();
            dtpMeci.Value = _instance.meci.Data;
            tbJucator.Text = _instance.meci.Jucator1;
            tbOponent.Text = _instance.meci.Jucator2;
            tbCastigator.Text = _instance.CastigatorSelectat;
            tbCotaCastig.Text = _instance.CotaCastigator.ToString();
         }
        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            float.TryParse(tbSuma.Text, out float sum);
            _instance.Suma = sum;
            Enum.TryParse(cbTip.Text, out TipMeci tip);
            _instance.meci.Sport = tip;
            _instance.meci.Data = dtpMeci.Value;
            _instance.CastigatorSelectat = tbCastigator.Text;
            _instance.meci.Jucator1 = tbJucator.Text;
            _instance.meci.Jucator2 = tbOponent.Text;
            float.TryParse(tbCotaCastig.Text, out float cota);
            _instance.CotaCastigator = cota;

            this.Close();
        }
    }
}
