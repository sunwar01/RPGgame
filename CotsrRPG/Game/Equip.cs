namespace CotsrRPG.Game;

public class Equip
{
    
    public GameData gamedata = GameData.GetInstance();
    
    public void EquipWeapon(string weaponName)
    {
        // Find the weapon item in the inventory
        var weaponItem = gamedata.gameDataInventory.Weapons.FirstOrDefault(weapon => weapon.Name.Equals(weaponName, StringComparison.OrdinalIgnoreCase));

        if (weaponItem != null)
        {
            Console.WriteLine($"You equipped {weaponItem.Name}. Damage: {weaponItem.Damage}");
  
            var lastEquippedWeapon = gamedata.gameDataInventory.Weapons.FirstOrDefault(weapon => weapon.IsEquipped == true);
            
            if (lastEquippedWeapon != null)
            {
                lastEquippedWeapon.IsEquipped = false;
                gamedata.gameDataPlayer.Damage -= lastEquippedWeapon.Damage;
            }
            
            
            gamedata.gameDataPlayer.Damage =+ weaponItem.Damage;
            
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