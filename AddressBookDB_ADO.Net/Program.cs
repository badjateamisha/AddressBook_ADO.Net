// See https://aka.ms/new-console-template for more information
using AddressBookDB_ADO.net;

Console.WriteLine("Hello, AddressBook ADO.net!");
AddressBookRepo address = new();
AddressBookModel addressbook = new AddressBookModel();
while (true)
{
    Console.WriteLine("Choose the option :\n1)Create a Database\n2)Create table in DB\n3)Insert Values ti Table\n4)Retrieve values from Table\n6)Update details of Contact\n7)Delete Contact");
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
        case 5:
            //Reference Method Call
            AddressBookModel addressbook1 = new AddressBookModel();
            addressbook1.FirstName = "ameesa";
            addressbook1.LastName = "jain";
            addressbook1.Address = "Qwerty Colony";
            addressbook1.City = "Pune";
            addressbook1.State = "MH";
            addressbook1.Zip = "411033";
            addressbook1.PhoneNumber = "9000000001";
            addressbook1.Email = "amisha@gmail.com";
            address.UpdateContact(addressbook1);
            Console.WriteLine("Record Updated successfully");
            break;
        case 6:
            string UpdatedAddress = address.updateEmployeeDetails();
            Console.WriteLine(UpdatedAddress);
            break;
        case 7:
            addressbook.FirstName = "Sagar";
            address.DeleteContact(addressbook);
            break;
        default:
            Console.WriteLine("Please choose correct option");
            break;
    }
}