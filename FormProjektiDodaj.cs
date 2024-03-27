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
    public partial class FormProjektiDodaj : Form
    {
        SmjeneNaProjektu smjeneNaProjektu;
        FormDjelatniciNaProjektu formDjelatniciNaProjektu;



        public FormProjektiDodaj()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (smjeneNaProjektu == null)
            {
                smjeneNaProjektu = new SmjeneNaProjektu();
                smjeneNaProjektu.FormClosing += SmjeneNaProjektu_FormClosing;
                //   smjeneNaProjektu.MdiParent = this;
                smjeneNaProjektu.Show();
                smjeneNaProjektu.Dock = DockStyle.Fill;
            }
            else
            {
                smjeneNaProjektu.Activate();
            }
        }

        private void SmjeneNaProjektu_FormClosing(object? sender, FormClosingEventArgs e)
        {
            smjeneNaProjektu = null;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (formDjelatniciNaProjektu == null)
            {
                formDjelatniciNaProjektu = new FormDjelatniciNaProjektu();
                formDjelatniciNaProjektu.FormClosing += FormDjelatniciNaProjektu_FormClosing;
                //   formDjelatniciNaProjektu.MdiParent = this;
                formDjelatniciNaProjektu.Show();
                formDjelatniciNaProjektu.Dock = DockStyle.Fill;
            }
            else
            {
                formDjelatniciNaProjektu.Activate();
            }

        }
        private void FormDjelatniciNaProjektu_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formDjelatniciNaProjektu = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
