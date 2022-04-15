using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        public static Dictionary<string, AddressBook> addressBookDict = new Dictionary<string, AddressBook>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book System : ");


            Console.WriteLine("Enter the address book name : ");

            string addressBookName = Console.ReadLine();
            Cases.AddressBook(addressBookName);
            //AddressBook newAddress = new AddressBook();
            ////Create Contact
            //newAddress.CreateContacts(addressBookName);
            //// Edit Address
            //newAddress.EditContact(addressBookName);
            ////Delete Contact
            //newAddress.DeleteContact(addressBookName);

            //newAddress.AllContacts(addressBookName);
            Console.ReadLine();



        }
    }
}
