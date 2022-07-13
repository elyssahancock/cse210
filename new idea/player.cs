using System;

public class Player{
    public int count = 0;
    public int[] scores = {0, 0, 0};

    // constructor
    public Player(){

    }
    public void updateCount(){
        count += 1;
    }

    public void addToScoreList(int i){
        scores[i - 1] = count;
    }



}