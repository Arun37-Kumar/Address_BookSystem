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

        public void Add()
        {
            var zipcode = new List<int>();
            var phoneNumber = new List<int>();

            var address = new List<string>();
            var firstname = new List<string>();
            var lastname = new List<string>();
            var city = new List<string>();
            var state = new List<string>();
            var email = new List<string>();
            //Enter the inputs
            Console.WriteLine("Enter address : ");
            address.Add(Console.ReadLine());
            Console.WriteLine("Enter firstname : ");
            firstname.Add(Console.ReadLine());
            Console.WriteLine("Enter lastname : ");
            lastname.Add(Console.ReadLine());
            Console.WriteLine("Enter city : ");
            city.Add(Console.ReadLine());
            Console.WriteLine("Enter state : ");
            state.Add(Console.ReadLine());
            Console.WriteLine("Enter email : ");
            email.Add(Console.ReadLine());

            Console.WriteLine("Enter zipcode : ");
            zipcode.Add(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter phone number : ");
            phoneNumber.Add(Convert.ToInt32(Console.ReadLine()));


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
