using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerScore = 0;
            int userScore = 0;
            startGame(userScore, computerScore);

        }

        public static void startGame(int userScore, int computerScore)
        {
            Random randomNumber = new Random();
            int randNum = randomNumber.Next(1, 4);
            string computerChoice = RockPaperScissorsChooser(randNum);
            Console.WriteLine("Rock, Paper, Scissors, Shoot!");
            string userChoice = Console.ReadLine();
            RockPaperScissorsComparer(userChoice, computerChoice, userScore, computerScore);
        }

        public static void RockPaperScissorsComparer(string userChoice, string computerChoice, int userScore, int computerScore)
        {
            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a draw! You both chose " + userChoice);
                Console.ReadLine();
                startGame(userScore, computerScore);
            }

            switch (userChoice.ToLower())
            {
                case "rock":
                    if (computerChoice == "paper")
                    {
                        computerScore++;
                        Console.WriteLine("You chose rock and the computer chose paper. You lose this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);
                    }
                    else if (computerChoice == "scissors")
                    {
                        userScore++;
                        Console.WriteLine("You chose rock and the computer chose scissors. You win this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);
                    }
                    break;
                case "paper":
                    if (computerChoice == "rock")
                    {
                        userScore++;
                        Console.WriteLine("You chose paper and the computer chose rock. You win this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);

                    }
                    else if (computerChoice == "scissors")
                    {
                        computerScore++;
                        Console.WriteLine("You chose paper and the computer chose scissors. You lose this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);
                    }
                    break;
                case "scissors":
                    if (computerChoice == "rock")
                    {
                        computerScore++;
                        Console.WriteLine("You chose scissors and the computer chose rock. You lose this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);

                    }
                    else if (computerChoice == "paper")
                    {
                        userScore++;
                        Console.WriteLine("You chose scissors and the computer chose paper. You win this round! Your score is " + userScore + " and the computer's score is " + computerScore);
                        Console.ReadLine();
                        startGame(userScore, computerScore);
                    }
                    break;
                default:
                    Console.WriteLine("Unknown, try again");
                    startGame(userScore, computerScore);
                    break;
            }
        }

        public static string RockPaperScissorsChooser(int choice)
        {
            string answer = "";
            if (choice == 1)
            {
                answer = "rock";
            }

            if (choice == 2)
            {
                answer = "scissors";
            }

            if (choice == 3)
            {
                answer = "paper";
            }

            return answer;
        }
    }
}
