namespace CotsrRPG;

public class Item
{
    public string Name { get; set; }
    
    public int Level { get; set; }
    
    public string Rarity { get; set; }
    
    public Item(string name, int level, string rarity)
    {
        this.Name = name;
        this.Level = level;
        this.Rarity = rarity;
    }
}