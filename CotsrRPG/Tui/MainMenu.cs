using CotsrRPG.Game;

namespace CotsrRPG.Tui;





public class MainMenu
{
   public string userInput;

   public GameData gamedata = GameData.GetInstance();
   
   public void initializeMainMenu()
   {
      
      
      Console.WriteLine("Welcome to CotsrRPG!");
      
      Console.WriteLine("1. Start a new game");
      Console.WriteLine("2. Load a game");
    
      
      
      
      userInput = Console.ReadLine();
      
      switch (userInput)
      {
         case "1":
            Console.Clear();
            NewGame newGame = new NewGame();
            newGame.initializeNewGameMenu();
            break;
         case "2":
            Console.Clear();
            LoadGame loadGame = new LoadGame();
            loadGame.InitializeLoadGameMenu();
            Console.Clear();
            break;
         default:
            Console.WriteLine("Wrong input, try again");
            Thread.Sleep(2000);
            
            
            Console.Clear();
            initializeMainMenu();
            break;
      }
       
   }
   
}