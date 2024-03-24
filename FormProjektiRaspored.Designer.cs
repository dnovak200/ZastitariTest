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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            comboBoxProjekti = new ComboBox();
            lblProjektiNaziv = new Label();
            btnPrihvati = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            comboBoxPartneri = new ComboBox();
            lblPartneriNaziv = new Label();
            btnUpisi = new Button();
            pnlFooter = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            pnlHeader.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(217, 235, 228);
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
            pnlHeader.Size = new Size(1115, 93);
            pnlHeader.TabIndex = 0;
            // 
            // comboBoxProjekti
            // 
            comboBoxProjekti.FormattingEnabled = true;
            comboBoxProjekti.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBoxProjekti.Location = new Point(90, 47);
            comboBoxProjekti.Name = "comboBoxProjekti";
            comboBoxProjekti.Size = new Size(278, 28);
            comboBoxProjekti.TabIndex = 28;
            // 
            // lblProjektiNaziv
            // 
            lblProjektiNaziv.AutoSize = true;
            lblProjektiNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProjektiNaziv.ForeColor = Color.Black;
            lblProjektiNaziv.Location = new Point(11, 51);
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
            dateTimePicker1.Location = new Point(570, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDatum.ForeColor = Color.Black;
            lblDatum.Location = new Point(416, 17);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(136, 20);
            lblDatum.TabIndex = 3;
            lblDatum.Text = "Raspored za datum:";
            // 
            // comboBoxPartneri
            // 
            comboBoxPartneri.FormattingEnabled = true;
            comboBoxPartneri.Items.AddRange(new object[] { "Partner 1.", "Partner 2.", "Partner 3.", "Partner 4." });
            comboBoxPartneri.Location = new Point(90, 13);
            comboBoxPartneri.Name = "comboBoxPartneri";
            comboBoxPartneri.Size = new Size(278, 28);
            comboBoxPartneri.TabIndex = 2;
            // 
            // lblPartneriNaziv
            // 
            lblPartneriNaziv.AutoSize = true;
            lblPartneriNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPartneriNaziv.ForeColor = Color.Black;
            lblPartneriNaziv.Location = new Point(11, 17);
            lblPartneriNaziv.Name = "lblPartneriNaziv";
            lblPartneriNaziv.Size = new Size(59, 20);
            lblPartneriNaziv.TabIndex = 0;
            lblPartneriNaziv.Text = "Partner:";
            // 
            // btnUpisi
            // 
            btnUpisi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpisi.BackColor = Color.FromArgb(142, 195, 176);
            btnUpisi.Location = new Point(975, 9);
            btnUpisi.Name = "btnUpisi";
            btnUpisi.Size = new Size(94, 33);
            btnUpisi.TabIndex = 27;
            btnUpisi.Text = "Upiši";
            btnUpisi.UseVisualStyleBackColor = false;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(217, 235, 228);
            pnlFooter.Controls.Add(btnUpisi);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 493);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1115, 54);
            pnlFooter.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewComboBoxColumn1, dataGridViewComboBoxColumn2, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewCheckBoxColumn1 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1115, 400);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle13.ForeColor = Color.Black;
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn1.HeaderText = "Šifra Osobe";
            dataGridViewTextBoxColumn1.MinimumWidth = 90;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle14.ForeColor = Color.Black;
            dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewComboBoxColumn1.HeaderText = "Djelatnik";
            dataGridViewComboBoxColumn1.Items.AddRange(new object[] { "Djelatnik 1.", "Djelatnik 2.", "Djelatnik 3.", "Djelatnik 4", "Djelatnik 5.", "Djelatnik 6." });
            dataGridViewComboBoxColumn1.MinimumWidth = 350;
            dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.Black;
            dataGridViewComboBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewComboBoxColumn2.HeaderText = "Smjena";
            dataGridViewComboBoxColumn2.Items.AddRange(new object[] { "1. smjena", "2. smjena", "3. smjena" });
            dataGridViewComboBoxColumn2.MinimumWidth = 150;
            dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            dataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewComboBoxColumn2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.Black;
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn2.HeaderText = "Od";
            dataGridViewTextBoxColumn2.MinimumWidth = 80;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.Black;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn3.HeaderText = "Do";
            dataGridViewTextBoxColumn3.MinimumWidth = 80;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = Color.Black;
            dataGridViewCellStyle18.NullValue = false;
            dataGridViewCheckBoxColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewCheckBoxColumn1.HeaderText = "Odrađeno";
            dataGridViewCheckBoxColumn1.MinimumWidth = 100;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewCheckBoxColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}