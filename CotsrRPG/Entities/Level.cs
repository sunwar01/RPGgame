using CotsrRPG.Game;

namespace CotsrRPG;

public class Level
{
    
    public void Everwood_training()
    {
        var trainingDummy = new Enemies("Training Dummy", 1, 100, 0, 0, 0, 0, 10); 
        
        var fight = new Fight();
        
        fight.StartFight(trainingDummy);

    }
    
    
}