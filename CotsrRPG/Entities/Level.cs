using CotsrRPG.Game;

namespace CotsrRPG;

public class Level
{
    public Fight fight = new Fight();
    public void Everwood_training()
    {
        var trainingDummy = new Enemies("Training Dummy", 1, 100, 0, 0, 0, 0, 10, 1); 
        
        fight.StartFight(trainingDummy);

    }

    public void Everwood_Forest()
    {
        
        var Goblin = new Enemies("Goblin", 1, 100, 4, 0, 0, 40, 15, 5);
        
        fight.StartFight(Goblin);
        
    }
    
    
}