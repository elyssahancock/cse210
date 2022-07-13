using System;
// using System.Console;


// Create Card
Card card = new Card();



Rules rule = new Rules();



// Console.WriteLine(rule.Rulesplayer.count);
for (int i = 1; i < 4; i++) 
{
  Console.WriteLine($"************************************** Round {i} **************************************") ;
  int stillPlaying = 1;
  rule.Rulesplayer.count = 0;
  // Console.WriteLine($"Count {rule.Rulesplayer.count}");


    while (stillPlaying == 1){
        // debug print statement
        //Console.WriteLine("Start of Loop");
        // Console.WriteLine($"Count {rule.Rulesplayer.count}");
        card.getRandomCard();
        stillPlaying = rule.guess(card);
        //Console.WriteLine($"Still playing = {stillPlaying}");
        rule.Rulesplayer.updateCount();
    }
    rule.Rulesplayer.addToScoreList(i);

    
}
Console.WriteLine($" Scores ~ {String.Join(" ", rule.Rulesplayer.scores)}");


