using System;
using System.Text.RegularExpressions;

namespace RegexEx
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC3--Regex
            // abc.xyz@bl.co.in 
            Console.WriteLine("Enter The E mail");
            string name= Console.ReadLine();
            string namepattern = "^[0-9a-zA-Z]+[.-_]{0,2}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-z]{2,3}" +
                "([.][a-zA-Z]{2,3}){0,1}$";
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