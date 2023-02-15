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

        public void CreateContact()
        {
            Console.WriteLine("Enter the details:" + "\n Name " + "\n LastName" + "\n Address" +
                "\n City" + "\n State" + "\n Email" + " \n Phone " + "\n Zip");
            contact.Name = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.State= Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.Phone = Console.ReadLine();
            contact.Zip = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Contact Detail" + "\n 1.Name" + contact.Name + "\n 2.LastName " + contact.LastName +
                "\n 3.Address" + contact.Address + " \n 4.City " + contact.City + "\n 5.State" + contact.State +
                "\n 6.Email " + contact.Email + "\n 7.Phone" + contact.Phone + "\n 8.Zip" + contact.Zip);
        }
    }
}
