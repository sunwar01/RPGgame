namespace CotsrRPG;

public class Weapon : Item
{
public int Damage { get; set; }
    
    public int CriticalChance { get; set; }
    
    public int CriticalDamage { get; set; }
    
    public int Accuracy { get; set; }
    
    public int SellPrice { get; set; }
    
    public int BuyPrice { get; set; }
    
    // Loot/Default items constructor
    public Weapon(string name, int level, string rarity, int damage, int criticalChance, int criticalDamage, int accuracy, int sellPrice) : base(name, level, rarity)
    {
        this.Damage = damage;
        this.CriticalChance = criticalChance;
        this.CriticalDamage = criticalDamage;
        this.Accuracy = accuracy;
        this.SellPrice = sellPrice;
        
    }
    
    // Shop items constructor
    public Weapon(string name, int level, string rarity, int damage, int criticalChance, int criticalDamage, int accuracy, int sellPrice, int buyPrice) : base(name, level, rarity)
    {
        this.Damage = damage;
        this.CriticalChance = criticalChance;
        this.CriticalDamage = criticalDamage;
        this.Accuracy = accuracy;
        this.SellPrice = sellPrice;
        this.BuyPrice = buyPrice;
        
    }
    
    
}