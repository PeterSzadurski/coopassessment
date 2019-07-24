using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheFood {
    class Program {

        static void Main(string[] args) {
            // declare and initialize the variables
            int guessCount = 3;
            Random rnd = new Random();
            int foodIndex;
            bool correct = false;
            string[] foods = new string[5];
            foods[0] = "Pizza";
            foods[1] = "Pasta";
            foods[2] = "Salmon";
            foods[3] = "Steak";
            foods[4] = "Miso";
            foodIndex = rnd.Next(0, 4);

            for (int i = 0; i < foods.Length; i++) {
                Console.WriteLine("- " + foods[i]);
            }
            Console.WriteLine("Please guess a food:");
            while (!correct && guessCount > 0) {
                string typedFood = Console.ReadLine();
                if (typedFood.ToLower() == foods[foodIndex].ToLower()) {
                    // ToLower() used to ignore case
                    correct = true;
                }
                else {
                    guessCount--;
                    Console.WriteLine("Incorrect! You have {0} guesses remaining.", guessCount);
                }
            }

            if (correct) {
                Console.WriteLine("Congratulations! You guessed correctly!");
            }
            else {
                Console.WriteLine("You have run out of guesses, better luck next time.");
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
