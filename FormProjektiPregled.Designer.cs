namespace ZastitariTest
{
    partial class FormProjektiPregled
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            btnPrihvati = new Button();
            comboBoxPartneri = new ComboBox();
            lblPartneriNaziv = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnPrihvati);
            panel1.Controls.Add(comboBoxPartneri);
            panel1.Controls.Add(lblPartneriNaziv);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 94);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(142, 195, 176);
            button1.Location = new Point(889, 53);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 35;
            button1.Text = "Izlaz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 31);
            label1.TabIndex = 34;
            label1.Text = "Pregled projekata po partneru";
            // 
            // btnPrihvati
            // 
            btnPrihvati.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrihvati.BackColor = Color.FromArgb(142, 195, 176);
            btnPrihvati.Location = new Point(772, 53);
            btnPrihvati.Name = "btnPrihvati";
            btnPrihvati.Size = new Size(94, 33);
            btnPrihvati.TabIndex = 33;
            btnPrihvati.Text = "Prihvati";
            btnPrihvati.UseVisualStyleBackColor = false;
            // 
            // comboBoxPartneri
            // 
            comboBoxPartneri.FormattingEnabled = true;
            comboBoxPartneri.Items.AddRange(new object[] { "Partner 1.", "Partner 2.", "Partner 3.", "Partner 4." });
            comboBoxPartneri.Location = new Point(91, 56);
            comboBoxPartneri.Name = "comboBoxPartneri";
            comboBoxPartneri.Size = new Size(278, 28);
            comboBoxPartneri.TabIndex = 30;
            // 
            // lblPartneriNaziv
            // 
            lblPartneriNaziv.AutoSize = true;
            lblPartneriNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPartneriNaziv.ForeColor = Color.Black;
            lblPartneriNaziv.Location = new Point(12, 60);
            lblPartneriNaziv.Name = "lblPartneriNaziv";
            lblPartneriNaziv.Size = new Size(59, 20);
            lblPartneriNaziv.TabIndex = 29;
            lblPartneriNaziv.Text = "Partner:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 235, 228);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(995, 390);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(12, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(977, 324);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Šifra";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 95;
            // 
            // Column2
            // 
            Column2.HeaderText = "Naziv projekta";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.HeaderText = "Adresa";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Grad";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Ukupno djelatnika na projektu";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 235, 228);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 430);
            panel3.Name = "panel3";
            panel3.Size = new Size(995, 54);
            panel3.TabIndex = 2;
            // 
            // FormProjektiPregled
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 484);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProjektiPregled";
            Text = "FormProjektiPregled";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxPartneri;
        private Label lblPartneriNaziv;
        private Button btnPrihvati;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel3;
        private Label label1;
        private Button button1;
    }
}