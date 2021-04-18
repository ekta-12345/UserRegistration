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
            string[] name = new string[num + 1];

            Console.WriteLine("Welcome to USER REgistration");

            Console.WriteLine("Enter your Name: ");
            name[num] = Console.ReadLine();
            ValidName(name, pattern);
        }
        public static void ValidName(string[] name, string pattern)
        {
            Console.WriteLine("Validating a Name: ");
            Regex regex = new Regex(pattern);
            for (int i = 0; i < name.Length; i++)
            {
                bool result = regex.IsMatch(name[i]);
                if (result)
                {
                    Console.WriteLine("Valid Name---->" + name[i]);
                }
                else
                {
                    Console.WriteLine("InValid Name---->" + name[i]);
                }
            }

        }
    }
}
