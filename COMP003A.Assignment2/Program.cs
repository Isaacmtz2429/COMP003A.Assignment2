//*
// Author: Isaac Martinez
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Discount Calculator//Assignment2

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Information
            string userName;
            string lastName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Welcome to the Discount Calculator");
            Console.WriteLine("**************************************************************");
            Console.Write("What is your first name: ");
            userName = Console.ReadLine();

            Console.Write("What is your last name: ");
            lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interest in? ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true or false): ");
            isStudent = bool.Parse(Console.ReadLine());

            // Calculations
            int futureAge = userAge + 5;
            double StudentDiscount = productPrice * .9;
            double SeniorCitizen = productPrice * .8;



            // Outputs
            Console.WriteLine($"\n**************************************************************");
            Console.WriteLine($"Hello, {userName} {lastName}!");
            Console.WriteLine($"You are currectly {userAge} years old. In 5 years, you will be {futureAge}.");
            Console.WriteLine($"The original price of the item is ${productPrice}");
            Console.WriteLine($"As a student, your discount price is ${StudentDiscount}");
            Console.WriteLine($"As a senior citizen, your discounted price would be ${SeniorCitizen}.");
            Console.WriteLine($"**************************************************************");
        }
    }
}
