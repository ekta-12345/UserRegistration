using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static int num = 0;
        static void Main(string[] args)
        {

            string pattern = "^[A-Z]{1,}[A-Za-z]{2,}";
            string Epattern = "^[abc]*[@a-zA-Z].[com]*";
            string[] first = new string[num + 1];
            string[] last = new string[num + 1];
            string[] email = new string[num + 1];

            Console.WriteLine("Welcome to USER REgistration");

            Console.WriteLine("Enter your First Name: ");
            first[num] = Console.ReadLine();
            FirstName(first, pattern);

            Console.WriteLine("Enter your Last Name: ");
            last[num] = Console.ReadLine();
            LastName(last, pattern);

            Console.WriteLine("Enter your Email: ");
            email[num] = Console.ReadLine();
            Email(email, Epattern);
        }
        public static void FirstName(string[] name, string pattern)
        {
            IterateLoop(name, pattern);
        }
        public static void LastName(string[] name, string pattern)
        {
            IterateLoop(name, pattern);
        }
        public static void Email(string[] name, string pattern)
        {
            IterateLoop(name, pattern);
        }

        public static void IterateLoop(string[] name, string pattern)
        {
            Console.WriteLine("Validating a Name: ");
            Regex regex = new Regex(pattern);
            for (int i = 0; i < name.Length; i++)
            {
                bool result = regex.IsMatch(name[i]);
                if (result)
                {
                    Console.WriteLine("Valid---->" + name[i]);
                }
                else
                {
                    Console.WriteLine("InValid---->" + name[i]);
                }
            }
        }

    }
}

