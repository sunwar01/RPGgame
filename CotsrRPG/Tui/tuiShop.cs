namespace CotsrRPG.Tui;

public class tuiShop
{
     public void ShowWeapons()
   {
       Console.WriteLine("Weapons:");
     
       
   }

   public void ShowFood()
   {
       Console.WriteLine("Food:");
   
   }

   public void ShowShop()
   {
       ShowWeapons();
       ShowFood();
   }
}