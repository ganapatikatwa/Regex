using System;
using System.Text.RegularExpressions;

namespace RegexEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1--Regex
            Console.WriteLine("Enter The Mobie");
            string name= Console.ReadLine();
            string namepattern = "^[A-Z]{1}[a-z]{2,}[ ][A-Z]{1}[a-z]{2,}";
            Regex regex = new Regex(namepattern);
            if(regex.IsMatch(name))
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("InValid");
                Console.ResetColor();
            }
        }
    }
}