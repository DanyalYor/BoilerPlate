using System;
using System.IO;

namespace BoilerPlate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Please type in a year!");
            string input = Console.ReadLine();
            int inputInt = Int32.Parse(input);

            Console.WriteLine(program.IsLeapYear(inputInt) ? "yay" : "nay");
        }

        public bool IsLeapYear(int year)
        {
            if(year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            } 
            return false;
        }
    }
}
