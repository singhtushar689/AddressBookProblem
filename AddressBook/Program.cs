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
            AddressBook book = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter any option given below: \n 1.CreateContact \n 2.Edit Contact" +
                    " \n 3.DeleteContact \n Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        book.CreateContact();
                        book.Display();
                        break;
                    case 2:
                        book.EditContact("Tushar");
                        book.Display();
                        break;
                    case 3:
                        book.DeleteContact();
                        break;
                    case 4:
                        book.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
