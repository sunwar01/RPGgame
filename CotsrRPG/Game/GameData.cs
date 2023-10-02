using System.Text.Json;
using System.Text.Json.Serialization;
using CotsrRPG.Tui;

namespace CotsrRPG.Game;

public class GameData
{
    
    string path = "Saves/";
    private static GameData _gameDataInstance;
    
    
    
    public Player gameDataPlayer { get; set; }
    public Inventory gameDataInventory { get; set; }
    
    public string gameDataSaveName { get; set; }


 

    public void createNewGame(string saveGameName, string playerName)
    {
        string saveGame = Path.Combine(path, saveGameName + ".json");
        
        List<Weapon> weapons = new List<Weapon>();
        List<Food> food = new List<Food>();
        
        var newInventory = new Inventory(weapons, food);
        
        var newPlayer = new Player(playerName, 1, 100, 10, 10, 10, 50, 0, 20/*,  newInventory*/);

        
        
        if (File.Exists(saveGame))
        {
            //This check does not work for some reason
            Console.WriteLine("Save game already exists");
        }
        else
        {
            using FileStream saveGameStream = File.Create(saveGame);
            
            _gameDataInstance.gameDataPlayer = newPlayer;
            _gameDataInstance.gameDataInventory = newInventory;
            _gameDataInstance.gameDataSaveName = saveGameName;
            
            
            System.Text.Json.JsonSerializer.Serialize(saveGameStream, _gameDataInstance);
        }
    }
    
    public void saveGame()
    {
        
        
        string saveGame = Path.Combine(path, gameDataSaveName + ".json");
        
        Console.WriteLine(gameDataSaveName);
        
        Thread.Sleep(2000);
        
        if (File.Exists(saveGame))
        {
            Console.WriteLine("Game saved!");
            Thread.Sleep(2000);
            
            
            using FileStream saveGameStream = File.Create(saveGame);
            System.Text.Json.JsonSerializer.Serialize<GameData>(saveGameStream, _gameDataInstance);
           
        }
        else
        {
            Console.WriteLine("Save game does not exist");
            Thread.Sleep(2000);
        }
        
        
    }
    
    
    public void loadGame(string userinput)
    {
        
        
        
      
        
        string saveGame = Path.Combine(path, userinput + ".json");
        
        if (File.Exists(saveGame))
        {
            using FileStream saveGameStream = File.OpenRead(saveGame);
            
            
            // Ville have at player objektet havde en inventory under sig, men det skabte en masse problemer med at deserialize, så det er blevet fjernet
            // Nok ikke helt optimalt xD
            
            
            
            _gameDataInstance = System.Text.Json.JsonSerializer.Deserialize<GameData>(saveGameStream);
            
            
            
            
            
            Console.WriteLine("Game loaded!");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("Save game does not exist");
            Thread.Sleep(2000);
        }
        
        GameMenu gameMenu = new GameMenu();
        gameMenu.initializeGameMenu(false);
        
    
    }

    public List<String> getAllSaves()
    {
        
        string[] savesPath = Directory.GetFiles(path, "*.json");
        
        var saves = new List<string>();
        
        foreach (var save in savesPath)
        {
            saves.Add(Path.GetFileNameWithoutExtension(save));
        }

        return saves;


    }
    
    public static GameData GetInstance()
    {
        if (_gameDataInstance == null)
        {
            _gameDataInstance = new GameData();
        }
        return _gameDataInstance;
    }
 
    
}