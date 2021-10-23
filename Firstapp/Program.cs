using System;
// Name Space
namespace Firstapp
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo();
            GreetUser();

            //Set Correct Number
            //int correctNum = 7;

            while (true ) { 
                    //create a random object
                    Random random = new Random();


                    //Set Correct Number
                    int correctNum = random.Next(1, 10);


                    //Int guess var
                    int guess = 0;

                    //ask user for number
                    Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNum)
                {
                    //Get user's input
                    string user_input = Console.ReadLine();

                            //Make sure its a number
                            if (!int.TryParse(user_input, out guess))
                            {
                             PrintColorMessage(ConsoleColor.Red, "Input is not a number");

                                //Keep going
                        continue;
                            }




                                //Cast to int and put in the guess variable
                                guess = Int32.Parse(user_input);

                                //match guess to the correct number
                                if (guess != correctNum)
                                {

                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");
                        

                                }

                                else
                                {

                        PrintColorMessage(ConsoleColor.Green, "You are correct");

                                }                   


                }

                //ask user to play again

                Console.WriteLine("Play Again? [ Y or N ]");

                //Get answer

                string ans = Console.ReadLine().ToUpper();

                if (ans == "Y")
                {
                    continue;
                }
                else if (ans == "N")
                {

                }
                else
                {
                    return;
                }


            }

        }

        static void GetAppInfo ()
        {
            // Start here
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brenda K";

            //Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Colour
            Console.ResetColor();


        }
        //greet user function
        static void GreetUser()
        {
            //Ask User's name 
            Console.WriteLine("What is your name ?");

            //Get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game....", input);
        }


        static void PrintColorMessage(ConsoleColor color, string msg)
        {
            //Change text colour
            Console.ForegroundColor = color;

            //Check if user's input is a number
            Console.WriteLine(msg);

            //Reset Text Colour
            Console.ResetColor();


        }


    }
}
