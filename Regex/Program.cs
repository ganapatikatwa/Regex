using System;
using System.Text.RegularExpressions;

namespace RegexEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC7--Regex
            Console.WriteLine("Enter The Password");
            string name= Console.ReadLine();
            string namepattern = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
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