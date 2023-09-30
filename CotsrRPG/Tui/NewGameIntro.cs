using CotsrRPG.Game;

namespace CotsrRPG.Tui;

public class NewGameIntro
{


    public void initializeNewGameIntro()
    {
     
       
        
        
        
        Console.WriteLine(
            "In a world where magic flows like the rivers and mythical creatures roam the untamed lands, " +
            "you find yourself in the small village of Everwood. Nestled in the heart of the enchanted forest, " +
            "Everwood is a place of tranquility and serenity. It's a home to elves, humans, and dwarves who have lived in harmony for centuries, " +
            "united by their shared respect for the mystical balance of the Shattered Realms.");

        Thread.Sleep(10000);
        Console.Clear();
        
        Console.WriteLine("Your journey begins as a humble blacksmith's apprentice, " +
                          "known as " + "getPlayerName" + ", with a burning desire to discover your true destiny. " +
                          "Little do you know that the fate of the entire realm lies in your hands.");
        
        Thread.Sleep(10000);
        Console.Clear();

        Console.WriteLine("Your first task, is to go to the local shop in the town, and buy a weapon and some food.");
        
        Thread.Sleep(10000);

        var gameMenu = new GameMenu();
        gameMenu.initializeGameMenu(true);
        
        




    }
    
    
    
    
    
}