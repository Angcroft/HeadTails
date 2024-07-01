using System;

namespace HeadTails {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            string userInput;

            do {
                Console.WriteLine("Flipping the coin...");
                string result = TossCoin(random);
                Console.WriteLine($"The result is: {result}");

                Console.WriteLine("¿Would you want to flip the coing again? (y/n)");
                userInput = Console.ReadLine();

                if(string.IsNullOrEmpty(userInput)) {
                    userInput = "n";    //  In case of null entry
                }

            } while (userInput.ToLower() == "y");

            Console.WriteLine("Thank you for using this program!");
        }

        static string TossCoin(Random number) {
            int toss = number.Next(2);
            return toss == 0 ? "Head" : "Tails";
        }
    }
}