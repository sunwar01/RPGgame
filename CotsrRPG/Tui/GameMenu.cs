using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class GameMenu
{

    
    public string userInput;
    
    public tuiShop tuiShop = new tuiShop();
    
    public void wrongInputIntro()
    {
       
            Console.WriteLine("Wrong number u idiot. I will help you!");
            
            Thread.Sleep(2000);
            
            Console.Clear();
            
            tuiShop.setupShop();
                    
        
        
    }
    
    
    
    public void initializeGameMenu(bool isIntro)
    {
        
       

        if (isIntro)
        {
            
            Console.WriteLine("Welcome to the game menu!");
            Console.WriteLine("Here you can chose between different actions");
            Console.WriteLine("Your first task is to buy a weapon and some food, it is probably your only task, because i am to lazy :)");
            Console.WriteLine("Write (2) in the console, to enter the shop!");
        }
        
        Console.WriteLine("1. Travel");
        if (isIntro)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. Shop");
            Console.ResetColor();
        }else
            Console.WriteLine("2. Shop");
        
        Console.WriteLine("3. Blacksmith");
        Console.WriteLine("4. Inventory");
        Console.WriteLine("5. Exit and save game");
        
        
        userInput = Console.ReadLine();
      
        switch (userInput)
        {
            case "1":
                if (isIntro)
                {
                    wrongInputIntro();
                    
                }
                
                // Travel
                
                break;
            case "2":
                Console.Clear();
                
                
                tuiShop.setupShop();
                
                break;
            case "3":
                if (isIntro)
                {
                    wrongInputIntro();
                    
                }
              
                // Blacksmith
                break;
            case "4":
                if (isIntro)
                {
                    wrongInputIntro();
                    
                }
                
                var inventory = new tuiInventory();
                inventory.showInventory();
                
                // Inventory
                break;
            case "5":
                if (isIntro)
                {
                    wrongInputIntro();
                    
                }
               
                // Exit and save game
                break;
            default:
                if (isIntro)
                {
                    wrongInputIntro();
                    
                }
                else
                {
                    initializeGameMenu(false);
                }
                
                break;
        }
        
        
        
        
        
    }
    
  
}