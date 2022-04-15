using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Cases
    {
        internal static void AddressBook(string addressBookName)
        {
            Console.WriteLine("Enter 1 to Add Contact\nEnter 2 to Edit Contact\nEnter 3 to Delete Person From Contact\nEnter 4 to Create new Address Book or to Work on saved Address Book\nEnter 5 to Exit");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Program.addressBookDict[addressBookName] = new AddressBook();
                    Program.addressBookDict[addressBookName].CreateContacts(addressBookName);
                    AddressBook(addressBookName);
                    break;
                case 2:
                    Program.addressBookDict[addressBookName] = new AddressBook();
                    Program.addressBookDict[addressBookName].EditContact(addressBookName);
                    AddressBook(addressBookName);
                    break;
                case 3:
                    Program.addressBookDict[addressBookName] = new AddressBook();
                    Program.addressBookDict[addressBookName].DeleteContact(addressBookName);
                    AddressBook(addressBookName);
                    break;
                case 4:
                    
                    break;
                case 5:
                    Program.addressBookDict[addressBookName] = new AddressBook();
                    Program.addressBookDict[addressBookName].AllContacts(addressBookName);
                    AddressBook(addressBookName);
                    break;
                default:
                    Console.WriteLine("Try Again. Wrong key");
                    break;
            }
        }
}
