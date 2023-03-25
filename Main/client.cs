// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;
Tools.setup();
Tools.print("a");
Thread.Sleep(1000);
Tools.print("b");
Thread.Sleep(1000);
Tools.print("c");
Thread.Sleep(1000);
Tools.print("d");
Thread.Sleep(1000);
Tools.print("a");
Thread.Sleep(1000);
Tools.print("b");
Thread.Sleep(1000);
Tools.print("c");
Thread.Sleep(1000);
Tools.print("d");
Thread.Sleep(1000);


Console.WriteLine("Hello, World!");

Game game = new Game(new Range(1, 10));

string wantsToPlay = "";
while(!wantsToPlay.ToLower().StartsWith("n")){
    game.Play();
    wantsToPlay = input.i("Wanna play again? ");
    
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
            // networkManager.sendnum(chosenNumber);
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



