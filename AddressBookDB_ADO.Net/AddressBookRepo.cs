using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDB_ADO.net
{
    public class AddressBookRepo
    {
        public void Create_Database()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-V3661QR; Initial Catalog =master; Integrated Security = True;");
                Connection.Open();
                SqlCommand cmd = new SqlCommand("Create database AddressBookForADO;", Connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("AddressbookService Database created successfully!");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }
    }
}