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
    
    public  void InitializeShop(Shop shop)
    {
      
        //Weapons
        
        //Common
        var rustySword = new Weapon("Rusty Sword", 1, "Common", 5, 5, 5, 40, 5, 10, false);
        var rustyMace = new Weapon("Rusty Mace", 1, "Common", 4, 15, 10, 37, 5, 10, false);
        var rustyAxe = new Weapon("Rusty Axe", 1, "Common", 6, 5, 5, 40, 5, 10, false);

        //Uncommon
        var fineSword = new Weapon("Fine Sword", 1, "Uncommon", 7, 5, 5, 40, 10, 50, false);
        var fineMace = new Weapon("Fine Mace", 1, "Uncommon", 6, 15, 10, 37, 10, 50, false);
        var fineAxe = new Weapon("Fine Axe", 1, "Uncommon", 8, 5, 5, 40, 10, 50, false);

        shop.Weapons.Add(rustySword);
        shop.Weapons.Add(rustyMace);
        shop.Weapons.Add(rustyAxe);
        shop.Weapons.Add(fineSword);
        shop.Weapons.Add(fineMace);
        shop.Weapons.Add(fineAxe);
        
        
        //Food
        
        //Common
        var apple = new Food("Apple", 1, "Common", 10, 5, 10);
        var bread = new Food("Bread", 1, "Common", 15, 5, 15);
        var cheese = new Food("Cheese", 1, "Common", 20, 5, 20);
        
        //Uncommon
        var ham = new Food("Ham", 1, "Uncommon", 25, 10, 25);
        var steak = new Food("Steak", 1, "Uncommon", 30, 10, 30);
        var fish = new Food("Fish", 1, "Uncommon", 35, 10, 35);
         

        shop.Food.Add(apple);
        shop.Food.Add(bread);
        shop.Food.Add(cheese);
        shop.Food.Add(ham);
        shop.Food.Add(steak);
        shop.Food.Add(fish);
        
        
        
        
    }
  
}