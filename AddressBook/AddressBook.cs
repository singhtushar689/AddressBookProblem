using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBook
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();

        public void CreateContact()
        {
            Console.WriteLine("Enter the details:");
            Console.WriteLine("Enter the First Name:");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Email");
            contact.Email = Console.ReadLine();
            Console.WriteLine("Enter the Phone");
            contact.Phone = Console.ReadLine();
            Console.WriteLine("Enter the ZipCode");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            contactList.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("Contact Detail:" + "\n 1.Name:" + contact.Name + "\n 2.LastName :" + contact.LastName +
                "\n 3.Address:" + contact.Address + " \n 4.City :" + contact.City + "\n 5.State :" + contact.State +
                "\n 6.Email :" + contact.Email + "\n 7.Phone:" + contact.Phone + "\n 8.Zip :" + contact.Zip);
        }
        public void EditContact(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.Name.Equals(name))
                {
                    Console.WriteLine("Enter the option to edit details");
                    Console.WriteLine("1.Address \n 2.City \n 3.State \n 4.Email \n 5.Phone \n 6.ZipCode");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the new address");
                            contact.Address = Console.ReadLine();
                            break;
                            case 2:
                            Console.WriteLine("Enter the City Name");
                            contact.City = Console.ReadLine();
                            break;
                            case 3:
                            Console.WriteLine("Enter the State ");
                            contact.State = Console.ReadLine();
                            break;
                            case 4:
                            Console.WriteLine("Enter the E-Mail");
                            contact.Email = Console.ReadLine();
                            break;
                            case 5:
                            Console.WriteLine("Enter the Phone Number ");
                            contact.Phone = Console.ReadLine();
                            break;
                            case 6:
                            Console.WriteLine("Enter the Zip-Code");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                }

            }
        }

    }
}
