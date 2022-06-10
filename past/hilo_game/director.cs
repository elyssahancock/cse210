// start game

// varisbles:  

Person player1 = new Person();
Deck deck1 = new Deck();
string keepPlaying = "y";

while (keepPlaying == "y" && player1.score > 0){


player1.showScore();


deck1.updateCard();
deck1.showcard();
char isHilo = deck1.isHilo();
player1.guessAndPoints(isHilo);

player1.showScore();

Console.WriteLine("Keep playing? [y/n]");
keepPlaying = Console.ReadLine();
}
// deck1.currentCard = deck1.getCard();


// end game
