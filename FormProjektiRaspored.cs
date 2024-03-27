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
    public partial class FormProjektiRaspored : Form
    {
        FormProjektiKopirajRaspored formProjektiKopirajRaspored;


        public FormProjektiRaspored()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (formProjektiKopirajRaspored == null)
            {
                formProjektiKopirajRaspored = new FormProjektiKopirajRaspored();
                formProjektiKopirajRaspored.FormClosing += FormProjektiKopirajRaspored_FormClosing;
                //   formProjektiKopirajRaspored.MdiParent = this;
                formProjektiKopirajRaspored.Show();
                formProjektiKopirajRaspored.Dock = DockStyle.Fill;
            }
            else
            {
                formProjektiKopirajRaspored.Activate();
            }
        }

        private void FormProjektiKopirajRaspored_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formProjektiKopirajRaspored = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

