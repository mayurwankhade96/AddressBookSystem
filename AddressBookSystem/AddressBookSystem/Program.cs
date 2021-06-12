using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program...");

            // Creating object
            AddressBook addressBook = new AddressBook();

            // Getting input from user
            Console.WriteLine("Enter your First Name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your Address : ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your City : ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter your State : ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter your Zip : ");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Phone Number : ");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();

            Console.WriteLine();

            addressBook.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, email);
            addressBook.ShowContact();
        }
    }
}