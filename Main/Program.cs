using System.Threading;

public class Tools
{

    static string input = "10";

    public static void print(string s){
        Console.SetCursorPosition(0, Console.CursorTop - 0);
        if(input.Length > s.Length) Console.WriteLine(s + Spaces(input.Length - s.Length));
        else Console.WriteLine(s);
        // Console.WriteLine(s);
        // Console.WriteLine("");
        Console.Write(input);
        
    }
    string Spaces(int n)
    {
        return new string(' ', n);
    }


    void MonitorKeypress()
    {
        ConsoleKeyInfo cki = new ConsoleKeyInfo();
        do
        {
            // true hides the pressed character from the console
            cki = Console.ReadKey(true);
            Console.Write(cki.KeyChar);
            input += cki.KeyChar;
            
            // Wait for an ESC
        } while (cki.Key != ConsoleKey.Escape);
        
        // Cancel the token
    }
    static void setup(){

        Thread t = new Thread(MonitorKeypress);

        t.Start();


        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("");
    }




    // ... Launch other async tasks ...
    void Main()
    {
        print("wf");
        Thread.Sleep(1000);
        print("hej");
        Thread.Sleep(1000);
        print("du");
        Thread.Sleep(1000);
        print("wf");
        Thread.Sleep(1000);
        print("hej");
        Thread.Sleep(1000);
        print("du");
        Thread.Sleep(1000);
        print("wf");
        Thread.Sleep(1000);
        print("hej");
        Thread.Sleep(1000);
        print("du");
        Thread.Sleep(1000);
    }
    // Waits for the keypress to end it all

    // he is cool
    // lala
    // 10
}