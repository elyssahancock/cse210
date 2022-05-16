// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Main Function
void Main(){
    int over1 = 0;
    string player = "x";
    
        Console.WriteLine("Hey");
        string[] varList = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        while (over1 == 0)
        {
        PrintGrid(varList);
        Console.WriteLine($"Player {player}: Choose a spot to mark");
        int location = int.Parse(Console.ReadLine());

        if (varList[location] == "x" || varList[location] == "o")
            {
            Console.WriteLine("Invalid Spot");
            }
        else
            {
            varList[location] = player;
            };
        over1 = EndGame(varList, over1);
        if (player == "x")
        {
            player = "o";
        }
        else{
            player = "x";
        }
      
}

}; // End main function

// Print Grid Function
void PrintGrid(string[] varList) 
{
    Console.WriteLine("Function executed");
    Console.WriteLine($"{varList[1]}|{varList[2]}|{varList[3]}\n-+-+-");
    Console.WriteLine($"{varList[4]}|{varList[5]}|{varList[6]}\n-+-+-\n{varList[7]}|{varList[8]}|{varList[9]}");
}

// End Game Function
int EndGame(string[] varList, int over1)
{
    // 123
    if (varList[1] == "x" && varList[2] =="x" && varList[3] == "x" || varList[1] =="o" && varList[2] =="o" && varList[3] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 456
    else if (varList[4] == "x" && varList[5] =="x" && varList[6] == "x" || varList[4] =="o" && varList[5] =="o" && varList[6] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 789
    else if (varList[7] == "x" && varList[8] =="x" && varList[9] == "x" || varList[7] =="o" && varList[8] =="o" && varList[9] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 147
    else if (varList[1] == "x" && varList[4] =="x" && varList[7] == "x" || varList[1] =="o" && varList[4] =="o" && varList[7] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 258
    else if (varList[2] == "x" && varList[5] =="x" && varList[8] == "x" || varList[2] =="o" && varList[5] =="o" && varList[8] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 369
    else if (varList[3] == "x" && varList[6] =="x" && varList[9] == "x" || varList[3] =="o" && varList[6] =="o" && varList[9] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 159
    else if (varList[1] == "x" && varList[5] =="x" && varList[9] == "x" || varList[1] =="o" && varList[5] =="o" && varList[9] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }

    // 753
    else if (varList[7] == "x" && varList[5] =="x" && varList[3] == "x" || varList[7] =="o" && varList[5] =="o" && varList[3] == "o")
    {
        Console.WriteLine("Good Game");
        over1 = 1;
        return over1;
    }
    else {
        over1 = 0;
        return over1;
    }
}


Main();
