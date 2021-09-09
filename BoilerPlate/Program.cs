using System;
using System.IO;

namespace BoilerPlate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            //Console.WriteLine("Please type in a year!");
            string input = Console.ReadLine();
            int inputInt = 0;

            
            try{
                inputInt = Int32.Parse(input);
            } catch(Exception e){
                Console.WriteLine("The year must be a number!");
                return;
            }
            

            if(inputInt > 1582)
            {
                Console.WriteLine(program.IsLeapYear(inputInt) ? "yay" : "nay");
            } else{
                Console.WriteLine("Your year must be greater than the number 1582!");
            }

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
