using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitariTest
{
    public partial class FormOsobeDodaj : Form
    {
        private string sifra;
        public FormOsobeDodaj(string sifra = "")
        {
            InitializeComponent();
            this.sifra = sifra;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOsobeDodaj_Load(object sender, EventArgs e)
        {
            txtSifra.Text = sifra;
        }
    }
}
