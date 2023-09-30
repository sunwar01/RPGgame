using CotsrRPG.Tui;

namespace CotsrRPG.Game;

public class Consume
{
    public GameData gamedata = GameData .GetInstance();
    
    public void ConsumeFood(string foodName)
    {
        // Find the food item in the inventory
        var foodItem = gamedata.gameDataInventory.Food.FirstOrDefault(food => food.Name.Equals(foodName, StringComparison.OrdinalIgnoreCase));

        if (foodItem != null)
        {
            Console.WriteLine($"You consumed {foodItem.Name}. Health restored: {foodItem.Health}");
  
            
            if (gamedata.gameDataPlayer.Health + foodItem.Health > 100)
            {
                gamedata.gameDataPlayer.Health = 100;
            }else
            {
                gamedata.gameDataPlayer.Health += foodItem.Health;
            }
            
            gamedata.gameDataInventory.Food.Remove(foodItem);
            
            Thread.Sleep(2000);
            
          
            
        }
        else
        {
            Console.WriteLine($"Food '{foodName}' not found in the inventory.");
            Thread.Sleep(2000);
        }
    }

    
}