namespace CotsrRPG;

public class Shop
{
    public List<Weapon> Weapons { get; set; }
    
    public List<Food> Food { get; set; }

    public Shop(List<Weapon> weapons, List<Food> food)
    {
        Weapons = weapons;
        Food = food;
    }
    
   /* public void ShowWeapons()
    {
        Console.WriteLine("Weapons:");
        foreach (var weapon in Weapons)
        {
            Console.WriteLine($"Name: {weapon.Name} | Level: {weapon.Level} | Rarity: {weapon.Rarity} | Damage: {weapon.Damage} | Critical Chance: {weapon.CriticalChance} | Critical Damage: {weapon.CriticalDamage} | Accuracy: {weapon.Accuracy} | Sell Price: {weapon.SellPrice} | Buy Price: {weapon.BuyPrice}");
        }
    }
    
    public void ShowFood()
    {
        Console.WriteLine("Food:");
        foreach (var food in Food)
        {
            Console.WriteLine($"Name: {food.Name} | Level: {food.Level} | Rarity: {food.Rarity} | Health: {food.Health} | Sell Price: {food.SellPrice} | Buy Price: {food.BuyPrice}");
        }
    }
    
    public void ShowShop()
    {
        ShowWeapons();
        ShowFood();
    }*/
}