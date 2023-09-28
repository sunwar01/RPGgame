using CotsrRPG.Game;

namespace CotsrRPG.Json;

public class Json
{

    string path = "Saves/";
    
    
    public void createNewGame(string name, Player newPlayer, Inventory newInventory)
    {
        
        
        
        string saveGame = Path.Combine(path, name + ".json");
        
        if (File.Exists(saveGame))
        {
            //This check does not work for some reason
            Console.WriteLine("Save game already exists");
        }
        else
        {
            using FileStream saveGameStream = File.Create(saveGame);
            
            // So that we save different stuff in the same file? 
            GameData gameData = new GameData
            {
                gameDataPlayer = newPlayer,
                gameDataInventory = newInventory
            };
            
            System.Text.Json.JsonSerializer.Serialize(saveGameStream, gameData);



        }
        
        
        
        
    }
    
    public void loadGame()
    {
        
        
     
        
        
        
        
    }
    
    public void saveGame()
    {
        
        
        
        
    }
    
    
}