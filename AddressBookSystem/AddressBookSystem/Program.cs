using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main()
        {
            // creating object
            AddressBook book = new AddressBook();

            // calls set accessor of the properties
            book.FirstName = "Mayur";
            book.LastName = "W";
            book.Address = "Navi Mumbai";
            book.City = "Vashi";
            book.State = "Maharashtra";
            book.Zip = 400703;
            book.PhoneNumber = 808080;
            book.Email = "mayur.wankhade2@gmail.com";

            // displaying values
            Console.WriteLine("First Name : " + book.FirstName);
            Console.WriteLine("Last Name : " + book.LastName);
            Console.WriteLine("Address : " + book.Address);
            Console.WriteLine("City : " + book.City);
            Console.WriteLine("State : " + book.State);
            Console.WriteLine("Zip : " + book.Zip);
            Console.WriteLine("Phone Number : " + book.PhoneNumber);
            Console.WriteLine("Email : " + book.Email);
        }
    }
}
