// See https://aka.ms/new-console-template for more information



public class Person
{
     public int score = 300;

      
    public Person()
    {
      
    }
    public void guessAndPoints(char hilo){
        Console.WriteLine("higher or lower -- [h / l]");
        char guess = char.Parse(Console.ReadLine());
        if (guess == hilo){
            score += 100;
        }
        else {
            score -= 75;
        }

    }
    public void showScore(){
        Console.WriteLine(score);
    }
}

    