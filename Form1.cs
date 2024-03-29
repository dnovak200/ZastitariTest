namespace ZastitariTest
{
    public partial class Form1 : Form
    {

        FormPartneriDodaj formPartneriDodaj;
        FormPartneriPregled formPartneriPregled;

        FormProjektiDodaj formProjektiDodaj;
        FormProjektiPregled formProjektiPregled;
        FormProjektiAnaliza formProjektiAnaliza;
        FormProjektiRaspored formProjektiRaspored;

        FormOsobeDodaj formOsobeDodaj;
        FormOsobePregled formOsobePregled;


        public Form1()
        {
            InitializeComponent();
        }
        bool partnerExpand = false;


        private void partnerTransition_Tick(object sender, EventArgs e)
        {
            if (partnerExpand == false)
            {
                partneriContainer.Height += 8;
                if (partneriContainer.Height >= 176)
                {
                    partneriTransition.Stop();
                    partnerExpand = true;
                }
            }
            else
            {
                partneriContainer.Height -= 8;
                if (partneriContainer.Height <= 35)
                {
                    partneriTransition.Stop();
                    partnerExpand = false;
                }
            }
        }

        private void btnPartneri_Click(object sender, EventArgs e)
        {
            partneriTransition.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool projektiExpand = false;

        private void projektiTransition_Tick(object sender, EventArgs e)
        {

            if (projektiExpand == false)
            {
                projektiContainer.Height += 8;
                if (projektiContainer.Height >= 246)
                {
                    projektiTransition.Stop();
                    projektiExpand = true;
                }
            }
            else
            {
                projektiContainer.Height -= 8;
                if (projektiContainer.Height <= 35)
                {
                    projektiTransition.Stop();
                    projektiExpand = false;
                }
            }

        }

        private void btnProjekti_Click(object sender, EventArgs e)
        {
            projektiTransition.Start();
        }


        bool osobeExpand = false;

        private void osobeTransition_Tick(object sender, EventArgs e)
        {
            if (osobeExpand == false)
            {
                osobeContainer.Height += 8;
                if (osobeContainer.Height >= 176)
                {
                    osobeTransition.Stop();
                    osobeExpand = true;
                }
            }
            else
            {
                osobeContainer.Height -= 8;
                if (osobeContainer.Height <= 35)
                {
                    osobeTransition.Stop();
                    osobeExpand = false;
                }
            }

        }

        private void btnOsobe_Click(object sender, EventArgs e)
        {
            osobeTransition.Start();
        }

        bool sideBarExpand = true;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

            if (sideBarExpand == true)
            {
                sideBar.Width -= 8;
                if (sideBar.Width <= 51)
                {
                    sidebarTransition.Stop();
                    sideBarExpand = false;
                }
            }
            else
            {
                sideBar.Width += 8;
                if (sideBar.Width >= 180)
                {
                    sidebarTransition.Stop();
                    sideBarExpand = true;
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void btnOsobeDodaj_Click(object sender, EventArgs e)
        {
            if (formOsobeDodaj == null)
            {
                formOsobeDodaj = new FormOsobeDodaj();
                formOsobeDodaj.FormClosing += FormOsobeDodaj_FormClosing;
                formOsobeDodaj.MdiParent = this;
                formOsobeDodaj.Show();
                formOsobeDodaj.Dock = DockStyle.Fill;
            }
            else
            {
                formOsobeDodaj.Activate();
            }
        }

        private void FormOsobeDodaj_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formOsobeDodaj = null;
        }

        private void btnProjektiRaspored_Click(object sender, EventArgs e)
        {
            if (formProjektiRaspored == null)
            {
                formProjektiRaspored = new FormProjektiRaspored();
                formProjektiRaspored.FormClosing += FormProjektiRaspored_FormClosing;
                formProjektiRaspored.MdiParent = this;
                formProjektiRaspored.Show();
                formProjektiRaspored.Dock = DockStyle.Fill;
            }
            else
            {
                formProjektiRaspored.Activate();
            }
        }

        private void FormProjektiRaspored_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formProjektiRaspored = null;
        }

        private void btnPartneriDodaj_Click(object sender, EventArgs e)
        {
            if (formPartneriDodaj == null)
            {
                formPartneriDodaj = new FormPartneriDodaj();
                formPartneriDodaj.FormClosing += FormPartneriDodaj_FormClosing;
                formPartneriDodaj.MdiParent = this;
                formPartneriDodaj.Show();
                formPartneriDodaj.Dock = DockStyle.Fill;
            }
            else
            {
                formPartneriDodaj.Activate();
            }

        }

        private void FormPartneriDodaj_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formPartneriDodaj = null;
        }

        private void btnProjektiDodaj_Click(object sender, EventArgs e)
        {
            if (formProjektiDodaj == null)
            {
                formProjektiDodaj = new FormProjektiDodaj();
                formProjektiDodaj.FormClosing += FormProjektiDodaj_FormClosing;
                formProjektiDodaj.MdiParent = this;
                formProjektiDodaj.Show();
                formProjektiDodaj.Dock = DockStyle.Fill;
            }
            else
            {
                formProjektiDodaj.Activate();
            }
        }

        private void FormProjektiDodaj_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formProjektiDodaj = null;
        }

        private void btnOsobeRaspored_Click(object sender, EventArgs e)
        {
            if (formOsobePregled == null)
            {
                formOsobePregled = new FormOsobePregled();
                formOsobePregled.FormClosing += FormOsobePregled_FormClosing;
                formOsobePregled.MdiParent = this;
                formOsobePregled.Show();
                formOsobePregled.Dock = DockStyle.Fill;
            }
            else
            {
                formOsobePregled.Activate();
            }

        }

        private void FormOsobePregled_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formOsobePregled = null;
        }

        private void btnPartneriPregled_Click(object sender, EventArgs e)
        {
            if (formPartneriPregled == null)
            {
                formPartneriPregled = new FormPartneriPregled();
                formPartneriPregled.FormClosing += FormPartneriPregled_FormClosing;
                formPartneriPregled.MdiParent = this;
                formPartneriPregled.Show();
                formPartneriPregled.Dock = DockStyle.Fill;
            }
            else
            {
                formPartneriPregled.Activate();
            }

        }

        private void FormPartneriPregled_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formPartneriPregled = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formProjektiPregled == null)
            {
                formProjektiPregled = new FormProjektiPregled();
                formProjektiPregled.FormClosing += FormProjektiPregled_FormClosing;
                formProjektiPregled.MdiParent = this;
                formProjektiPregled.Show();
                formProjektiPregled.Dock = DockStyle.Fill;
            }
            else
            {
                formProjektiPregled.Activate();
            }

        }

        private void FormProjektiPregled_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formProjektiPregled = null;
        }

        private void btnProjektiAnaliza_Click(object sender, EventArgs e)
        {
            if (formProjektiAnaliza == null)
            {
                formProjektiAnaliza = new FormProjektiAnaliza();
                formProjektiAnaliza.FormClosing += FormProjektiAnaliza_FormClosing;
                formProjektiAnaliza.MdiParent = this;
                formProjektiAnaliza.Show();
                formProjektiAnaliza.Dock = DockStyle.Fill;
            }
            else
            {
                formProjektiAnaliza.Activate();
            }

        }

        private void FormProjektiAnaliza_FormClosing(object? sender, FormClosingEventArgs e)
        {
            formProjektiAnaliza = null;
        }
    }
}
