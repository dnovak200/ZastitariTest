﻿namespace ZastitariTest
{
    partial class FormOsobeDodaj
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
            txtSifra = new TextBox();
            lblSifra = new Label();
            label3 = new Label();
            lblPrezime = new Label();
            txtPrezime = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox8 = new TextBox();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // txtSifra
            // 
            txtSifra.Location = new Point(82, 29);
            txtSifra.Name = "txtSifra";
            txtSifra.Size = new Size(125, 27);
            txtSifra.TabIndex = 1;
            // 
            // lblSifra
            // 
            lblSifra.AutoSize = true;
            lblSifra.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSifra.Location = new Point(27, 33);
            lblSifra.Name = "lblSifra";
            lblSifra.Size = new Size(40, 20);
            lblSifra.TabIndex = 2;
            lblSifra.Text = "Šifra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 67);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 3;
            label3.Text = "Djelatnik";
            // 
            // lblPrezime
            // 
            lblPrezime.AutoSize = true;
            lblPrezime.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblPrezime.Location = new Point(11, 99);
            lblPrezime.Name = "lblPrezime";
            lblPrezime.Size = new Size(64, 20);
            lblPrezime.TabIndex = 4;
            lblPrezime.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(127, 95);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(125, 27);
            txtPrezime.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(127, 128);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.Location = new Point(11, 131);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 6;
            label5.Text = "Ime:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(127, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(329, 27);
            textBox4.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label6.Location = new Point(11, 253);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 8;
            label6.Text = "Adresa:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(127, 283);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(83, 27);
            textBox5.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label7.Location = new Point(11, 286);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 10;
            label7.Text = "Poštanski broj:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(278, 283);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 27);
            textBox6.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label8.Location = new Point(225, 286);
            label8.Name = "label8";
            label8.Size = new Size(43, 20);
            label8.TabIndex = 12;
            label8.Text = "Grad:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label9.Location = new Point(11, 164);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 14;
            label9.Text = "Spol:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "Ž" });
            comboBox1.Location = new Point(127, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 28);
            comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1 - Ugovor o radu", "2 - Student", "3 - Ugovor o djelu", "4 - Ugovor sa d.o.o." });
            comboBox2.Location = new Point(592, 117);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(196, 28);
            comboBox2.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label10.Location = new Point(480, 121);
            label10.Name = "label10";
            label10.Size = new Size(88, 20);
            label10.TabIndex = 19;
            label10.Text = "Tip ugovora:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(127, 334);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(329, 27);
            textBox7.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label11.Location = new Point(11, 338);
            label11.Name = "label11";
            label11.Size = new Size(106, 20);
            label11.TabIndex = 21;
            label11.Text = "Adresa E-pošte:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(127, 368);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(148, 27);
            textBox8.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label12.Location = new Point(11, 372);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 23;
            label12.Text = "Telefon:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(142, 195, 176);
            button1.Location = new Point(535, 381);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 25;
            button1.Text = "Prihvati";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(142, 195, 176);
            button2.Location = new Point(669, 381);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 26;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label1.Location = new Point(11, 204);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 27;
            label1.Text = "OIB:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(127, 197);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(125, 27);
            textBox9.TabIndex = 28;
            // 
            // FormOsobeDodaj
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 235, 228);
            ClientSize = new Size(811, 448);
            Controls.Add(textBox9);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(comboBox2);
            Controls.Add(label10);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(txtPrezime);
            Controls.Add(lblPrezime);
            Controls.Add(label3);
            Controls.Add(lblSifra);
            Controls.Add(txtSifra);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOsobeDodaj";
            Text = "FormOsobeDodaj";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSifra;
        private Label lblSifra;
        private Label label3;
        private Label lblPrezime;
        private TextBox txtPrezime;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label10;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox8;
        private Label label12;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox9;
    }
}