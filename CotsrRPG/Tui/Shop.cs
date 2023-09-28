using System.Drawing;

namespace CotsrRPG.Tui;

public class Shop
{
    public void ShowWeapons(CotsrRPG.Shop shop)
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

   public void ShowFood(CotsrRPG.Shop shop)
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

   public void ShowShop(CotsrRPG.Shop shop)
   {
       ShowWeapons(shop);
       ShowFood(shop);
   }
}