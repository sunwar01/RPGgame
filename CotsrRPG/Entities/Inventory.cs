namespace CotsrRPG;

public class Inventory
{
    public List<Weapon> Weapons = new List<Weapon>();
    
    public List<Food> Food = new List<Food>();
    
    public Inventory(List<Weapon> weapons, List<Food> food)
    {
        this.Weapons = weapons;
        this.Food = food;
    }
    
}