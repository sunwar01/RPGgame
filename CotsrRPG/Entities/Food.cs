﻿using System.Text.Json.Serialization;

namespace CotsrRPG;

public class Food : Item
{
    public int Health { get; set; }
    
    public int SellPrice { get; set; }
    
    
    [JsonIgnore]
    public int BuyPrice { get; set; }
    
    
    [JsonConstructor]
    // Loot/Default items constructor
    public Food(string name, int level, string rarity, int health, int sellPrice) : base(name, level, rarity)
    {
        this.Health = health;
        this.SellPrice = sellPrice;
    }
    
    // Shop items constructor
    public Food(string name, int level, string rarity, int health, int sellPrice, int buyPrice) : base(name, level, rarity)
    {
        
        this.Health = health;
        this.SellPrice = sellPrice;
        this.BuyPrice = buyPrice;
        
    }
}