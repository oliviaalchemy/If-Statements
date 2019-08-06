using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if (isMale && !isTall) {   
                Console.WriteLine("You are a short male");
            } else if (!isMale && isTall) {
                Console.WriteLine("You are not male but you are tall");
            } else
            {
                Console.WriteLine("You are not male and not tall");
            }
                 Console.ReadLine(); //Will execute: You are not male and you are not tall
        }
    }
}
