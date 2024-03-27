namespace ZastitariTest
{
    partial class FormProjektiRaspored
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            label1 = new Label();
            comboBoxProjekti = new ComboBox();
            lblProjektiNaziv = new Label();
            btnPrihvati = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            comboBoxPartneri = new ComboBox();
            lblPartneriNaziv = new Label();
            btnUpisi = new Button();
            pnlFooter = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            button2 = new Button();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(217, 235, 228);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(comboBoxProjekti);
            pnlHeader.Controls.Add(lblProjektiNaziv);
            pnlHeader.Controls.Add(btnPrihvati);
            pnlHeader.Controls.Add(dateTimePicker1);
            pnlHeader.Controls.Add(lblDatum);
            pnlHeader.Controls.Add(comboBoxPartneri);
            pnlHeader.Controls.Add(lblPartneriNaziv);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1115, 134);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(519, 31);
            label1.TabIndex = 29;
            label1.Text = "Raspored djelatnika po projektima i smjenama";
            // 
            // comboBoxProjekti
            // 
            comboBoxProjekti.FormattingEnabled = true;
            comboBoxProjekti.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBoxProjekti.Location = new Point(90, 86);
            comboBoxProjekti.Name = "comboBoxProjekti";
            comboBoxProjekti.Size = new Size(278, 28);
            comboBoxProjekti.TabIndex = 28;
            // 
            // lblProjektiNaziv
            // 
            lblProjektiNaziv.AutoSize = true;
            lblProjektiNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProjektiNaziv.ForeColor = Color.Black;
            lblProjektiNaziv.Location = new Point(11, 90);
            lblProjektiNaziv.Name = "lblProjektiNaziv";
            lblProjektiNaziv.Size = new Size(57, 20);
            lblProjektiNaziv.TabIndex = 27;
            lblProjektiNaziv.Text = "Projekt:";
            // 
            // btnPrihvati
            // 
            btnPrihvati.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrihvati.BackColor = Color.FromArgb(142, 195, 176);
            btnPrihvati.Location = new Point(975, 13);
            btnPrihvati.Name = "btnPrihvati";
            btnPrihvati.Size = new Size(94, 33);
            btnPrihvati.TabIndex = 26;
            btnPrihvati.Text = "Prihvati";
            btnPrihvati.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(570, 51);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDatum.ForeColor = Color.Black;
            lblDatum.Location = new Point(416, 56);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(136, 20);
            lblDatum.TabIndex = 3;
            lblDatum.Text = "Raspored za datum:";
            // 
            // comboBoxPartneri
            // 
            comboBoxPartneri.FormattingEnabled = true;
            comboBoxPartneri.Items.AddRange(new object[] { "Partner 1.", "Partner 2.", "Partner 3.", "Partner 4." });
            comboBoxPartneri.Location = new Point(90, 52);
            comboBoxPartneri.Name = "comboBoxPartneri";
            comboBoxPartneri.Size = new Size(278, 28);
            comboBoxPartneri.TabIndex = 2;
            // 
            // lblPartneriNaziv
            // 
            lblPartneriNaziv.AutoSize = true;
            lblPartneriNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPartneriNaziv.ForeColor = Color.Black;
            lblPartneriNaziv.Location = new Point(11, 56);
            lblPartneriNaziv.Name = "lblPartneriNaziv";
            lblPartneriNaziv.Size = new Size(59, 20);
            lblPartneriNaziv.TabIndex = 0;
            lblPartneriNaziv.Text = "Partner:";
            // 
            // btnUpisi
            // 
            btnUpisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpisi.BackColor = Color.FromArgb(142, 195, 176);
            btnUpisi.Location = new Point(901, 9);
            btnUpisi.Name = "btnUpisi";
            btnUpisi.Size = new Size(94, 33);
            btnUpisi.TabIndex = 27;
            btnUpisi.Text = "Upiši";
            btnUpisi.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(217, 235, 228);
            pnlFooter.Controls.Add(button2);
            pnlFooter.Controls.Add(button1);
            pnlFooter.Controls.Add(btnUpisi);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 493);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1115, 54);
            pnlFooter.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(142, 195, 176);
            button1.Location = new Point(801, 9);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 28;
            button1.Text = "Kopiraj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewComboBoxColumn1, dataGridViewComboBoxColumn2, dataGridViewTextBoxColumn3, Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1115, 359);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn1.HeaderText = "Šifra Osobe";
            dataGridViewTextBoxColumn1.MinimumWidth = 90;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewComboBoxColumn1.HeaderText = "Djelatnik";
            dataGridViewComboBoxColumn1.Items.AddRange(new object[] { "Djelatnik 1.", "Djelatnik 2.", "Djelatnik 3.", "Djelatnik 4", "Djelatnik 5.", "Djelatnik 6." });
            dataGridViewComboBoxColumn1.MinimumWidth = 250;
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewComboBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewComboBoxColumn2.HeaderText = "Smjena";
            dataGridViewComboBoxColumn2.Items.AddRange(new object[] { "1. smjena", "2. smjena", "3. smjena" });
            dataGridViewComboBoxColumn2.MinimumWidth = 90;
            dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            dataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn3.HeaderText = "Napomena";
            dataGridViewTextBoxColumn3.MinimumWidth = 80;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Column1
            // 
            Column1.HeaderText = "Trošak";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Prihod";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "RUC";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Odrađeno";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(142, 195, 176);
            button2.Location = new Point(1001, 9);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 29;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormProjektiRaspored
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 547);
            Controls.Add(dataGridView1);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProjektiRaspored";
            Text = "FormProjektiRaspored";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblPartneriNaziv;
        private Label lblDatum;
        private ComboBox comboBoxPartneri;
        private DateTimePicker dateTimePicker1;
        private Button btnPrihvati;
        private Button btnUpisi;
        private Panel pnlFooter;
        private ComboBox comboBoxProjekti;
        private Label lblProjektiNaziv;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
    }
}