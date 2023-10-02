using CotsrRPG.Tui;

namespace CotsrRPG.Game;

public class Fight
{

    public void StartFight(Enemies enemy)
    {
        
        var gamedata = GameData.GetInstance();
        
        var player = gamedata.gameDataPlayer;

        bool playerturn = true;
        bool enemyTurn = false;
        bool isFightOver = false;
        
        var playerHealth = player.Health;
        
        var enemyHealth = enemy.Health;
        
        var playerDamage = player.Damage;
        
        var enemyDamage = enemy.Damage;
        
        var playerCriticalChance = player.CriticalChance;
        
        var enemyCriticalChance = enemy.CriticalChance;
        
        var playerCriticalDamage = player.CriticalDamage;
        
        var enemyCriticalDamage = enemy.CriticalDamage;
        
        var playerAccuracy = player.Accuracy;
        
        var enemyAccuracy = enemy.Accuracy;
        
        var playerExperience = player.Experience;
        
        var enemyExperience = enemy.Experience;
        
        var playerGold = player.Gold;
        
        var enemyGold = enemy.Gold;
        
        
        
        var gameMenu = new GameMenu();
        
        


        while (player.Health > 0 && enemy.Health > 0)
        {
            if (playerturn && !isFightOver)
            {
                Console.WriteLine("Player turn");
                Console.WriteLine("Press 1 to attack");
                Console.WriteLine("Press 2 to consume food WIP");

                var userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Player attacks");
                      
                        //Implement critical hit
                        
                        
                        var playerAttackRoll = new Random().Next(1, 100);
                        if (playerAttackRoll <= playerAccuracy)
                        {
                            enemy.Health = enemyHealth - playerDamage;
                            Console.WriteLine($"Player attacks for {playerDamage} damage");
                            Console.WriteLine($"Enemy health: {enemy.Health}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            playerturn = false;
                            enemyTurn = true;
                            enemyHealth = enemy.Health;
                        }
                        else
                        {
                            Console.WriteLine("Player missed");
                            Thread.Sleep(2000);
                            Console.Clear();
                            playerturn = false;
                            enemyTurn = true;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Player consumes food");
                        var food = gamedata.gameDataInventory.Food.FirstOrDefault();
                        if (food != null)
                        {
                            //Gør brug af consume i stedet, og menu med valg af mad
                            player.Health = playerHealth + food.Health;
                            Console.WriteLine($"Player consumed {food.Name} and gained {food.Health} health");
                            gamedata.gameDataInventory.Food.Remove(food);
                            Console.WriteLine($"Player health: {player.Health}");
                            Thread.Sleep(2000);
                            Console.Clear();
                            playerturn = false;
                            enemyTurn = true;
                            playerHealth = player.Health;
                        }
                        else
                        {
                            Console.WriteLine("No food in inventory");
                            Thread.Sleep(2000);
                            Console.Clear();
                            playerturn = false;
                            enemyTurn = true;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
                
            }
            
            if (enemy.Health <= 0)
            {
                Console.WriteLine("You won");
               
                player.Experience = playerExperience + enemyExperience;
                
                var leveling = new Leveling();
                
                leveling.checkLevelUp(player);
                
                player.Gold = playerGold + enemyGold;
                
                Console.WriteLine("you gained " + enemyExperience + " experience");
                
                Console.WriteLine("you gained " + enemyGold + " gold");
                
                
                Thread.Sleep(2000);
                Console.Clear();
                isFightOver = true;
                
             
                
                
                
                
                
                
                gameMenu.initializeGameMenu(false);
            }
            
            
            if (enemyTurn && !isFightOver)
            {
                Console.WriteLine("Enemy turn");
           
                //Implement critical hit
                
                var enemyAttackRoll = new Random().Next(1, 100);
                if (enemyAttackRoll <= enemyAccuracy)
                {
                    player.Health = playerHealth - enemyDamage;
                    Console.WriteLine($"Enemy attacks for {enemyDamage} damage");
                    Console.WriteLine($"Player health: {player.Health}");
                    Thread.Sleep(2000);
                    Console.Clear();
                    enemyTurn = false;
                    playerturn = true;
                    playerHealth = player.Health;
                }
                else
                {
                    Console.WriteLine("Enemy missed");
                    Thread.Sleep(2000);
                    Console.Clear();
                    enemyTurn = false;
                    playerturn = true;
                }
            }
            
            if (player.Health <= 0)
            {
                Console.WriteLine("You died");
                
                player.Health = 100;
                Console.WriteLine("Your hp has been reset");
                
                player.Experience = 0;
                Console.WriteLine("You lost all your experience");
            
                Thread.Sleep(2000);
                Console.Clear();
                isFightOver = true;
                gameMenu.initializeGameMenu(false);
            
            }


        }
        
    }
}