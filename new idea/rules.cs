using System;
public class Rules {
    // variables
    int slap = 0;
    int shouldSlap = 0;
    public Player Rulesplayer = new Player();

    

    // constructor 
    public Rules(){

    }

    public int guess(Card card){
        // determine whether or not the correct response is to slap
        if (card.cardNumber == ((Rulesplayer.count % 5) + 1)){
            shouldSlap = 1;
        }
        else {
            shouldSlap = 0;
        }

        // prompt the user for their slap and get the response
        Console.WriteLine("Slap (1) or No Slap (0) or Quit (2)?");
        slap = int.Parse(Console.ReadLine());
        
        
        
       
        if (shouldSlap != slap){
            return 0; // return not stillPlaying
        }
        
        return 1; // return still Playing

    } // end guess function

}