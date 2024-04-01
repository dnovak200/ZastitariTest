using System.Configuration;
using System.Data;
using System.Data.SQLite;

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

           
            // Create a DataSet to hold the data
            dataTable = new DataTable();

            // Fill the DataSet with data from the database using the DataAdapter
            adapter.Fill(dataTable);
            
            txtIme.DataBindings.Add("Text", dataTable, "ime");
            txtPrezime.DataBindings.Add("Text", dataTable, "prezime");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the database with changes made in textboxes
                SQLiteCommand updateCommand = new SQLiteCommand("UPDATE djelatnik SET ime = @ime, prezime = @prezime WHERE sifra = @sifra", connection);
                updateCommand.Parameters.AddWithValue("@sifra", txtSifra.Text);
                updateCommand.Parameters.AddWithValue("@ime", txtIme.Text);
                updateCommand.Parameters.AddWithValue("@prezime", txtPrezime.Text);

                int rowsAffected = updateCommand.ExecuteNonQuery();

                // Check if any rows were affected
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Update successful. {rowsAffected} rows affected.");
                }
                else
                {
                    MessageBox.Show("Update failed or no rows affected.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
            }

        }
    }
}
