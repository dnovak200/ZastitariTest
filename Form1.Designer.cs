
namespace ZastitariTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPartneri = new Button();
            btnOsobe = new Button();
            btnPartneriImport = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnMenu = new PictureBox();
            sideBar = new FlowLayoutPanel();
            partneriContainer = new FlowLayoutPanel();
            btnPartneriDodaj = new Button();
            btnPartneriPregled = new Button();
            btnPartneriExport = new Button();
            projektiContainer = new FlowLayoutPanel();
            btnProjekti = new Button();
            btnProjektiDodaj = new Button();
            btnProjektiPregled = new Button();
            btnProjektiAnaliza = new Button();
            btnProjektiRaspored = new Button();
            btnProjektiExport = new Button();
            btnProjektiImport = new Button();
            osobeContainer = new FlowLayoutPanel();
            btnOsobeDodaj = new Button();
            btnOsobeRaspored = new Button();
            btnOsobeExport = new Button();
            btnOsobeImport = new Button();
            btnPostavke = new Button();
            btnInfo = new Button();
            btnIzlaz = new Button();
            partneriTransition = new System.Windows.Forms.Timer(components);
            projektiTransition = new System.Windows.Forms.Timer(components);
            osobeTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            sideBar.SuspendLayout();
            partneriContainer.SuspendLayout();
            projektiContainer.SuspendLayout();
            osobeContainer.SuspendLayout();
            SuspendLayout();
            // 
            // btnPartneri
            // 
            btnPartneri.BackColor = Color.FromArgb(142, 195, 176);
            btnPartneri.FlatAppearance.BorderSize = 0;
            btnPartneri.FlatStyle = FlatStyle.Flat;
            btnPartneri.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPartneri.ForeColor = Color.Black;
            btnPartneri.Image = (Image)resources.GetObject("btnPartneri.Image");
            btnPartneri.ImageAlign = ContentAlignment.MiddleLeft;
            btnPartneri.Location = new Point(0, 0);
            btnPartneri.Margin = new Padding(0);
            btnPartneri.Name = "btnPartneri";
            btnPartneri.Padding = new Padding(10, 0, 0, 0);
            btnPartneri.Size = new Size(180, 35);
            btnPartneri.TabIndex = 2;
            btnPartneri.Text = "           Partneri";
            btnPartneri.TextAlign = ContentAlignment.MiddleLeft;
            btnPartneri.UseVisualStyleBackColor = false;
            btnPartneri.Click += btnPartneri_Click;
            // 
            // btnOsobe
            // 
            btnOsobe.BackColor = Color.FromArgb(142, 195, 176);
            btnOsobe.FlatAppearance.BorderSize = 0;
            btnOsobe.FlatStyle = FlatStyle.Flat;
            btnOsobe.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOsobe.ForeColor = Color.Black;
            btnOsobe.Image = (Image)resources.GetObject("btnOsobe.Image");
            btnOsobe.ImageAlign = ContentAlignment.MiddleLeft;
            btnOsobe.Location = new Point(0, 0);
            btnOsobe.Margin = new Padding(0);
            btnOsobe.Name = "btnOsobe";
            btnOsobe.Padding = new Padding(10, 0, 0, 0);
            btnOsobe.Size = new Size(180, 35);
            btnOsobe.TabIndex = 6;
            btnOsobe.Text = "           Djelatnici";
            btnOsobe.TextAlign = ContentAlignment.MiddleLeft;
            btnOsobe.UseVisualStyleBackColor = false;
            btnOsobe.Click += btnOsobe_Click;
            // 
            // btnPartneriImport
            // 
            btnPartneriImport.BackColor = Color.FromArgb(188, 234, 213);
            btnPartneriImport.FlatAppearance.BorderSize = 0;
            btnPartneriImport.FlatStyle = FlatStyle.Flat;
            btnPartneriImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPartneriImport.ForeColor = Color.Black;
            btnPartneriImport.Image = (Image)resources.GetObject("btnPartneriImport.Image");
            btnPartneriImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnPartneriImport.Location = new Point(0, 140);
            btnPartneriImport.Margin = new Padding(0);
            btnPartneriImport.Name = "btnPartneriImport";
            btnPartneriImport.Padding = new Padding(10, 0, 0, 0);
            btnPartneriImport.Size = new Size(180, 35);
            btnPartneriImport.TabIndex = 22;
            btnPartneriImport.Text = "            Import";
            btnPartneriImport.TextAlign = ContentAlignment.MiddleLeft;
            btnPartneriImport.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(142, 195, 176);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 39);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 21;
            label1.Text = "InTouch Soft Design";
            // 
            // btnMenu
            // 
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.InitialImage = null;
            btnMenu.Location = new Point(3, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(34, 32);
            btnMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMenu.TabIndex = 20;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(142, 195, 176);
            sideBar.Controls.Add(partneriContainer);
            sideBar.Controls.Add(projektiContainer);
            sideBar.Controls.Add(osobeContainer);
            sideBar.Controls.Add(btnPostavke);
            sideBar.Controls.Add(btnInfo);
            sideBar.Controls.Add(btnIzlaz);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 39);
            sideBar.Margin = new Padding(0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(180, 564);
            sideBar.TabIndex = 20;
            // 
            // partneriContainer
            // 
            partneriContainer.BackColor = Color.FromArgb(142, 195, 176);
            partneriContainer.Controls.Add(btnPartneri);
            partneriContainer.Controls.Add(btnPartneriDodaj);
            partneriContainer.Controls.Add(btnPartneriPregled);
            partneriContainer.Controls.Add(btnPartneriExport);
            partneriContainer.Controls.Add(btnPartneriImport);
            partneriContainer.Location = new Point(0, 0);
            partneriContainer.Margin = new Padding(0);
            partneriContainer.Name = "partneriContainer";
            partneriContainer.Size = new Size(180, 35);
            partneriContainer.TabIndex = 21;
            // 
            // btnPartneriDodaj
            // 
            btnPartneriDodaj.BackColor = Color.FromArgb(188, 234, 213);
            btnPartneriDodaj.FlatAppearance.BorderSize = 0;
            btnPartneriDodaj.FlatStyle = FlatStyle.Flat;
            btnPartneriDodaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPartneriDodaj.ForeColor = Color.Black;
            btnPartneriDodaj.Image = (Image)resources.GetObject("btnPartneriDodaj.Image");
            btnPartneriDodaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnPartneriDodaj.Location = new Point(0, 35);
            btnPartneriDodaj.Margin = new Padding(0);
            btnPartneriDodaj.Name = "btnPartneriDodaj";
            btnPartneriDodaj.Padding = new Padding(10, 0, 0, 0);
            btnPartneriDodaj.Size = new Size(180, 35);
            btnPartneriDodaj.TabIndex = 2;
            btnPartneriDodaj.Text = "            Dodaj novi";
            btnPartneriDodaj.TextAlign = ContentAlignment.MiddleLeft;
            btnPartneriDodaj.UseVisualStyleBackColor = false;
            btnPartneriDodaj.Click += btnPartneriDodaj_Click;
            // 
            // btnPartneriPregled
            // 
            btnPartneriPregled.BackColor = Color.FromArgb(188, 234, 213);
            btnPartneriPregled.FlatAppearance.BorderSize = 0;
            btnPartneriPregled.FlatStyle = FlatStyle.Flat;
            btnPartneriPregled.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPartneriPregled.ForeColor = Color.Black;
            btnPartneriPregled.Image = (Image)resources.GetObject("btnPartneriPregled.Image");
            btnPartneriPregled.ImageAlign = ContentAlignment.MiddleLeft;
            btnPartneriPregled.Location = new Point(0, 70);
            btnPartneriPregled.Margin = new Padding(0);
            btnPartneriPregled.Name = "btnPartneriPregled";
            btnPartneriPregled.Padding = new Padding(10, 0, 0, 0);
            btnPartneriPregled.Size = new Size(180, 35);
            btnPartneriPregled.TabIndex = 2;
            btnPartneriPregled.Text = "            Pregled";
            btnPartneriPregled.TextAlign = ContentAlignment.MiddleLeft;
            btnPartneriPregled.UseVisualStyleBackColor = false;
            btnPartneriPregled.Click += btnPartneriPregled_Click;
            // 
            // btnPartneriExport
            // 
            btnPartneriExport.BackColor = Color.FromArgb(188, 234, 213);
            btnPartneriExport.FlatAppearance.BorderSize = 0;
            btnPartneriExport.FlatStyle = FlatStyle.Flat;
            btnPartneriExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPartneriExport.ForeColor = Color.Black;
            btnPartneriExport.Image = (Image)resources.GetObject("btnPartneriExport.Image");
            btnPartneriExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnPartneriExport.Location = new Point(0, 105);
            btnPartneriExport.Margin = new Padding(0);
            btnPartneriExport.Name = "btnPartneriExport";
            btnPartneriExport.Padding = new Padding(10, 0, 0, 0);
            btnPartneriExport.Size = new Size(180, 35);
            btnPartneriExport.TabIndex = 2;
            btnPartneriExport.Text = "            Export";
            btnPartneriExport.TextAlign = ContentAlignment.MiddleLeft;
            btnPartneriExport.UseVisualStyleBackColor = false;
            // 
            // projektiContainer
            // 
            projektiContainer.BackColor = Color.FromArgb(142, 195, 176);
            projektiContainer.Controls.Add(btnProjekti);
            projektiContainer.Controls.Add(btnProjektiDodaj);
            projektiContainer.Controls.Add(btnProjektiPregled);
            projektiContainer.Controls.Add(btnProjektiAnaliza);
            projektiContainer.Controls.Add(btnProjektiRaspored);
            projektiContainer.Controls.Add(btnProjektiExport);
            projektiContainer.Controls.Add(btnProjektiImport);
            projektiContainer.Location = new Point(0, 35);
            projektiContainer.Margin = new Padding(0);
            projektiContainer.Name = "projektiContainer";
            projektiContainer.Size = new Size(180, 35);
            projektiContainer.TabIndex = 23;
            // 
            // btnProjekti
            // 
            btnProjekti.BackColor = Color.FromArgb(142, 195, 176);
            btnProjekti.FlatAppearance.BorderSize = 0;
            btnProjekti.FlatStyle = FlatStyle.Flat;
            btnProjekti.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjekti.ForeColor = Color.Black;
            btnProjekti.Image = (Image)resources.GetObject("btnProjekti.Image");
            btnProjekti.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjekti.Location = new Point(0, 0);
            btnProjekti.Margin = new Padding(0);
            btnProjekti.Name = "btnProjekti";
            btnProjekti.Padding = new Padding(10, 0, 0, 0);
            btnProjekti.Size = new Size(180, 35);
            btnProjekti.TabIndex = 6;
            btnProjekti.Text = "           Projekti";
            btnProjekti.TextAlign = ContentAlignment.MiddleLeft;
            btnProjekti.UseVisualStyleBackColor = false;
            btnProjekti.Click += btnProjekti_Click;
            // 
            // btnProjektiDodaj
            // 
            btnProjektiDodaj.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiDodaj.FlatAppearance.BorderSize = 0;
            btnProjektiDodaj.FlatStyle = FlatStyle.Flat;
            btnProjektiDodaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiDodaj.ForeColor = Color.Black;
            btnProjektiDodaj.Image = (Image)resources.GetObject("btnProjektiDodaj.Image");
            btnProjektiDodaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiDodaj.Location = new Point(0, 35);
            btnProjektiDodaj.Margin = new Padding(0);
            btnProjektiDodaj.Name = "btnProjektiDodaj";
            btnProjektiDodaj.Padding = new Padding(10, 0, 0, 0);
            btnProjektiDodaj.Size = new Size(180, 35);
            btnProjektiDodaj.TabIndex = 2;
            btnProjektiDodaj.Text = "            Dodaj novi";
            btnProjektiDodaj.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiDodaj.UseVisualStyleBackColor = false;
            btnProjektiDodaj.Click += btnProjektiDodaj_Click;
            // 
            // btnProjektiPregled
            // 
            btnProjektiPregled.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiPregled.FlatAppearance.BorderSize = 0;
            btnProjektiPregled.FlatStyle = FlatStyle.Flat;
            btnProjektiPregled.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiPregled.ForeColor = Color.Black;
            btnProjektiPregled.Image = (Image)resources.GetObject("btnProjektiPregled.Image");
            btnProjektiPregled.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiPregled.Location = new Point(0, 70);
            btnProjektiPregled.Margin = new Padding(0);
            btnProjektiPregled.Name = "btnProjektiPregled";
            btnProjektiPregled.Padding = new Padding(10, 0, 0, 0);
            btnProjektiPregled.Size = new Size(180, 35);
            btnProjektiPregled.TabIndex = 22;
            btnProjektiPregled.Text = "            Pregled";
            btnProjektiPregled.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiPregled.UseVisualStyleBackColor = false;
            btnProjektiPregled.Click += button1_Click;
            // 
            // btnProjektiAnaliza
            // 
            btnProjektiAnaliza.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiAnaliza.FlatAppearance.BorderSize = 0;
            btnProjektiAnaliza.FlatStyle = FlatStyle.Flat;
            btnProjektiAnaliza.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiAnaliza.ForeColor = Color.Black;
            btnProjektiAnaliza.Image = (Image)resources.GetObject("btnProjektiAnaliza.Image");
            btnProjektiAnaliza.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiAnaliza.Location = new Point(0, 105);
            btnProjektiAnaliza.Margin = new Padding(0);
            btnProjektiAnaliza.Name = "btnProjektiAnaliza";
            btnProjektiAnaliza.Padding = new Padding(10, 0, 0, 0);
            btnProjektiAnaliza.Size = new Size(180, 35);
            btnProjektiAnaliza.TabIndex = 23;
            btnProjektiAnaliza.Text = "            Analiza";
            btnProjektiAnaliza.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiAnaliza.UseVisualStyleBackColor = false;
            btnProjektiAnaliza.Click += btnProjektiAnaliza_Click;
            // 
            // btnProjektiRaspored
            // 
            btnProjektiRaspored.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiRaspored.FlatAppearance.BorderSize = 0;
            btnProjektiRaspored.FlatStyle = FlatStyle.Flat;
            btnProjektiRaspored.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiRaspored.ForeColor = Color.Black;
            btnProjektiRaspored.Image = (Image)resources.GetObject("btnProjektiRaspored.Image");
            btnProjektiRaspored.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiRaspored.Location = new Point(0, 140);
            btnProjektiRaspored.Margin = new Padding(0);
            btnProjektiRaspored.Name = "btnProjektiRaspored";
            btnProjektiRaspored.Padding = new Padding(10, 0, 0, 0);
            btnProjektiRaspored.Size = new Size(180, 35);
            btnProjektiRaspored.TabIndex = 2;
            btnProjektiRaspored.Text = "            Raspored";
            btnProjektiRaspored.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiRaspored.UseVisualStyleBackColor = false;
            btnProjektiRaspored.Click += btnProjektiRaspored_Click;
            // 
            // btnProjektiExport
            // 
            btnProjektiExport.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiExport.FlatAppearance.BorderSize = 0;
            btnProjektiExport.FlatStyle = FlatStyle.Flat;
            btnProjektiExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiExport.ForeColor = Color.Black;
            btnProjektiExport.Image = (Image)resources.GetObject("btnProjektiExport.Image");
            btnProjektiExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiExport.Location = new Point(0, 175);
            btnProjektiExport.Margin = new Padding(0);
            btnProjektiExport.Name = "btnProjektiExport";
            btnProjektiExport.Padding = new Padding(10, 0, 0, 0);
            btnProjektiExport.Size = new Size(180, 35);
            btnProjektiExport.TabIndex = 2;
            btnProjektiExport.Text = "            Export";
            btnProjektiExport.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiExport.UseVisualStyleBackColor = false;
            // 
            // btnProjektiImport
            // 
            btnProjektiImport.BackColor = Color.FromArgb(188, 234, 213);
            btnProjektiImport.FlatAppearance.BorderSize = 0;
            btnProjektiImport.FlatStyle = FlatStyle.Flat;
            btnProjektiImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProjektiImport.ForeColor = Color.Black;
            btnProjektiImport.Image = (Image)resources.GetObject("btnProjektiImport.Image");
            btnProjektiImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjektiImport.Location = new Point(0, 210);
            btnProjektiImport.Margin = new Padding(0);
            btnProjektiImport.Name = "btnProjektiImport";
            btnProjektiImport.Padding = new Padding(10, 0, 0, 0);
            btnProjektiImport.Size = new Size(180, 35);
            btnProjektiImport.TabIndex = 22;
            btnProjektiImport.Text = "            Import";
            btnProjektiImport.TextAlign = ContentAlignment.MiddleLeft;
            btnProjektiImport.UseVisualStyleBackColor = false;
            // 
            // osobeContainer
            // 
            osobeContainer.BackColor = Color.FromArgb(142, 195, 176);
            osobeContainer.Controls.Add(btnOsobe);
            osobeContainer.Controls.Add(btnOsobeDodaj);
            osobeContainer.Controls.Add(btnOsobeRaspored);
            osobeContainer.Controls.Add(btnOsobeExport);
            osobeContainer.Controls.Add(btnOsobeImport);
            osobeContainer.Location = new Point(0, 70);
            osobeContainer.Margin = new Padding(0);
            osobeContainer.Name = "osobeContainer";
            osobeContainer.Size = new Size(180, 35);
            osobeContainer.TabIndex = 24;
            // 
            // btnOsobeDodaj
            // 
            btnOsobeDodaj.BackColor = Color.FromArgb(188, 234, 213);
            btnOsobeDodaj.FlatAppearance.BorderSize = 0;
            btnOsobeDodaj.FlatStyle = FlatStyle.Flat;
            btnOsobeDodaj.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOsobeDodaj.ForeColor = Color.Black;
            btnOsobeDodaj.Image = (Image)resources.GetObject("btnOsobeDodaj.Image");
            btnOsobeDodaj.ImageAlign = ContentAlignment.MiddleLeft;
            btnOsobeDodaj.Location = new Point(0, 35);
            btnOsobeDodaj.Margin = new Padding(0);
            btnOsobeDodaj.Name = "btnOsobeDodaj";
            btnOsobeDodaj.Padding = new Padding(10, 0, 0, 0);
            btnOsobeDodaj.Size = new Size(180, 35);
            btnOsobeDodaj.TabIndex = 2;
            btnOsobeDodaj.Text = "            Dodaj novi";
            btnOsobeDodaj.TextAlign = ContentAlignment.MiddleLeft;
            btnOsobeDodaj.UseVisualStyleBackColor = false;
            btnOsobeDodaj.Click += btnOsobeDodaj_Click;
            // 
            // btnOsobeRaspored
            // 
            btnOsobeRaspored.BackColor = Color.FromArgb(188, 234, 213);
            btnOsobeRaspored.FlatAppearance.BorderSize = 0;
            btnOsobeRaspored.FlatStyle = FlatStyle.Flat;
            btnOsobeRaspored.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOsobeRaspored.ForeColor = Color.Black;
            btnOsobeRaspored.Image = (Image)resources.GetObject("btnOsobeRaspored.Image");
            btnOsobeRaspored.ImageAlign = ContentAlignment.MiddleLeft;
            btnOsobeRaspored.Location = new Point(0, 70);
            btnOsobeRaspored.Margin = new Padding(0);
            btnOsobeRaspored.Name = "btnOsobeRaspored";
            btnOsobeRaspored.Padding = new Padding(10, 0, 0, 0);
            btnOsobeRaspored.Size = new Size(180, 35);
            btnOsobeRaspored.TabIndex = 2;
            btnOsobeRaspored.Text = "            Pregled";
            btnOsobeRaspored.TextAlign = ContentAlignment.MiddleLeft;
            btnOsobeRaspored.UseVisualStyleBackColor = false;
            btnOsobeRaspored.Click += btnOsobeRaspored_Click;
            // 
            // btnOsobeExport
            // 
            btnOsobeExport.BackColor = Color.FromArgb(188, 234, 213);
            btnOsobeExport.FlatAppearance.BorderSize = 0;
            btnOsobeExport.FlatStyle = FlatStyle.Flat;
            btnOsobeExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOsobeExport.ForeColor = Color.Black;
            btnOsobeExport.Image = (Image)resources.GetObject("btnOsobeExport.Image");
            btnOsobeExport.ImageAlign = ContentAlignment.MiddleLeft;
            btnOsobeExport.Location = new Point(0, 105);
            btnOsobeExport.Margin = new Padding(0);
            btnOsobeExport.Name = "btnOsobeExport";
            btnOsobeExport.Padding = new Padding(10, 0, 0, 0);
            btnOsobeExport.Size = new Size(180, 35);
            btnOsobeExport.TabIndex = 2;
            btnOsobeExport.Text = "            Export";
            btnOsobeExport.TextAlign = ContentAlignment.MiddleLeft;
            btnOsobeExport.UseVisualStyleBackColor = false;
            // 
            // btnOsobeImport
            // 
            btnOsobeImport.BackColor = Color.FromArgb(188, 234, 213);
            btnOsobeImport.FlatAppearance.BorderSize = 0;
            btnOsobeImport.FlatStyle = FlatStyle.Flat;
            btnOsobeImport.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOsobeImport.ForeColor = Color.Black;
            btnOsobeImport.Image = (Image)resources.GetObject("btnOsobeImport.Image");
            btnOsobeImport.ImageAlign = ContentAlignment.MiddleLeft;
            btnOsobeImport.Location = new Point(0, 140);
            btnOsobeImport.Margin = new Padding(0);
            btnOsobeImport.Name = "btnOsobeImport";
            btnOsobeImport.Padding = new Padding(10, 0, 0, 0);
            btnOsobeImport.Size = new Size(180, 35);
            btnOsobeImport.TabIndex = 22;
            btnOsobeImport.Text = "            Import";
            btnOsobeImport.TextAlign = ContentAlignment.MiddleLeft;
            btnOsobeImport.UseVisualStyleBackColor = false;
            // 
            // btnPostavke
            // 
            btnPostavke.BackColor = Color.FromArgb(142, 195, 176);
            btnPostavke.FlatAppearance.BorderSize = 0;
            btnPostavke.FlatStyle = FlatStyle.Flat;
            btnPostavke.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPostavke.ForeColor = Color.Black;
            btnPostavke.Image = (Image)resources.GetObject("btnPostavke.Image");
            btnPostavke.ImageAlign = ContentAlignment.MiddleLeft;
            btnPostavke.Location = new Point(0, 105);
            btnPostavke.Margin = new Padding(0);
            btnPostavke.Name = "btnPostavke";
            btnPostavke.Padding = new Padding(10, 0, 0, 0);
            btnPostavke.Size = new Size(180, 35);
            btnPostavke.TabIndex = 24;
            btnPostavke.Text = "           Postavke";
            btnPostavke.TextAlign = ContentAlignment.MiddleLeft;
            btnPostavke.UseVisualStyleBackColor = false;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(142, 195, 176);
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInfo.ForeColor = Color.Black;
            btnInfo.Image = (Image)resources.GetObject("btnInfo.Image");
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(0, 140);
            btnInfo.Margin = new Padding(0);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(10, 0, 0, 0);
            btnInfo.Size = new Size(180, 35);
            btnInfo.TabIndex = 6;
            btnInfo.Text = "           Info";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = false;
            // 
            // btnIzlaz
            // 
            btnIzlaz.BackColor = Color.FromArgb(142, 195, 176);
            btnIzlaz.FlatAppearance.BorderSize = 0;
            btnIzlaz.FlatStyle = FlatStyle.Flat;
            btnIzlaz.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnIzlaz.ForeColor = Color.Black;
            btnIzlaz.Image = (Image)resources.GetObject("btnIzlaz.Image");
            btnIzlaz.ImageAlign = ContentAlignment.MiddleLeft;
            btnIzlaz.Location = new Point(0, 175);
            btnIzlaz.Margin = new Padding(0);
            btnIzlaz.Name = "btnIzlaz";
            btnIzlaz.Padding = new Padding(10, 0, 0, 0);
            btnIzlaz.Size = new Size(180, 35);
            btnIzlaz.TabIndex = 24;
            btnIzlaz.Text = "           Izlaz";
            btnIzlaz.TextAlign = ContentAlignment.MiddleLeft;
            btnIzlaz.UseVisualStyleBackColor = false;
            // 
            // partneriTransition
            // 
            partneriTransition.Interval = 5;
            partneriTransition.Tick += partnerTransition_Tick;
            // 
            // projektiTransition
            // 
            projektiTransition.Interval = 5;
            projektiTransition.Tick += projektiTransition_Tick;
            // 
            // osobeTransition
            // 
            osobeTransition.Interval = 5;
            osobeTransition.Tick += osobeTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 5;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 603);
            Controls.Add(sideBar);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            sideBar.ResumeLayout(false);
            partneriContainer.ResumeLayout(false);
            projektiContainer.ResumeLayout(false);
            osobeContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnPartneri;
        private Button btnPartneriImport;
        private Button btnOsobe;
        private Panel panel1;
        private PictureBox btnMenu;
        private Label label1;
        private FlowLayoutPanel sideBar;
        private FlowLayoutPanel partneriContainer;
        private Button btnPartneriDodaj;
        private Button btnPartneriPregled;
        private Button btnPartneriExport;
        private Button btnProjekti;
        private FlowLayoutPanel projektiContainer;
        private Button btnProjektiDodaj;
        private Button btnProjektiRaspored;
        private Button btnProjektiExport;
        private Button btnProjektiImport;
        private FlowLayoutPanel osobeContainer;
        private Button btnOsobeDodaj;
        private Button btnOsobeRaspored;
        private Button btnOsobeExport;
        private Button btnOsobeImport;
        private Button btnInfo;
        private System.Windows.Forms.Timer partneriTransition;
        private Button btnPostavke;
        private Button btnIzlaz;
        private System.Windows.Forms.Timer projektiTransition;
        private System.Windows.Forms.Timer osobeTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button btnProjektiPregled;
        private Button btnProjektiAnaliza;
    }
}
