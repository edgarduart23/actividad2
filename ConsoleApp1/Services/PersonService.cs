using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Services
{
    public class PersonService
    {
        public static void GetPerson(Person person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine();
        }
    }
}
