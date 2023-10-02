namespace CotsrRPG.Game;

public class Equip
{
    
    public GameData gamedata = GameData.GetInstance();
    
    public void EquipWeapon(string weaponName)
    {
        
        var weaponItem = gamedata.gameDataInventory.Weapons.FirstOrDefault(weapon => weapon.Name.Equals(weaponName, StringComparison.OrdinalIgnoreCase));

        if (weaponItem != null)
        {
            Console.WriteLine($"You equipped {weaponItem.Name}. Damage: {weaponItem.Damage}");
  
            var lastEquippedWeapon = gamedata.gameDataInventory.Weapons.FirstOrDefault(weapon => weapon.IsEquipped == true);
            
            Console.WriteLine("Damage before equip:" + gamedata.gameDataPlayer.Damage);
            
            if (lastEquippedWeapon != null)
            {
                Console.WriteLine("Debug Last equipped weapon found");
                lastEquippedWeapon.IsEquipped = false;
                gamedata.gameDataPlayer.Damage -= lastEquippedWeapon.Damage;
            }
            
            
            
            var currentDamage = gamedata.gameDataPlayer.Damage;
            
            gamedata.gameDataPlayer.Damage = currentDamage + weaponItem.Damage;
      
            
            Console.WriteLine("Damage after equip:" + gamedata.gameDataPlayer.Damage);
            
            weaponItem.IsEquipped = true;
            
          
            
            
            Thread.Sleep(2000);
            
          
            
        }
        else
        {
            Console.WriteLine($"Weapon '{weaponName}' not found in the inventory.");
            Thread.Sleep(2000);
        }
    }
    
    
}