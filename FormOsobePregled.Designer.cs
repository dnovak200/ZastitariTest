namespace ZastitariTest
{
    partial class FormOsobePregled
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
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button1 = new Button();
            sifra = new DataGridViewTextBoxColumn();
            ime = new DataGridViewTextBoxColumn();
            prezime = new DataGridViewTextBoxColumn();
            ugovor_aktivan = new DataGridViewCheckBoxColumn();
            Azuriranje = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { sifra, ime, prezime, ugovor_aktivan, Azuriranje });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 360);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.FromArgb(142, 195, 176);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(797, 405);
            button4.Name = "button4";
            button4.Size = new Size(94, 33);
            button4.TabIndex = 38;
            button4.Text = "Potvrdi";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(697, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 39;
            button1.Text = "Excel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sifra
            // 
            sifra.DataPropertyName = "sifra";
            sifra.HeaderText = "Šifra djelatnika";
            sifra.MinimumWidth = 6;
            sifra.Name = "sifra";
            sifra.Resizable = DataGridViewTriState.True;
            sifra.Width = 200;
            // 
            // ime
            // 
            ime.DataPropertyName = "ime";
            ime.HeaderText = "Ime djelatnika";
            ime.MinimumWidth = 6;
            ime.Name = "ime";
            ime.Width = 200;
            // 
            // prezime
            // 
            prezime.DataPropertyName = "prezime";
            prezime.HeaderText = "Prezime djelatnika";
            prezime.MinimumWidth = 6;
            prezime.Name = "prezime";
            prezime.Width = 125;
            // 
            // ugovor_aktivan
            // 
            ugovor_aktivan.DataPropertyName = "ugovor_aktivan";
            ugovor_aktivan.HeaderText = "Ugovor aktivan";
            ugovor_aktivan.MinimumWidth = 6;
            ugovor_aktivan.Name = "ugovor_aktivan";
            ugovor_aktivan.Resizable = DataGridViewTriState.True;
            ugovor_aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            ugovor_aktivan.Width = 125;
            // 
            // Azuriranje
            // 
            Azuriranje.DataPropertyName = "azuriranje";
            Azuriranje.HeaderText = "Ažuriranje";
            Azuriranje.MinimumWidth = 6;
            Azuriranje.Name = "Azuriranje";
            Azuriranje.Width = 125;
            // 
            // FormOsobePregled
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 235, 228);
            ClientSize = new Size(903, 450);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOsobePregled";
            Text = "FormOsobePregled";
            Load += FormOsobePregled_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button4;
        private Button button1;
        private DataGridViewTextBoxColumn sifra;
        private DataGridViewTextBoxColumn ime;
        private DataGridViewTextBoxColumn prezime;
        private DataGridViewCheckBoxColumn ugovor_aktivan;
        private DataGridViewButtonColumn Azuriranje;
    }
}