using System;
using System.Text.RegularExpressions;

namespace RegexEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC5--Regex
            Console.WriteLine("Enter The Password");
            string name= Console.ReadLine();
            string namepattern = "^(?=.*[A-Z])[a-zA-Z]{8,}$";
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