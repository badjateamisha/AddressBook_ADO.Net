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
        public void CreateDatabase()
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
        public void CreateTable()
        {
            try
            {
                SqlConnection Connection = new SqlConnection(@"Data Source=DESKTOP-V3661QR; Initial Catalog =AddressBookForADO; Integrated Security = True;");
                Connection.Open();
                SqlCommand cmd = new SqlCommand("Create table AddressBook(ID int identity(1,1)primary key,FirstName varchar(200),LastName varchar(200),Address varchar(200), City varchar(200), State varchar(200), Zip varchar(200), PhoneNumber varchar(50), Email varchar(200)); ", Connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("AddressBook table is created!");
                Connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
    }
}