namespace CotsrRPG.Game;

public class Leveling
{
    
    public int CalculateExperienceToLevelUp(int level)
    {
        int baseExperience = 100;
        
        double experienceToLevelUp = baseExperience * Math.Pow(1 + 0.30, level - 1);;
        
        return (int) experienceToLevelUp;
    }


    public void addExperience(Player player, int experience)
    {
        var playerExperience = player.Experience;
        
        player.Experience = playerExperience + experience;
        
        checkLevelUp(player);
    }
    
    public void checkLevelUp(Player player)
    {
        
        if (player.Experience >= CalculateExperienceToLevelUp(player.Level))
        {
            var playerLevel = player.Level;
            
            player.Level = playerLevel + 1;
            
            player.Experience = 0;
            
        }
    }
   
}