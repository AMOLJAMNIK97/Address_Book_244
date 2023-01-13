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
        List<Contact> person = new List<Contact>();
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
            person.Add(contact);


        }
        public void EditContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("To Edit the contact first name");
            string name = Console.ReadLine();
            foreach (var record in person)
            {
                if(record.FirstName == name)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(name +"is exist");
                    Console.ResetColor();
                    Console.WriteLine("To Edit Contact" + "\n1.LastName\n2.Address\n3.City\n4.State\n5.Zip\n6.PhoneNumber\n7.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Last Name");
                            string newLastName = Console.ReadLine();
                            record.LastName = newLastName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Address");
                            string newAddress = Console.ReadLine();
                            record.Address = newAddress;
                            break;
                        case 3:
                            Console.WriteLine("Enter City");
                            string newCity = Console.ReadLine();
                            record.City = newCity;
                            break;
                        case 4:
                            Console.WriteLine("Enter Zip Code");
                            int newZip = Convert.ToInt32(Console.ReadLine());
                            record.Zip = newZip;
                            break;
                        case 5:
                            Console.WriteLine("Enter State");
                            string newState = Console.ReadLine();
                            record.State = newState;
                            break;
                        case 6:
                            Console.WriteLine("Enter PhoneNumber");
                            long newPhoneNumber = Convert.ToInt64(Console.ReadLine());
                            record.PhoneNumber = newPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter Email");
                            string newEmail = Console.ReadLine();
                            record.Email = newEmail;
                            break;
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Name Does not exist");
                    Console.ResetColor();
                }
            }
        }
        public void DeleteContact()
        {

            Console.WriteLine("To Delete Contact From Address Book Enter FirstName Of Person");
            string name = Console.ReadLine();
            foreach(var record in person.ToList())
            {
                if(record.FirstName == name)
                {
                    person.Remove(record);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("person details Delete Succesfully");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Given name Does not Exist in Contact");
                    Console.ResetColor();
                }
            }
        }
    }
}
