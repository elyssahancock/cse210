
namespace Jumper{
    public class Director{
        public terminal seekerTerminal  = new terminal();
        

        public player player1 = new player();
        private Word word = new Word();
        public Rules rule1;
        public Director(){
             //constuctor
             rule1  = new Rules(word);
             startGame();

        }
       
    public void startGame(){
            word.getRandomWord();
            Console.WriteLine(word.chosenWord);
            Console.WriteLine(word.isPlaying());
            while(word.isPlaying() && player1.lives>0)
            {
        //while (rule1.word1.isPlaying() == true){
            DoUpdates();
            DoOutputs();
            }
        

        }
    
    void DoUpdates(){
        bool found = rule1.guess();
        if(!found){
            player1.lives--;
        }

    } // end DoUpdates function
    void DoOutputs(){
        seekerTerminal.printMan(player1.lives);
        seekerTerminal.printAnswer(word);
    }

    // string getUserLetter(){

    // }

    } // end of class
    

} // end of namespace functino