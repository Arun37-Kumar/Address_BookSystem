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
            AddressBook add = new AddressBook("address", "firstname", "lastname", "city", "state", 1234567, 9876543210, "abc@gmail.com");
            add.Add();
            Console.WriteLine("-------------");
            //add.Show();
            Console.ReadLine();



        }
    }
}
