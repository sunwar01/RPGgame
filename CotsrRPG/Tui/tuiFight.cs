namespace CotsrRPG.Tui;

public class tuiFight
{

    public void InitializeFightMenu()
    {
        
        Console.WriteLine("1. Everwood Training");
        Console.WriteLine("2. Everwood Forest");
        
        var userInput = Console.ReadLine();
        
        var level = new Level();
        
        switch (userInput)
        {
            case "1":
                Console.Clear();
                level.Everwood_training();
                break;
            case "2":
                Console.Clear();
                level.Everwood_Forest();
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