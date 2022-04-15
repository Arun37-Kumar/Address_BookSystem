using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        public string addressBook;
        public string address;
        public string firstname, lastname;
        public string city, state;
        public int zipcode;
        public long phoneNumber;
        public string email;
        public List<AddressBook> listContact = new List<AddressBook>();

        internal AddressBook() { }

        public AddressBook(string addressBook,string address, string firstname, string lastname, string city, string state, int zipcode, long phoneNumber, string email)
        {
            this.addressBook = addressBook;
            this.address = address;
            this.firstname = firstname;
            this.lastname = lastname;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void CreateContacts(string addressBook)
        {
            Console.WriteLine("Enter First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zipcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            int phoneNumber = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email Id");
            string email = Console.ReadLine();
            AddressBook objContact = new AddressBook(addressBook,address, firstname, lastname, city, state, zipcode, phoneNumber, email);
            listContact.Add(objContact);
            Console.WriteLine("Contact has been Added to " + addressBook);
        }

        internal void EditContact(string addressBook)
        {
            Console.WriteLine("Enter First Name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            string lastname = Console.ReadLine();
            bool personFound = false;
            foreach (AddressBook item in listContact)
            {
                if ((((item.firstname).ToLower() == firstname.ToLower()) && ((item.lastname).ToLower() == lastname.ToLower())) && item.addressBook == addressBook)
                {
                    Console.WriteLine("Enter new Address");
                    item.address = Console.ReadLine();
                    Console.WriteLine("Enter new City");
                    item.city = Console.ReadLine();
                    Console.WriteLine("Enter new State");
                    item.state = Console.ReadLine();
                    Console.WriteLine("Enter new Address");
                    item.zipcode = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter new Phone Number");
                    item.phoneNumber = (int)Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("Enter new Email");
                    item.email = Console.ReadLine();
                    personFound = true;
                    Console.WriteLine("Details have been updated in " + addressBook);
                }
            }
            if (personFound == false)
            {
                Console.WriteLine("Person not found");
            }
        }

        internal void DeleteContact(string addressBookName)
        {
            Console.WriteLine("Enter First Name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Second Name");
            string sName = Console.ReadLine();
            bool personFound = false;
            AddressBook personToDelete = new AddressBook();
            foreach (AddressBook item in listContact)
            {
                if ((((item.firstname).ToLower() == fName.ToLower()) && ((item.lastname).ToLower() == sName.ToLower())) && item.addressBook == addressBookName)
                {
                    personToDelete = item;
                    personFound = true;
                    Console.WriteLine("Person has been Removed from Contacts in " + addressBookName);
                }
            }
            listContact.Remove(personToDelete);
            if (personFound == false)
            {
                Console.WriteLine("Person not found");
            }
        }


    }
}
