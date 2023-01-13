using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookContact
{
    public class Person
    {
        public void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip code");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();


        }
    }
}
