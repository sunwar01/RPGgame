using CotsrRPG.Tui;

namespace CotsrRPG;

public class Shop
{
    private static Shop _instance;

    public List<Weapon> Weapons { get; private set; }
    public List<Food> Food { get; private set; }

   
    private Shop()
    {
        Weapons = new List<Weapon>();
        Food = new List<Food>();
        InitializeShop();
    }
    
    public void AddWeapon(Weapon weapon)
    {
        Weapons.Add(weapon);
    }

    public void AddFood(Food food)
    {
        Food.Add(food);
    }

    public static Shop Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Shop();
            }
            return _instance;
        }
    }
 
    
    
    public  void InitializeShop()
    {
      
        //Weapons
        
        //Common
        var rustySword = new Weapon("Rusty Sword", 1, "Common", 5, 5, 5, 40, 5, 10, false);
        var rustyMace = new Weapon("Rusty Mace", 1, "Common", 4, 15, 10, 37, 5, 10, false);
        var rustyAxe = new Weapon("Rusty Axe", 1, "Common", 6, 5, 5, 40, 5, 10, false);

        AddWeapon(rustySword);
        AddWeapon(rustyMace);
        AddWeapon(rustyAxe);
        
        //Uncommon
        var fineSword = new Weapon("Fine Sword", 1, "Uncommon", 7, 5, 5, 40, 10, 50, false);
        var fineMace = new Weapon("Fine Mace", 1, "Uncommon", 6, 15, 10, 37, 10, 50, false);
        var fineAxe = new Weapon("Fine Axe", 1, "Uncommon", 8, 5, 5, 40, 10, 50, false);

        AddWeapon(fineSword);
        AddWeapon(fineMace);
        AddWeapon(fineAxe);
       
        
        
        //Food
        
        //Common
        var apple = new Food("Apple", 1, "Common", 10, 5, 10);
        var bread = new Food("Bread", 1, "Common", 15, 5, 15);
        var cheese = new Food("Cheese", 1, "Common", 20, 5, 20);
        
        AddFood(apple);
        AddFood(bread);
        AddFood(cheese);
        
        
        //Uncommon
        var ham = new Food("Ham", 1, "Uncommon", 25, 10, 25);
        var steak = new Food("Steak", 1, "Uncommon", 30, 10, 30);
        var fish = new Food("Fish", 1, "Uncommon", 35, 10, 35);
        
        AddFood(ham);
        AddFood(steak);
        AddFood(fish);
         

    
        
        
        
        
    }
  
}