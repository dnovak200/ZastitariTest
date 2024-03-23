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
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(lblDatum);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(lblProjektiNaziv);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1275, 67);
            panel1.TabIndex = 0;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBox1.Location = new Point(90, 14);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 28);
            comboBox1.TabIndex = 2;
            // 
            // lblProjektiNaziv
            // 
            lblProjektiNaziv.AutoSize = true;
            lblProjektiNaziv.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProjektiNaziv.ForeColor = Color.Black;
            lblProjektiNaziv.Location = new Point(12, 17);
            lblProjektiNaziv.Name = "lblProjektiNaziv";
            lblProjektiNaziv.Size = new Size(57, 20);
            lblProjektiNaziv.TabIndex = 0;
            lblProjektiNaziv.Text = "Projekt:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 534);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { osobaSifra, osobaNaziv, smjena, vrijemeOd, vrijemeDo, odradjenaSmjena });
            dataGridView1.Location = new Point(3, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1057, 465);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 601);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
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
    }
}