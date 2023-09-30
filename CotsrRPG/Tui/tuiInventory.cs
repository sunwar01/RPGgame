using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class tuiInventory
{
 public GameData gamedata = GameData.GetInstance();
    
 
    public void showInventory()
    {
        ShowWeapons();
        ShowFood();
        
        Console.WriteLine("If you want to Consume food, write 'consume'");
        Console.WriteLine("If you want to equip a weapon, write 'equip'");
        Console.WriteLine("If you want to go back, write 'back'");
        
        var userInput = Console.ReadLine();
        
        
        if (userInput == "consume")
        {
            Console.Clear();
            Console.WriteLine("Write the name of the food you want to consume");
            
            userInput = Console.ReadLine();
            
            var consume = new Consume();
            consume.ConsumeFood(userInput);
            showInventory();
            
        }
        else if (userInput == "equip")
        {
            Console.Clear();
            Console.WriteLine("Write the name of the weapon you want to equip");
            userInput = Console.ReadLine();
            
            var equip = new Equip();
            equip.EquipWeapon(userInput);
            showInventory();
        }
        else if (userInput == "back")
        {
            Console.Clear();
            var gameMenu = new GameMenu();
            gameMenu.initializeGameMenu(false);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wrong input, try again");
            showInventory();
        }
        
    }
    
    
     public void ShowWeapons()
   {
       Console.WriteLine("Weapons:");
       
         foreach (var weapon in gamedata.gameDataInventory.Weapons)
         {
             switch(weapon.Rarity) 
             {
                 case "Common":
                     Console.ForegroundColor = ConsoleColor.Gray;
                     break;
                 case "Uncommon":
                     Console.ForegroundColor = ConsoleColor.Green;
                     break;
                 case "Rare":
                     Console.ForegroundColor = ConsoleColor.Blue;
                     break;
                 case "Epic":
                     Console.ForegroundColor = ConsoleColor.Magenta;
                     break;
                 case "Legendary":
                     Console.ForegroundColor = ConsoleColor.Yellow;
                     break;
                 default:
                     // code block
                     break;
             }
              Console.WriteLine($"Name: {weapon.Name} | Level: {weapon.Level} | Rarity: {weapon.Rarity} | Damage: {weapon.Damage} | Sell Price: {weapon.SellPrice} | Buy Price: {weapon.BuyPrice}");
              Console.ResetColor();
         }
   }

   public void ShowFood()
   {
       Console.WriteLine("Food:");
       
       foreach (var food in gamedata.gameDataInventory.Food)
       {
           
           switch(food.Rarity) 
           {
               case "Common":
                   Console.ForegroundColor = ConsoleColor.Gray;
                   break;
               case "Uncommon":
                   Console.ForegroundColor = ConsoleColor.Green;
                   break;
               case "Rare":
                   Console.ForegroundColor = ConsoleColor.Blue;
                   break;
               case "Epic":
                   Console.ForegroundColor = ConsoleColor.Magenta;
                   break;
               case "Legendary":
                   Console.ForegroundColor = ConsoleColor.Yellow;
                   break;
               default:
                   // code block
                   break;
           }
           
           Console.WriteLine($"Name: {food.Name} | Level: {food.Level} | Rarity: {food.Rarity} | Health: {food.Health} | Sell Price: {food.SellPrice} | Buy Price: {food.BuyPrice}");
           Console.ResetColor();
       }
   }
   
   
    
    
   
}