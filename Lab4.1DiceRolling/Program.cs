using System;

namespace Lab4._1DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus Casino!");
            Console.WriteLine("How many sides should each die have ? ");
            string numSides = Console.ReadLine();
            int sides;

            bool integer = int.TryParse(numSides, out sides);

            bool keepPlaying = true;

            int rollCount = 1;
            do
            {

                int num1 = RandomNumber(sides);
                int num2 = RandomNumber(sides);
               // DiceCombinations();
                Console.WriteLine($"Roll {rollCount}:");
                Console.WriteLine($"You rolled a {num1} and a {num2} ({num1 + num2} total)");
               

                rollCount++;
                DiceCombinations(num1, num2);
                TotalDiceCombinations(num1, num2);
                Console.WriteLine("Roll again?");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("y"))
                {
                   // DiceCombinations();
                    keepPlaying = true;


                }
                else if (userInput.Equals("n"))
                {

                    Console.WriteLine("Thanks for Playing!");
                   keepPlaying = false;

                }
                else
                {

                    Console.WriteLine("Please enter a valid input");
                    continue;
                }

            } while (keepPlaying);

        }


        static int RandomNumber(int x)
        {

            //The number of sides the user can select. There is not a max in this case. 
            Random random = new Random();
            int randomNumber = random.Next(1, x + 1);
          
            return randomNumber;

        }


        static void  DiceCombinations(int num1, int num2)
        {

           

            if(num1 == 1 && num2 == 1)
            {

                Console.WriteLine("Snake Eyes");
            }
            else if (num1 == 1 && num2 == 2)
            {

                Console.WriteLine("Ace Deuce");
            }  
            
            else if(num1 ==6 && num2 ==6)
            {

                Console.WriteLine("Box Cars");
            }
         
         
         
        }

       static void TotalDiceCombinations(int num1, int num2)
       {
            int total = num1 + num2;


            if (total == 7 || total == 11)
            {

                Console.WriteLine("Win!");
            }
            else if (total == 2 || total == 3 || total == 12)
            {

                Console.WriteLine("Craps");
            }
       }


        


    }
}
