namespace CotsrRPG.Tui;





public class MainMenu
{
   public string userInput;

   public void initializeMainMenu()
   {
      
      
      Console.WriteLine("Welcome to CotsrRPG!");
      
      Console.WriteLine("1. Start a new game");
      Console.WriteLine("2. Load a game");
      Console.WriteLine("3. Exit the game");
      
      
      
      userInput = Console.ReadLine();
      
      switch (userInput)
      {
         case "1":
            Console.Clear();
            NewGame newGame = new NewGame();
            newGame.initializeNewGameMenu();
            break;
         case "2":
            // list all json files in saves folder
            // start game with chosen save
            Console.Clear();
            break;
         case "3":
            // Do nothing, should close if in a loop :))))
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