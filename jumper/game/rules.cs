using System;
namespace Jumper{
    public class Rules{
        // vars:
        public terminal rulesTerminal  = new terminal();
        Word word1;




        public Rules(Word word){
            // constructor
            word1 = word;
        }

        //methods:
    public bool guess(){
        char charGuess = rulesTerminal.promptForLetter();
        bool found = false;
        List<char> character_list = word1.listOfCharacter;

        
        // if (character_list.Contains(charGuess)) {
        //     int indexOfLetter = character_list.IndexOf(charGuess);
        //     found = true;
            
        // }

        for (int i = character_list.IndexOf(charGuess); i > -1; i = character_list.IndexOf(charGuess, i + 1)){
            if (character_list[i] == charGuess){
                found = true;
                word1.asterickList[i] = charGuess;
            }  
            else{
                found = false;
            }
        }
        return found;
        

    

}

    } // end of class Rules

} // end of namespace