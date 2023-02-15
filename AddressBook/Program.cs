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
            Console.WriteLine("Enter any option given below: \n 1.CreateContact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:                 
                    AddressBook book = new AddressBook();
                    book.CreateContact();
                    book.Display();
                    break;
            }
        }
    }
}
