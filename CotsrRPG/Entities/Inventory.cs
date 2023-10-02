using System.Text.Json.Serialization;

namespace CotsrRPG;

public class Inventory
{
    public List<Weapon> Weapons { get; set; }
    public List<Food> Food { get; set; }
    
    [JsonConstructor]
    public Inventory(List<Weapon> weapons, List<Food> food)
    {
        Weapons = weapons ?? new List<Weapon>();
        Food = food ?? new List<Food>();
    }
    
}