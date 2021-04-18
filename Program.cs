using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static int Fname = 0;
        static int Lname = 0;
        static void Main(string[] args)
        {

            string pattern = "^[A-Z]{1,}[A-Za-z]{2,}";
            string[] first = new string[Fname + 1];
            string[] last = new string[Lname + 1];


            Console.WriteLine("Welcome to USER REgistration");

            Console.WriteLine("Enter your First Name: ");
            first[Fname] = Console.ReadLine();
            FirstName(first, pattern);

            Console.WriteLine("Enter your Last Name: ");
            last[Lname] = Console.ReadLine();
            LastName(last, pattern);

        }
        public static void FirstName(string[] name, string pattern)
        {
            Console.WriteLine("Validating a Name: ");
            Regex regex = new Regex(pattern);
            for (int i = 0; i < name.Length; i++)
            {
                bool result = regex.IsMatch(name[i]);
                if (result)
                {
                    Console.WriteLine("Valid FIrst Name---->" + name[i]);
                }
                else
                {
                    Console.WriteLine("InValid First Name---->" + name[i]);
                }
            }

        }
        public static void LastName(string[] name, string pattern)
        {
            Console.WriteLine("Validating a Name: ");
            Regex regex = new Regex(pattern);
            for (int i = 0; i < name.Length; i++)
            {
                bool result = regex.IsMatch(name[i]);
                if (result)
                {
                    Console.WriteLine("Valid Last Name---->" + name[i]);
                }
                else
                {
                    Console.WriteLine("InValid Last Name---->" + name[i]);
                }
            }

        }

    }
}

