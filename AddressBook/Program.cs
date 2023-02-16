using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any option given below: \n 1.CreateContact \n 2.Edit Contact \n Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            AddressBook book = new AddressBook();
            switch (option)
            {
                case 1:                  
                    book.CreateContact();
                    book.Display();
                    break;
                case 2:
                    book.CreateContact();
                    book.EditContact("Tushar");
                    book.Display();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
