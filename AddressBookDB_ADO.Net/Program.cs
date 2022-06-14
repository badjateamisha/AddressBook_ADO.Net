// See https://aka.ms/new-console-template for more information
using AddressBookDB_ADO.net;

Console.WriteLine("Hello, AddressBook ADO.net!");
AddressBookRepo address = new();
while (true)
{
    Console.WriteLine("Choose the option :\n1)Create a Database\n2)Create table in DB\n3)Insert Values ti Table\n4)Retrieve values from Table");
    int option = Convert.ToInt16(Console.ReadLine());
    switch (option)
    {
        case 1:
            address.CreateDatabase();
            break;
        case 2:
            address.CreateTable();
            break;
        case 3:
            AddressBookModel addressbook = new AddressBookModel();
            addressbook.FirstName = "Amisha";
            addressbook.LastName = "Jain";
            addressbook.Address = "Qwerty Colony";
            addressbook.City = "Pune";
            addressbook.State = "MH";
            addressbook.Zip = "411033";
            addressbook.PhoneNumber = "9000000001";
            addressbook.Email = "amisha@gmail.com";
            address.AddContact(addressbook);
            Console.WriteLine("Record Inserted successfully");
            break;
        case 4:
            address.GetAllContact();
            break;
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }
}