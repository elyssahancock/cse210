using System;


// Create Card
Card card = new Card();


// create rules
Rules rule = new Rules();



// for loop to allow 3 rounds
for (int i = 1; i < 4; i++) 
{
  Console.WriteLine($"************************************** Round {i} **************************************") ;
  // reset the variables for  a new round
  int stillPlaying = 1;
  rule.Rulesplayer.count = 0;
  

    // while loop to continue until the user messes up
    while (stillPlaying == 1){
        card.getRandomCard();
        stillPlaying = rule.guess(card);
       
        rule.Rulesplayer.updateCount();
    }
    // once the round is completed add to the total scores list
    rule.Rulesplayer.addToScoreList(i);

    
}
// at the end of the three rounds display how the user did
Console.WriteLine($" Scores ~ {String.Join(" ", rule.Rulesplayer.scores)}");


