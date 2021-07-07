using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("...Welcome to Address Book Program..." + "\n");

            // Creating object
            AddressBook addressBook = new AddressBook();
            string userChoice = string.Empty;

            do
            {
                Console.WriteLine("**Select an Option**");
                Console.WriteLine("Press 1. To add new person");
                Console.WriteLine("Press 2. To edit existing person");
                Console.WriteLine("Press 3. To delete a person");
                Console.WriteLine("Press 4. To view all persons" + "\n");

                int userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
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

                        Console.WriteLine("Person added successfully...");
                        break;

                    case 2:
                        addressBook.ShowContact();
                        addressBook.EditContact();
                        break;

                    case 3:
                        addressBook.DeletePerson();
                        break;

                    case 4:
                        addressBook.ShowContact();
                        break;
                }
                do
                {
                    Console.WriteLine("\n" + "Do you want to continue - Yes or No??");
                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "YES" && userChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, Please say Yes or No...");
                    }
                } while (userChoice != "YES" && userChoice != "NO");
            } while (userChoice == "YES");
        }
    }
}