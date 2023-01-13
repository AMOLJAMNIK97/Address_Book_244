using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookContact
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.AddContact();
            Console.WriteLine("1.Add Contact\n2.Edit Contact");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option )
            {
                case 1:
                    person.AddContact();
                    break;
                case 2:
                    person.EditContact();
                    break;
            }
        }

    }
}