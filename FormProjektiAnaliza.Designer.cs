﻿namespace ZastitariTest
{
    partial class FormProjektiAnaliza
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
            comboBox2 = new ComboBox();
            label3 = new Label();
            btnPrihvati = new Button();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBoxProjekti = new ComboBox();
            lblProjektiNaziv = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            comboBoxPartneri = new ComboBox();
            lblPartneriNaziv = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            RUC = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnPrihvati);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxProjekti);
            panel1.Controls.Add(lblProjektiNaziv);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblDatum);
            panel1.Controls.Add(comboBoxPartneri);
            panel1.Controls.Add(lblPartneriNaziv);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1107, 122);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(142, 195, 176);
            button1.Location = new Point(1001, 80);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 42;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1. Smjena", "2. Smjena", "3. Smjena" });
            comboBox2.Location = new Point(462, 46);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(161, 28);
            comboBox2.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(383, 50);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 40;
            label3.Text = "Smjena:";
            // 
            // btnPrihvati
            // 
            btnPrihvati.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnPrihvati.BackColor = Color.FromArgb(142, 195, 176);
            btnPrihvati.Location = new Point(874, 80);
            btnPrihvati.Name = "btnPrihvati";
            btnPrihvati.Size = new Size(94, 33);
            btnPrihvati.TabIndex = 39;
            btnPrihvati.Text = "Prihvati";
            btnPrihvati.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(792, 44);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(694, 49);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 37;
            label2.Text = "Period do:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Djelatnik 1", "Djelatnik 2", "Djelatnik 3", "Djelatnik 4", "Djelatnik 5", "Djelatnik 6", "Djelatnik 7" });
            comboBox1.Location = new Point(462, 13);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(221, 28);
            comboBox1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(383, 17);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 35;
            label1.Text = "Djelatnik:";
            // 
            // comboBoxProjekti
            // 
            comboBoxProjekti.FormattingEnabled = true;
            comboBoxProjekti.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBoxProjekti.Location = new Point(89, 46);
            comboBoxProjekti.Name = "comboBoxProjekti";
            comboBoxProjekti.Size = new Size(278, 28);
            comboBoxProjekti.TabIndex = 34;
            // 
            // lblProjektiNaziv
            // 
            lblProjektiNaziv.AutoSize = true;
            lblProjektiNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProjektiNaziv.ForeColor = Color.Black;
            lblProjektiNaziv.Location = new Point(10, 50);
            lblProjektiNaziv.Name = "lblProjektiNaziv";
            lblProjektiNaziv.Size = new Size(57, 20);
            lblProjektiNaziv.TabIndex = 33;
            lblProjektiNaziv.Text = "Projekt:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(792, 10);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDatum.ForeColor = Color.Black;
            lblDatum.Location = new Point(694, 15);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(73, 20);
            lblDatum.TabIndex = 31;
            lblDatum.Text = "Period od:";
            // 
            // comboBoxPartneri
            // 
            comboBoxPartneri.FormattingEnabled = true;
            comboBoxPartneri.Items.AddRange(new object[] { "Partner 1.", "Partner 2.", "Partner 3.", "Partner 4." });
            comboBoxPartneri.Location = new Point(89, 12);
            comboBoxPartneri.Name = "comboBoxPartneri";
            comboBoxPartneri.Size = new Size(278, 28);
            comboBoxPartneri.TabIndex = 30;
            // 
            // lblPartneriNaziv
            // 
            lblPartneriNaziv.AutoSize = true;
            lblPartneriNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPartneriNaziv.ForeColor = Color.Black;
            lblPartneriNaziv.Location = new Point(10, 16);
            lblPartneriNaziv.Name = "lblPartneriNaziv";
            lblPartneriNaziv.Size = new Size(59, 20);
            lblPartneriNaziv.TabIndex = 29;
            lblPartneriNaziv.Text = "Partner:";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(1107, 328);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, RUC });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1095, 328);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Datum";
            Column1.MinimumWidth = 85;
            Column1.Name = "Column1";
            Column1.Width = 85;
            // 
            // Column2
            // 
            Column2.HeaderText = "Naziv partnera";
            Column2.MinimumWidth = 200;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Naziv projekta";
            Column3.MinimumWidth = 200;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Djelatnik";
            Column4.MinimumWidth = 180;
            Column4.Name = "Column4";
            Column4.Width = 180;
            // 
            // Column5
            // 
            Column5.HeaderText = "Smjena";
            Column5.MinimumWidth = 70;
            Column5.Name = "Column5";
            Column5.Width = 70;
            // 
            // Column6
            // 
            Column6.HeaderText = "Sati";
            Column6.MinimumWidth = 60;
            Column6.Name = "Column6";
            Column6.Width = 60;
            // 
            // Column7
            // 
            Column7.HeaderText = "Trošak";
            Column7.MinimumWidth = 80;
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column8
            // 
            Column8.HeaderText = "Prihod";
            Column8.MinimumWidth = 80;
            Column8.Name = "Column8";
            Column8.Width = 80;
            // 
            // RUC
            // 
            RUC.HeaderText = "RUC";
            RUC.MinimumWidth = 80;
            RUC.Name = "RUC";
            RUC.Resizable = DataGridViewTriState.True;
            RUC.Width = 80;
            // 
            // FormProjektiAnaliza
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProjektiAnaliza";
            Text = "FormProjektiAnaliza";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBoxProjekti;
        private Label lblProjektiNaziv;
        private DateTimePicker dateTimePicker1;
        private Label lblDatum;
        private ComboBox comboBoxPartneri;
        private Label lblPartneriNaziv;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnPrihvati;
        private ComboBox comboBox2;
        private Label label3;
        private Button button1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn RUC;
    }
}