using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        public string address;
        public string firstname, lastname;
        public string city, state;
        public int zipcode;
        public long phoneNumber;
        public string email;


        //Constructor
        public AddressBook(string address, string firstname, string lastname, string city, string state, int zipcode, long phoneNumber, string email)
        {
            this.address = address;
            this.firstname = firstname;
            this.lastname = lastname;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public void Create()
        {
            Console.WriteLine("To create a new address book !");
            Dictionary<string, string> data = new Dictionary<string, string>();
        }

        //Show
        public void Show()
        {
            Console.WriteLine("Address : " + address);
            Console.WriteLine("First Name : " + firstname);
            Console.WriteLine("Last Name : " + lastname);
            Console.WriteLine("City : " + city);
            Console.WriteLine("State : " + state);
            Console.WriteLine("Zipcode : " + zipcode);
            Console.WriteLine("Phone Number : " + phoneNumber);
            Console.WriteLine("Email : " + email);
        }
    }
}
