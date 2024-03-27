namespace ZastitariTest
{
    partial class FormProjektiKopirajRaspored
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
            label4 = new Label();
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDatum = new Label();
            label1 = new Label();
            dateTimePicker3 = new DateTimePicker();
            label3 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(217, 235, 228);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 70);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(469, 31);
            label4.TabIndex = 4;
            label4.Text = "Kopiranje rasporeda na projektu za period";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(217, 235, 228);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(dateTimePicker3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(lblDatum);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 296);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(64, 53);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(19, 58);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 42;
            label2.Text = "Do :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(64, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 41;
            // 
            // lblDatum
            // 
            lblDatum.AutoSize = true;
            lblDatum.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblDatum.ForeColor = Color.Black;
            lblDatum.Location = new Point(19, 24);
            lblDatum.Name = "lblDatum";
            lblDatum.Size = new Size(35, 20);
            lblDatum.TabIndex = 40;
            lblDatum.Text = "Od :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(19, 105);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 45;
            label1.Text = "kopirati na poriod";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(64, 146);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 47;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(19, 151);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 46;
            label3.Text = "Od :";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(142, 195, 176);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(220, 236);
            button4.Name = "button4";
            button4.Size = new Size(94, 33);
            button4.TabIndex = 48;
            button4.Text = "Prihvati";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormProjektiKopirajRaspored
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 380);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormProjektiKopirajRaspored";
            Text = "FormProjektiKopirajRaspored";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Panel panel2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label lblDatum;
        private DateTimePicker dateTimePicker3;
        private Label label3;
        private Button button4;
    }
}