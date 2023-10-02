namespace CotsrRPG.Tui;

public class tuiFight
{

    public void InitializeFightMenu()
    {
        
        Console.WriteLine("1. Everwood Training");
        Console.WriteLine("2. Everwood Forest");
        
        var userInput = Console.ReadLine();
        
        switch (userInput)
        {
            case "1":
                Console.Clear();
                var level = new Level();
                level.Everwood_training();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("Not implemented yet");
                Thread.Sleep(2000);
                Console.Clear();
                InitializeFightMenu();
                break;
            default:
                Console.WriteLine("Wrong input, try again");
                Thread.Sleep(2000);
                Console.Clear();
                InitializeFightMenu();
                break;
        }
        
        
        
    }
    
    
}