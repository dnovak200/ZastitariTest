using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZastitariTest
{
    public partial class FormOsobeDodaj : Form
    {
        private string sifra;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        private SQLiteConnection? connection;
        private SQLiteDataAdapter? adapter;
        private DataTable? dataTable;
        public FormOsobeDodaj(string sifra = "")
        {
            InitializeComponent();
            this.sifra = sifra;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Dispose of the adapter and table objects
            adapter?.Dispose();
            dataTable?.Dispose();

            // Close the connection
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
            this.Close();
        }

        private void FormOsobeDodaj_Load(object sender, EventArgs e)
        {
            txtSifra.Text = sifra;

            connection = new SQLiteConnection(connectionString);

            connection.Open();
            


            SQLiteCommand selectCommand = new SQLiteCommand("SELECT sifra, ime, prezime FROM djelatnik WHERE sifra = @sifra", connection);
            selectCommand.Parameters.AddWithValue("@sifra", sifra);

            adapter = new SQLiteDataAdapter(selectCommand);
            
            adapter.UpdateCommand = new SQLiteCommand("UPDATE djelatnik SET ime = @ime, prezime = @prezime WHERE sifra = @sifra", connection);
            adapter.UpdateCommand.Parameters.Add("@sifra", DbType.String, 0, "sifra");
            adapter.UpdateCommand.Parameters.Add("@ime", DbType.String, 0, "ime");
            adapter.UpdateCommand.Parameters.Add("@prezime", DbType.String, 0, "prezime");
            

            // Create a DataSet to hold the data
            dataTable = new DataTable();

            // Fill the DataSet with data from the database using the DataAdapter
            adapter.Fill(dataTable);

            txtSifra.DataBindings.Add("Text", dataTable, "sifra");
            txtPrezime.DataBindings.Add("Text", dataTable, "prezime");
            txtIme.DataBindings.Add("Text", dataTable, "ime");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the database with changes made in textboxes
                adapter.Update(dataTable);
                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
            }

        }
    }
}
