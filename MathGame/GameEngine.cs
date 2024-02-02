using MathGame.Models;

namespace MathGame;

public class GameEngine
{
    public GameEngine()
    {
        
    }

    internal void Addition()
    {
        Console.Clear();
        var random = new Random();
        var firstNumber = 0;
        var secondNumber = 0;
        bool isValid;
        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
        var difficulty = Console.ReadLine()?.ToUpper();
        
        var score = 0;
        var i = 1;

        while (i <= 5)
        {
            Console.Clear();

            do
            {
                switch (difficulty)
                {
                    case "E":
                        firstNumber = random.Next(1, 10);
                        secondNumber = random.Next(1, 10);
                        isValid = true;
                        break;
                    case "M":
                        firstNumber = random.Next(10, 100);
                        secondNumber = random.Next(18, 188);
                        isValid = true;
                        break;
                    case "H":
                        firstNumber = random.Next(100, 1000);
                        secondNumber = random.Next(100, 1000);
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
                        difficulty = Console.ReadLine()?.ToUpper();
                        isValid = false;
                        break;
                }
            } while (!isValid);

            Console.WriteLine($"Addition Game ({i}/5)");


            Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
            var result = (Console.ReadLine());

            result = Helpers.ValidateInput(result);


            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect. Type any key for the next question");
                Console.ReadLine();
            }


            if (i == 5)
            {
                Console.WriteLine(
                    $"Game over! Your final score is: {score}/5. Press any key to return to the main menu. ");
                Console.ReadLine();
            }

            i++;
        }

        Helpers.AddScore(score, GameType.Addition,Helpers.GetDifficultyEnum(difficulty) );
    }

    internal void Subtraction()
    {
         Console.Clear();
        var random = new Random();
        var firstNumber = 0;
        var secondNumber = 0;
        bool isValid;
        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
        var difficulty = Console.ReadLine()?.ToUpper();
        
        var score = 0;
        var i = 1;

        while (i <= 5)
        {
            Console.Clear();
            do
            {
                switch (difficulty)
                {
                    case "E":
                        firstNumber = random.Next(1, 10);
                        secondNumber = random.Next(1, 10);
                        while (secondNumber > firstNumber)
                        {
                            firstNumber = random.Next(1, 10);
                            secondNumber = random.Next(1, 10);
                        }
                        isValid = true;
                        break;
                    case "M":
                        firstNumber = random.Next(10, 100);
                        secondNumber = random.Next(10, 50);
                        while (secondNumber > firstNumber)
                        {
                            firstNumber = random.Next(10, 100);
                            secondNumber = random.Next(10, 50);
                        }
                        isValid = true;
                        break;
                    case "H":
                        firstNumber = random.Next(100, 1000);
                        secondNumber = random.Next(11, 300);
                        while (secondNumber > firstNumber)
                        {
                            firstNumber = random.Next(100, 1000);
                            secondNumber = random.Next(11, 300);
                        }
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
                        difficulty = Console.ReadLine()?.ToUpper();
                        isValid = false;
                        break;
                }
            } while (!isValid);

            Console.WriteLine($"Subtraction Game ({i}/5)");


            Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
            var result = (Console.ReadLine());

            result = Helpers.ValidateInput(result);


            if (int.Parse(result) == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect. Type any key for the next question");
                Console.ReadLine();
            }


            if (i == 5)
            {
                Console.WriteLine(
                    $"Game over! Your final score is: {score}/5. Press any key to return to the main menu. ");
                Console.ReadLine();
            }

            i++;
        }

        Helpers.AddScore(score, GameType.Subtraction,Helpers.GetDifficultyEnum(difficulty) );
    }

    internal void Multiplication()
    {
         Console.Clear();
        var random = new Random();
        var firstNumber = 0;
        var secondNumber = 0;
        bool isValid;
        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
        var difficulty = Console.ReadLine()?.ToUpper();
        
        var score = 0;
        var i = 1;

        while (i <= 5)
        {
            Console.Clear();

            do
            {
                switch (difficulty)
                {
                    case "E":
                        firstNumber = random.Next(1, 10);
                        secondNumber = random.Next(1, 10);
                        isValid = true;
                        break;
                    case "M":
                        firstNumber = random.Next(10, 100);
                        secondNumber = random.Next(18, 188);
                        isValid = true;
                        break;
                    case "H":
                        firstNumber = random.Next(100, 1000);
                        secondNumber = random.Next(100, 1000);
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
                        difficulty = Console.ReadLine()?.ToUpper();
                        isValid = false;
                        break;
                }
            } while (!isValid);

            Console.WriteLine($"Multiplication Game ({i}/5)");


            Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
            var result = (Console.ReadLine());

            result = Helpers.ValidateInput(result);


            if (int.Parse(result) == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect. Type any key for the next question");
                Console.ReadLine();
            }


            if (i == 5)
            {
                Console.WriteLine(
                    $"Game over! Your final score is: {score}/5. Press any key to return to the main menu. ");
                Console.ReadLine();
            }

            i++;
        }

        Helpers.AddScore(score, GameType.Multiplication,Helpers.GetDifficultyEnum(difficulty) );
    }

    internal void Division()
    {
          Console.Clear();
        var random = new Random();
        var firstNumber = 1;
        var secondNumber = 2;
        bool isValid;
        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
        var difficulty = Console.ReadLine()?.ToUpper();
        
        var score = 0;
        var i = 1;

        while (i <= 5)
        {
            Console.Clear();

            do
            {
                switch (difficulty)
                {
                    case "E":
                        firstNumber = random.Next(2, 11);
                        secondNumber = random.Next(2, 11);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(2, 11);
                            secondNumber = random.Next(2, 11);
                        }
                        isValid = true;
                        break;
                    case "M":
                        firstNumber = random.Next(10, 101);
                        secondNumber = random.Next(1, 11);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(10, 101);
                            secondNumber = random.Next(10, 11);
                        }
                        isValid = true;
                        break;
                    case "H":
                        firstNumber = random.Next(100, 1001);
                        secondNumber = random.Next(10, 101);
                        while (firstNumber % secondNumber != 0)
                        {
                            firstNumber = random.Next(100, 1001);
                            secondNumber = random.Next(10, 101);
                        }
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        Console.WriteLine("Choose the difficulty level.\nEasy(E) Medium(M) Hard(H)");
                        difficulty = Console.ReadLine()?.ToUpper();
                        isValid = false;
                        break;
                }
            } while (!isValid);

            Console.WriteLine($"Division Game ({i}/5)");


            Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
            var result = (Console.ReadLine());

            result = Helpers.ValidateInput(result);


            if (int.Parse(result) == firstNumber / secondNumber)
            {
                Console.WriteLine("Correct! Type any key for the next question.");
                score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Incorrect. Type any key for the next question");
                Console.ReadLine();
            }


            if (i == 5)
            {
                Console.WriteLine(
                    $"Game over! Your final score is: {score}/5. Press any key to return to the main menu. ");
                Console.ReadLine();
            }

            i++;
        }

        Helpers.AddScore(score, GameType.Division,Helpers.GetDifficultyEnum(difficulty) );
    }
}