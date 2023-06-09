using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        double nr1, nr2, nr3, średnia;

        Console.WriteLine("Podaj pierwszą liczbę");
        nr1 = inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        nr2 = inputValue();
        Console.WriteLine("Podaj trzecią liczbę");
        nr3 = inputValue();
        średnia = (nr1 + nr2 + nr3) / 3;
        Console.WriteLine("Średnia podanych przez Ciebie liczb wynosi: " + średnia);    
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
