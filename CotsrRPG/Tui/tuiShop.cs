using System.Drawing;
using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class tuiShop
{
    
    public string userInput;
    
    public void ShowWeapons(Shop shop)
   {
       Console.WriteLine("Weapons:");
       
         foreach (var weapon in shop.Weapons)
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

   public void ShowFood(Shop shop)
   {
       Console.WriteLine("Food:");
       
       foreach (var food in shop.Food)
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

   public void setupShop()
   {
       var shop = Shop.Instance;
       
       var tuiShop = new tuiShop();
       tuiShop.ShowShop(shop);
        
        
   }
   
   public void ShowShop(Shop shop)
   {
      
       var gamedata = GameData.GetInstance();
       
       
       Console.ForegroundColor = ConsoleColor.Yellow;
       Console.WriteLine("Gold: " + gamedata.gameDataPlayer.Gold);
       Console.ResetColor();
     
       
       ShowWeapons(shop);
       ShowFood(shop);
       
         Console.WriteLine("Write the name of the item you want to buy, or type exit to exit the shop");
         
         userInput = Console.ReadLine();
         
    
         var buyAndSell = new BuyAndSell();
         
         switch (userInput)
         {
             case "Rusty Sword":
                 
                    buyAndSell.buy("Rusty Sword");
                    
                 
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                 break;
             case "Rusty Mace":
                 
                 buyAndSell.buy("Rusty Mace");
                 
           
                    
                 Thread.Sleep(2000);
                    
                 Console.Clear();
                    
                 ShowShop(shop);
                 
                 
                 break;
             case "Rusty Axe":
         
                 buyAndSell.buy("Rusty Axe");
                 
                    
                 
                    Thread.Sleep(2000);
                 
                    Console.Clear();
                 
                    ShowShop(shop);
              
                 break;
             case "Fine Sword":
        
                 buyAndSell.buy("Fine Sword");
                 
                 
                    
                 Thread.Sleep(2000);
                    
                 Console.Clear();
                    
                 ShowShop(shop);
         
                 break;
             case "Fine Mace":
                
                 buyAndSell.buy("Fine Mace");
                 
                
                    Thread.Sleep(2000);
                 
                    Console.Clear();
                 
                    ShowShop(shop);
                 
                 
                 break;
                case "Fine Axe":
                    
                    buyAndSell.buy("Fine Axe");
                    
                    
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    break;
                case "Apple":
                    
                    buyAndSell.buy("Apple");
                    
                 
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    break;
                case "Bread":
                    
                    buyAndSell.buy("Bread");
                    
               
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    
                    break;
                case "Cheese":
                    
                    buyAndSell.buy("Cheese");
                    
          
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    break;
                case "Ham":
                    
                    buyAndSell.buy("Ham");
                    
              
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    
                    
                    break;
                case "Steak":
                    
                    buyAndSell.buy("Steak");
                    
       
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    break;
                case "Fish":
                    
                    buyAndSell.buy("Fish");
                    
                   
                    
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    
                    ShowShop(shop);
                    
                    break;
                case "exit":
                    
                    Console.Clear();
                    
                    
                    var tuiGameMenu = new GameMenu();
                    tuiGameMenu.initializeGameMenu(false);
                    
                    break;
             default:
                 Console.WriteLine("Wrong input!");
                 Console.WriteLine("Try Again!");
                 
                 Thread.Sleep(2000);
                 
                 Console.Clear();

                 ShowShop(shop);
                 
                 break;
         }
         
         
         
        
         
         
         
         
   }
}