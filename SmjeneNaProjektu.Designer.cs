namespace ZastitariTest
{
    partial class SmjeneNaProjektu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmjeneNaProjektu));
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewComboBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBox1.Location = new Point(131, 95);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(325, 28);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 98);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 8;
            label3.Text = "Naziv projekta:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 65);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 6;
            label2.Text = "Šifra projekta:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 139);
            panel1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(221, 31);
            label4.TabIndex = 11;
            label4.Text = "Smjene na projektu";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(78, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 188);
            dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Naziv smjene";
            Column1.Items.AddRange(new object[] { "1. Smjena", "2. Smjena", "3. Smjena" });
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            Column1.SortMode = DataGridViewColumnSortMode.Automatic;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Od (sati)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Do (sati)";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Broj djelatnika po smjeni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cijena";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(142, 195, 176);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(664, 382);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 38;
            button3.Text = "Odustani";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(142, 195, 176);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(530, 382);
            button4.Name = "button4";
            button4.Size = new Size(94, 33);
            button4.TabIndex = 37;
            button4.Text = "Prihvati";
            button4.UseVisualStyleBackColor = false;
            // 
            // SmjeneNaProjektu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 235, 228);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SmjeneNaProjektu";
            Text = "ITS Guardian";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button4;
        private Label label4;
        private DataGridViewComboBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}