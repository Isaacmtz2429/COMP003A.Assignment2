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
            string userName;
            int userAge;
            double productPrice;
            bool isStudent;

            Console.Write("What is your first name: ");
            userName = Console.ReadLine();

            Console.Write("What is your last name: ");
            userName += Console.ReadLine();

            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interest in? ");
            productPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true or false): ");
            isStudent = bool.Parse(Console.ReadLine());



        }
    }
}
