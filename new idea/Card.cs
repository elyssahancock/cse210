using System;

public class Card
{
    // card variables
    public string cardName;
    public int cardNumber;
    public string[] cardList = {"EMPTY", "TACO", "CAT", "GOAT", "CHEESE", "PIZZA"};
    
    // Constructor
    public Card(){

    }
    // Methods
    public void getRandomCard(){
        Random random = new Random();
        cardNumber = random.Next(1, 6);
        cardName = cardList[cardNumber];
        
        Console.WriteLine(cardName);
    }
    public void writeIt(){
        this.cardNumber= cardNumber;
        this.cardName = cardName;
        Console.WriteLine($"cardNumber: {cardNumber} + cardName: {cardName}");
    }
    

} // end of Card class