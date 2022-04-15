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

        //Constructor
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
    }
}
