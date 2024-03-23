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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            comboBox1 = new ComboBox();
            lblProjektiNaziv = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            osobaSifra = new DataGridViewTextBoxColumn();
            osobaNaziv = new DataGridViewComboBoxColumn();
            smjena = new DataGridViewComboBoxColumn();
            vrijemeOd = new DataGridViewTextBoxColumn();
            vrijemeDo = new DataGridViewTextBoxColumn();
            odradjenaSmjena = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblDatum);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblProjektiNaziv);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 50);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(142, 195, 176);
            button2.Location = new Point(873, 9);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 25);
            button2.TabIndex = 27;
            button2.Text = "Odustani";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(142, 195, 176);
            button1.Location = new Point(774, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 25);
            button1.TabIndex = 26;
            button1.Text = "Prihvati";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(499, 9);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDatum.ForeColor = Color.Black;
            lblDatum.Location = new Point(364, 13);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(112, 15);
            lblDatum.TabIndex = 3;
            lblDatum.Text = "Raspored za datum:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBox1.Location = new Point(79, 10);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 2;
            // 
            // lblProjektiNaziv
            // 
            lblProjektiNaziv.AutoSize = true;
            lblProjektiNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProjektiNaziv.ForeColor = Color.Black;
            lblProjektiNaziv.Location = new Point(10, 13);
            lblProjektiNaziv.Name = "lblProjektiNaziv";
            lblProjektiNaziv.Size = new Size(46, 15);
            lblProjektiNaziv.TabIndex = 0;
            lblProjektiNaziv.Text = "Projekt:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 235, 228);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(976, 392);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { osobaSifra, osobaNaziv, smjena, vrijemeOd, vrijemeDo, odradjenaSmjena });
            dataGridView1.Location = new Point(3, 4);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(925, 349);
            dataGridView1.TabIndex = 0;
            // 
            // osobaSifra
            // 
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            osobaSifra.DefaultCellStyle = dataGridViewCellStyle1;
            osobaSifra.HeaderText = "Šifra Osobe";
            osobaSifra.MinimumWidth = 90;
            osobaSifra.Name = "osobaSifra";
            // 
            // osobaNaziv
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            osobaNaziv.DefaultCellStyle = dataGridViewCellStyle2;
            osobaNaziv.HeaderText = "Djelatnik";
            osobaNaziv.Items.AddRange(new object[] { "Djelatnik 1.", "Djelatnik 2.", "Djelatnik 3.", "Djelatnik 4", "Djelatnik 5.", "Djelatnik 6." });
            osobaNaziv.MinimumWidth = 350;
            osobaNaziv.Name = "osobaNaziv";
            osobaNaziv.Resizable = DataGridViewTriState.True;
            osobaNaziv.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // smjena
            // 
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            smjena.DefaultCellStyle = dataGridViewCellStyle3;
            smjena.HeaderText = "Smjena";
            smjena.Items.AddRange(new object[] { "1. smjena", "2. smjena", "3. smjena" });
            smjena.MinimumWidth = 150;
            smjena.Name = "smjena";
            smjena.Resizable = DataGridViewTriState.True;
            smjena.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // vrijemeOd
            // 
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            vrijemeOd.DefaultCellStyle = dataGridViewCellStyle4;
            vrijemeOd.HeaderText = "Od";
            vrijemeOd.MinimumWidth = 80;
            vrijemeOd.Name = "vrijemeOd";
            // 
            // vrijemeDo
            // 
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            vrijemeDo.DefaultCellStyle = dataGridViewCellStyle5;
            vrijemeDo.HeaderText = "Do";
            vrijemeDo.MinimumWidth = 80;
            vrijemeDo.Name = "vrijemeDo";
            // 
            // odradjenaSmjena
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.NullValue = false;
            odradjenaSmjena.DefaultCellStyle = dataGridViewCellStyle6;
            odradjenaSmjena.HeaderText = "Odrađeno";
            odradjenaSmjena.MinimumWidth = 100;
            odradjenaSmjena.Name = "odradjenaSmjena";
            odradjenaSmjena.Resizable = DataGridViewTriState.True;
            odradjenaSmjena.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormProjektiRaspored
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 442);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProjektiRaspored";
            Text = "FormProjektiRaspored";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblProjektiNaziv;
        private Label lblDatum;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn osobaSifra;
        private DataGridViewComboBoxColumn osobaNaziv;
        private DataGridViewComboBoxColumn smjena;
        private DataGridViewTextBoxColumn vrijemeOd;
        private DataGridViewTextBoxColumn vrijemeDo;
        private DataGridViewCheckBoxColumn odradjenaSmjena;
        private Button button1;
        private Button button2;
    }
}