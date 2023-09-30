namespace CotsrRPG.Game;

public class BuyAndSell
{
    public void buy(string name)
    {
        
        var gamedata = GameData.GetInstance();
        
        var player = gamedata.gameDataPlayer;
        var inventory = gamedata.gameDataInventory;
        
        var shop = Shop.Instance;
        
        
        var item = shop.Weapons.Find(x => x.Name == name);
        var item2 = shop.Food.Find(x => x.Name == name);
        
        if (item != null)
        {
            if (player.Gold >= item.BuyPrice)
            {
                player.Gold -= item.BuyPrice;
                inventory.Weapons.Add(item);
               
            }
            else
            {
                Console.WriteLine("You don't have enough gold!");
            }
        }
        else if (item2 != null)
        {
            if (player.Gold >= item2.BuyPrice)
            {
                player.Gold -= item2.BuyPrice;
                inventory.Food.Add(item2);
             
            }
            else
            {
                Console.WriteLine("You don't have enough gold!");
            }
        }
        else
        {
            Console.WriteLine("Item not found!");
        }
        
        
        
    }
}