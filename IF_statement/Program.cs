using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string firstName;
            string lastName;
            int yearOfBirth;

            Console.WriteLine("What is your first name?");
            firstName= Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName=Console.ReadLine();

            Console.WriteLine("Enter your birth of year?");
            yearOfBirth = int.Parse(Console.ReadLine());

          

            Console.WriteLine($"Hello, {firstName} {lastName}, your birth of year is {yearOfBirth}");
            Console.WriteLine($"You are {2019 - yearOfBirth} years old");

            Console.ReadLine();*/

            /*Start:
            int userNumber;
            Console.WriteLine("Enter number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber < 5)
            {
                Console.WriteLine($"{userNumber} is less than 5.");
            }

            else if (userNumber > 5)
            {
                Console.WriteLine($"{userNumber} is greater than 5");
            }
            else if (userNumber == 5)
            {
                Console.WriteLine($"{userNumber} equels 5.");
            }
        
            }    

            goto Start;
            Console.ReadLine();*/

            //Start:
            int userNumber;
            Console.WriteLine("Enter number from 1 to 10");
            userNumber = Int32.Parse(Console.ReadLine());

            if (userNumber >= 1 && userNumber <= 10)
            {
                if (userNumber < 5)
                {
                    Console.WriteLine($"{userNumber} is less than 5.");
                }
                else if (userNumber > 5)
                {
                    Console.WriteLine($"{userNumber} is greater than 5.");
                }
                else
                {
                    Console.WriteLine($"{userNumber} equels 5.");

                }         
                
            }
            else
            {

                    Console.WriteLine("Try again!");
                Console.ReadLine();
            }
            

            //goto Start;
            //Console.ReadLine();
        } 
    }
}
