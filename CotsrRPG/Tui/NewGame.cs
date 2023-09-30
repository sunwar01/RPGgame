using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class NewGame
{
    
    public string userInput;

    public void initializeNewGameMenu()
    {


        string saveName;
        string playerName; 
        
      
        
      
        Console.WriteLine("Write name of the new game");
        
        userInput = Console.ReadLine();
        
        saveName = userInput;
        
        Console.Clear();
        
        Console.WriteLine("Write name of the player");

        userInput = Console.ReadLine();
        
        playerName = userInput;
        
        var gamedata = GameData.GetInstance();
        
         gamedata.createNewGame(saveName, playerName);

         Console.Clear();
        
       
         var newGameIntro = new NewGameIntro();
         
         newGameIntro.initializeNewGameIntro();
         
         
      

    }
    
}