public class Deck
{
    int pastCard = 0;
    int currentCard = 0;
    string word = "platypus";

    // Constructor
    public Deck()
    {
        
        //int currentCard = 0;
    }

    // Get a card
    public void changeTestWord(){
        word = "banana";
    }
    public int getCard()
    {
        //get a new random card
        Random random = new Random();
        int generatedCard = random.Next(1, 13);
        return generatedCard;
    

     
    }
    public void updateCard(){
        pastCard = currentCard;
        currentCard = getCard();
    }
    public char isHilo(){
        if (currentCard > pastCard){
            char hilo = 'h';
            return hilo;
        }
        else if (currentCard < pastCard){
            char hilo = 'h';
            return hilo;
        }
        else{
            char hilo = 'x';
            return hilo;
        }

    }
    public void showcard(){
        Console.WriteLine($"Previous Card {pastCard}");
        Console.WriteLine($"Current Card {currentCard}");

    }
    public void pleaseWork(){
        Console.WriteLine("I am begging you... please");
    }
}
