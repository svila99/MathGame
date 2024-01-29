using System.Security.Cryptography;
using MathGame.Models;

namespace MathGame;

public class GameEngine
{
    public GameEngine()
    {
    }

    internal void Addition()
    {
        var score = 0;
        var i = 1;
        while (i <= 5)
        {
            Console.Clear();
            Console.WriteLine($"Addition Game ({i}/5)");
            var random = new Random();
            var firstNumber = random.Next(1, 99);
            var secondNumber = random.Next(1, 99);
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

        Helpers.AddScore(score, GameType.Addition);
    }

    internal void Subtraction()
    {
        var score = 0;
        var i = 1;
        while (i <= 5)
        {
            Console.Clear();
            Console.WriteLine($"Subtraction Game ({i}/5) ");
            var random = new Random();
            var firstNumber = random.Next(1, 10);
            var secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} - {secondNumber} = ?");

            var result = (Console.ReadLine());
            result = Helpers.ValidateInput(result);
            if (result != null && int.Parse(result) == firstNumber - secondNumber)
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

        Helpers.AddScore(score, GameType.Subtraction); //Adds Score to the Game List
    }

    internal void Multiplication()
    {
        var score = 0;
        var i = 1;
        while (i <= 5)
        {
            Console.Clear();
            Console.WriteLine($"Multiplication Game ({i}/5)");
            var random = new Random();
            var firstNumber = random.Next(1, 10);
            var secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
            var result = (Console.ReadLine());
            result = Helpers.ValidateInput(result);

            if (result != null && int.Parse(result) == firstNumber * secondNumber)
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

        Helpers.AddScore(score, GameType.Multiplication);
    }

    internal void Division()
    {
        var score = 0;
        var i = 1;
        while (i <= 5)
        {
            Console.Clear();
            Console.WriteLine($"Division Game ({i}/5)");
            var random = new Random();
            var firstNumber = random.Next(1, 100);
            var secondNumber = random.Next(1, 100);
            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, 100);
                secondNumber = random.Next(1, 100);
            }


            Console.WriteLine($"{firstNumber} / {secondNumber} = ?");
            var result = (Console.ReadLine());
            result = Helpers.ValidateInput(result);
            if (result != null && int.Parse(result) == firstNumber / secondNumber)
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

        Helpers.AddScore(score, GameType.Division);
    }
}