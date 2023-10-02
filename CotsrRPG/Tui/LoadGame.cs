using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class LoadGame
{

    public void InitializeLoadGameMenu()
    {
        var gamedata = GameData.GetInstance();

        var saves = gamedata.getAllSaves();
        
        foreach (var save in saves)
        {
            Console.WriteLine(save);
        }
        
        Console.WriteLine("Write the name of the save you want to load");
        
        var userInput = Console.ReadLine();
        
        if(!saves.Contains(userInput))
        {
            Console.WriteLine("Wrong input, try again");
            Thread.Sleep(2000);
            Console.Clear();
            InitializeLoadGameMenu();
        }
        else
        {
            Console.Clear();
            gamedata.loadGame(userInput);
            
        }
        
     
        
        
        
        
        
        
    }
    
    
}