namespace MathGame;

public class Menu
{
     private GameEngine _gameEngine = new GameEngine();
    
     internal void ShowMenu(string name)
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Hello {name}. It's {DateTime.Now.DayOfWeek} today. Press enter to start!");
        Console.ReadLine();
        var isGameOn = true;
        do
        {
            Console.Clear();
            Console.WriteLine("""
                              What game would you like to play today? Choose from the following:
                              V - View past scores
                              A - Addition
                              S - Subtraction
                              M - Multiplication
                              D - Division
                              Q - Quit the program
                              """);

            var userChoice = Console.ReadLine()?.ToUpper();
            switch (userChoice?.Trim())
            {
                case "V":
                    Helpers.ViewScores();
                    break;
                case "A":
                    _gameEngine.Addition();
                    break;
                case "S":
                    _gameEngine.Subtraction();
                    break;
                case "M":
                    _gameEngine.Multiplication();
                    break;
                case "D":
                    _gameEngine.Division();
                    break;
                case "Q":
                    Console.WriteLine("Quitting game...");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Input error. Press any key to restart.");
                    Console.ReadLine();
                    break;
            }
        } while (isGameOn);
    }

}