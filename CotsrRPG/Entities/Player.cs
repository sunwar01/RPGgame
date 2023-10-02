using System.Text.Json.Serialization;

namespace CotsrRPG;

public class Player
{
    public string Name { get; set; }
    
    public int Level { get; set; }
    
    public int Health { get; set; }
    
    public int Damage { get; set; }
    
    public int CriticalChance { get; set; }
    
    public int CriticalDamage { get; set; }
    
    public int Accuracy { get; set; }
    
    public int Experience { get; set; }
    
    public int Gold { get; set; }
    
    [JsonIgnore]
    public Inventory Inventory;
    
    [JsonConstructor]
    public Player(string name, int level, int health, int damage, int criticalChance, int criticalDamage, int accuracy, int experience, int gold/* Inventory inventory*/)
    {
        this.Name = name;
        this.Level = level; 
        this.Health = health;
        this.Damage = damage;
        this.CriticalChance = criticalChance;
        this.CriticalDamage = criticalDamage;
        this.Accuracy = accuracy;
        this.Experience = experience;
        this.Gold = gold;
      //  this.Inventory = inventory;
    }
    

    

  





}