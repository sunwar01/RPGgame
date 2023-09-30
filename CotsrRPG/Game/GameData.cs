namespace CotsrRPG.Game;

public class GameData
{
    
    string path = "Saves/";
    private static GameData _gameDataInstance;
    
    
    public Player gameDataPlayer { get; set; }
    public Inventory gameDataInventory { get; set; }

    
    private GameData() { }

    public void createNewGame(string saveGameName, string playerName)
    {
        string saveGame = Path.Combine(path, saveGameName + ".json");
        
        List<Weapon> weapons = new List<Weapon>();
        List<Food> food = new List<Food>();
        
        var newInventory = new Inventory(weapons, food);
        
        var newPlayer = new Player(playerName, 1, 100, 10, 10, 10, 50, 0, 20, null, newInventory);

        
        
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
            
            
            System.Text.Json.JsonSerializer.Serialize(saveGameStream, _gameDataInstance);
        }
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