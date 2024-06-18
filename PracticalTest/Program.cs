using PracticalTest.Controller;
using PracticalTest.model;
using PracticalTest.service;

namespace PracticalTest
{
    class Program
    {
        static string connectionString = "Server=localhost;Database=PracticalTestCSharp;User Id=root;Password=;";
        public static void Main(string[] args)
        {
            IContactService contactService = new ContactService(connectionString);
            ContactController contactController = new ContactController(contactService);
            while (true)
            {
                Console.WriteLine("Contact Management");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Find a contact by name");
                Console.WriteLine("3. Display contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter contact name: ");
                        string Name = Console.ReadLine();
                        Console.Write("Enter phoneNumber: ");
                        String PhoneNumber = Console.ReadLine();
                        Contact contact = new Contact(Name, PhoneNumber);
                        contactController.addContact(contact);
                        break;
                    case "2":
                        Console.Write("Enter name to find: ");
                        string name = Console.ReadLine();
                        contactService.searchContactByName(name);
                        
                        break;
                    case "3":
                        Console.WriteLine("Contacts:");
                        contactController.getAllContact();
                        break;
                    case "4":
                        Console.WriteLine("Exiting program.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter again.");
                        break;
                }
            }
        }
    }
}