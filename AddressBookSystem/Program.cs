using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System : ");


            Console.WriteLine("Enter the address book name : ");
            string addressBookName = Console.ReadLine();
            AddressBook newAddress = new AddressBook();
            //Create Contact
            newAddress.CreateContacts(addressBookName);
            // Edit Address
            newAddress.EditContact(addressBookName);
            //Delete Contact
            newAddress.DeleteContact(addressBookName);
            Console.ReadLine();



        }
    }
}
