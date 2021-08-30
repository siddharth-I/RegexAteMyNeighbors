using System;
using System.Text.RegularExpressions;

namespace RegexAteMyNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            static bool NameValidator(String input1)
            {
                Console.WriteLine("Please enter a valid name: ");
                input1 = Console.ReadLine();
                Regex pattern1 = new Regex("[A-Z][a-z]{1,29}");
                if (pattern1.IsMatch(input1) == true)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid!");
                }
                return false;
            }

            static bool EmailValidator(String input2)
            {
                Console.WriteLine("Please enter a valid email: ");
                input2 = Console.ReadLine();
                Regex pattern2 = new Regex("^[A-Za-z]{5,29}@[A-Za-z]{5,9}.[A-Za-z]{2,3}$");
                if (pattern2.IsMatch(input2) == true)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Sorry, email is not valid!");
                }
                return false;
            }

            static bool NumberValidator(String input3)
            {
                Console.WriteLine("Please enter a valid phone number: ");
                input3 = Console.ReadLine();
                Regex pattern3 = new Regex("[(]?{3]?{3}{4}\b");
                if (pattern3.IsMatch(input3) == true)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Sorry, number is not valid!");
                }
                return false;
            }

            static bool DateValidator(String input4)
            {
                Console.WriteLine("Please enter a valid date: ");
                input4 = Console.ReadLine();
                Regex pattern4 = new Regex("[A-Z][a-z]{1,29}");
                if (pattern4.IsMatch(input4) == true)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Sorry, date is not valid!");
                }
                return false;
            }

        }
    }
}
