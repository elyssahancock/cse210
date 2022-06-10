using System;
namespace Jumper
{

    // declare class
public class terminal{
    
    
    public terminal(){
        // constructor
    }
    // define all other functions

    
    public void printMan(int lives){
        for (int i = 0; i < lives; i++) {
            Console.Write("<3 ");
        }
        Console.WriteLine();
        if (lives == 0){
            Console.WriteLine("Game Over");
        }
        // Console.WriteLine(" —-- ");
        // Console.WriteLine("/___\ ");
        // Console.WriteLine("\   /");
        // Console.WriteLine(" \   /");
        // Console.WriteLine("  0");
        // Console.WriteLine(" / | \ ");
        // Console.WriteLine(" / \ ");
        // if (lives == 4){
        //     Console.WriteLine(" —-- ");
        // }
        // if (lives == 3){
        //     Console.WriteLine("/___\\\n ");
        // }
        // if (lives == 2){
        //     Console.WriteLine("\\  /");
        // }
        // if (lives >= 1){
        //     // Console.WriteLine(" \\   /");
        //     // Console.WriteLine("    0");
        //     // Console.WriteLine(" / | \\ ");
        //     // Console.WriteLine(" /  \\ ");
        // }
        // else {
        //     Console.WriteLine("Game Over");
        //     Console.WriteLine("  x");
        //     Console.WriteLine(" / | \\ ");
        //     Console.WriteLine(" / \\ ");
        // }
       
        // end of printMan function
    }
    public void printAnswer (Word word){
       int length = word.chosenWord.Length;
       for (int i = 0; i < length; i++)     
        {
            Console.Write(word.asterickList[i]);
        }
        Console.WriteLine();
} // end printAnswer
    public char promptForLetter(){
        Console.WriteLine("Guess a letter");
        char charGuess = Char.Parse(Console.ReadLine());
        return charGuess;

} // end promptForLetter




} // end of class
} // end namespace