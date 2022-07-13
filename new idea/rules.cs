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
        if (card.cardNumber == ((Rulesplayer.count % 5) + 1)){
            shouldSlap = 1;
            
        }
        else {
            shouldSlap = 0;
        }
        //Console.WriteLine($"Should slap = {shouldSlap}");
        //Console.WriteLine($"Remainder:{Rulesplayer.count % 5 +1} of Count {Rulesplayer.count} {card.cardNumber} {card.cardList[Rulesplayer.count%5+1]}");

        // Console.WriteLine($"cardNum: {card.cardNumber} == countDeterminate: {((Rulesplayer.count % 5) + 1)} ");
        Console.WriteLine("Slap (1) or No Slap (0) or Quit (2)?");
        slap = int.Parse(Console.ReadLine());
        
        
        
        // Console.WriteLine($"Should slap = {shouldSlap}");
        if (shouldSlap != slap){
            return 0; // return stillPlaying
        }
        
        return 1; // return still Playing

    } // end guess function

}