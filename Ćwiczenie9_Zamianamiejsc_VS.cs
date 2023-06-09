using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj następująco trzy liczby A, B i C");
        int a, b, c;
        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        Console.WriteLine("Twoje liczby to: A=" + a + ",B=" + b + ",C=" + c);
        a = a - b;
        b = b + a;
        a = b - a;
        a = a - c;
        c = c + a;
        a = c - a;
        Console.WriteLine("Po zamianie liczb miejscami efekt końcowy wygląda następująco: A=" + a + ",B=" + b + ",C=" + c);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
