namespace ZastitariTest
{
    public partial class Form1 : Form
    {
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
                if (projektiContainer.Height >= 176)
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
    }
}
