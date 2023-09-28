namespace CotsrRPG.Tui;

public class NewGame
{
    
    public string userInput;

    public void initializeNewGameMenu()
    {


        string saveName;
        string playerName; 
        
        List<Weapon> weapons = new List<Weapon>();
        List<Food> food = new List<Food>();
        
      
        Console.WriteLine("Write name of the new game");
        
        userInput = Console.ReadLine();
        
        saveName = userInput;
        
        Console.Clear();
        
        Console.WriteLine("Write name of the player");

        userInput = Console.ReadLine();
        
        playerName = userInput;

        var newInventory = new Inventory(weapons, food);
        
        var newPlayer = new Player(playerName, 1, 100, 10, 10, 10, 50, 0, 10, null, newInventory);

        var json = new Json.Json();
        
          json.createNewGame(saveName, newPlayer, newInventory);

         Console.Clear();
        
       
         var newGameIntro = new NewGameIntro();
         
         newGameIntro.initializeNewGameIntro();
         
         
      

    }
    
}