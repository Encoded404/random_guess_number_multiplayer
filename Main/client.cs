// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
Console.WriteLine("Hello, World!");

Game game = new Game(new Range(1, 10));

string wantsToPlay = "";
while(!wantsToPlay.ToLower().StartsWith("n")){
    game.Play();
    wantsToPlay = input.i("Wanna play agian? ");
    
}
static public class input
{
    public static string i(string question = ""){

        Console.Write(question);
        string h = Console.ReadLine();
        if(h == null)
        {
            h = "";
        }
        return h;
    }
}


class Game : networkManager
{
    System.Random random = new System.Random();
    private Range range;
    private int CorrectNumber;

    public Game(Range range){
        this.range = range;
    }

    // string input(string question = "")
    // {
    //     Console.Write(question);
    //     return Console.ReadLine();
    // }


    public int Play(){
        CorrectNumber = random.Next(range.lowest, range.highest);
        int chosenNumber = Int32.Parse(input.i("First guess: "));
        int numGuesses = 0;
        while (chosenNumber != CorrectNumber)
        {
            numGuesses++;
            if(chosenNumber < CorrectNumber){
                Console.WriteLine("Too low. Guess higher.");
            }
            if(chosenNumber > CorrectNumber){
                Console.WriteLine("Too high. Guess lower.");
            }
            chosenNumber =  Int32.Parse(input.i("Guess: "));

        }

        Console.WriteLine("Congratulations! You guessed the number in {0} guesses.", numGuesses);

        return numGuesses;
    }
}


class Range{
    public int lowest;
    public int highest;

    public Range(int lowest, int highest){
        this.lowest = lowest;
        this.highest = highest;
    }
}



