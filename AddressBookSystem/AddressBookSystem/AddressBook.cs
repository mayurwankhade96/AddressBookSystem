using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookSystem
{
    class AddressBook
    {
        List<Contact> Contacts = new List<Contact>();

        public void AddContact(string firstName, string lastName, string address, string city, string state, int zip, long phoneNumber, string email)
        {
            Contact C = new Contact();
            C.FirstName = firstName;
            C.LastName = lastName;
            C.Address = address;
            C.City = city;
            C.State = state;
            C.Zip = zip;
            C.PhoneNumber = phoneNumber;
            C.Email = email;

            Contacts.Add(C);
        }

        public void ShowContact()
        {
            foreach (Contact C in Contacts)
            {
                Console.WriteLine("First Name : " + C.FirstName);
                Console.WriteLine("Last Name : " + C.LastName);
                Console.WriteLine("Address : " + C.Address);
                Console.WriteLine("City : " + C.City);
                Console.WriteLine("State : " + C.State);
                Console.WriteLine("Zip : " + C.Zip);
                Console.WriteLine("Phone Number : " + C.PhoneNumber);
                Console.WriteLine("Email : " + C.Email);
            }
        }
    }
}
