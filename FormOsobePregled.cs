using ClosedXML.Excel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;


namespace ZastitariTest
{

    public partial class FormOsobePregled : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        private SQLiteConnection? connection;
        private SQLiteDataAdapter? adapter;
        private DataTable? dataTable;


        public FormOsobePregled()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void FormOsobePregled_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection(connectionString);

            connection.Open();

            // Create DataAdapter with commands
            adapter = new SQLiteDataAdapter();

            // SELECT
            adapter.SelectCommand = new SQLiteCommand("SELECT sifra, ime, prezime, ugovor_aktivan FROM djelatnik", connection);

            // INSERT
            adapter.InsertCommand = new SQLiteCommand("INSERT INTO djelatnik (sifra, ime, prezime, ugovor_aktivan) VALUES (@sifra, @ime, @prezime, @ugovor_aktivan)", connection);
            adapter.InsertCommand.Parameters.Add("@sifra", DbType.String, 0, "sifra");
            adapter.InsertCommand.Parameters.Add("@ime", DbType.String, 0, "ime");
            adapter.InsertCommand.Parameters.Add("@prezime", DbType.String, 0, "prezime");
            adapter.InsertCommand.Parameters.Add("@ugovor_aktivan", DbType.Boolean, 0, "ugovor_aktivan");

            // UPDATE
            adapter.UpdateCommand = new SQLiteCommand("UPDATE djelatnik SET ime = @ime, prezime = @prezime, ugovor_aktivan = @ugovor_aktivan WHERE sifra = @sifra", connection);
            adapter.UpdateCommand.Parameters.Add("@sifra", DbType.String, 0, "sifra");
            adapter.UpdateCommand.Parameters.Add("@ime", DbType.String, 0, "ime");
            adapter.UpdateCommand.Parameters.Add("@prezime", DbType.String, 0, "prezime");
            adapter.UpdateCommand.Parameters.Add("@ugovor_aktivan", DbType.Boolean, 0, "ugovor_aktivan");

            // DELETE
            adapter.DeleteCommand = new SQLiteCommand("DELETE FROM djelatnik WHERE sifra = @sifra", connection);
            adapter.DeleteCommand.Parameters.Add("@sifra", DbType.String, 0, "sifra");

            // Create a DataSet to hold the data
            dataTable = new DataTable();

            // Fill the DataSet with data from the database using the DataAdapter
            adapter.Fill(dataTable);

            // Set the DataGridView's DataSource to the filled DataSet
            dataGridView1.DataSource = dataTable;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the database with changes in the DataTable
                adapter!.Update(dataTable);
                MessageBox.Show("Data inserted successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }

        }

        private void FormOsobePregled_FormClosing(object sender, FormClosingEventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string folderPath = @"C:\Users\Kristijan\Desktop\";

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dataTable, "Djelatnici");
                wb.Worksheet(1).Cells("A1:D1").Style.Fill.BackgroundColor = XLColor.DarkGreen;
                wb.SaveAs("test.xlsx");
            }
        }
    }
}