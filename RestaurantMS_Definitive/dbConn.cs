using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RestaurantMS_Definitive
{
    class dbConn
    {
        OleDbConnection connection = new OleDbConnection(Properties.Settings.Default.connectionString);
        ~dbConn() { connection.Close();  }
        
        public OleDbConnection oleconnection
        {
            get { return connection; }
        }

        public string connectionString
        {
            get { return connection.ConnectionString; }
        }

        public void open()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nuk mund të hapet lidhja me databazën");
            }
        }
        public void close()
        {
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
