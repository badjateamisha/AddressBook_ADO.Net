// See https://aka.ms/new-console-template for more information
using AddressBookDB_ADO.net;

Console.WriteLine("Hello, AddressBook ADO.net!");
AddressBookRepo address = new();
address.Create_Database();