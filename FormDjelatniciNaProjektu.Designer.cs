namespace ZastitariTest
{
    partial class FormDjelatniciNaProjektu
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 150);
            panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Poslovna zgrada 1.", "Poslovna zgrada 2.", "Poslovna zgrada 3.", "Skladište 1.", "Skladište 2.", "Skladište 3." });
            comboBox1.Location = new Point(131, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(325, 28);
            comboBox1.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(248, 31);
            label1.TabIndex = 10;
            label1.Text = "Djelatnici na projektu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(8, 68);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 11;
            label2.Text = "Šifra projekta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 101);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 13;
            label3.Text = "Naziv projekta:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(21, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(552, 188);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Šifra";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ime i Prezime djelatnika";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 400;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(142, 195, 176);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(479, 396);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 38;
            button3.Text = "Odustani";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(142, 195, 176);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(345, 396);
            button4.Name = "button4";
            button4.Size = new Size(94, 33);
            button4.TabIndex = 37;
            button4.Text = "Prihvati";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormDjelatniciNaProjektu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 235, 228);
            ClientSize = new Size(620, 450);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "FormDjelatniciNaProjektu";
            Text = "FormDjelatniciNaProjektu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button button3;
        private Button button4;
    }
}