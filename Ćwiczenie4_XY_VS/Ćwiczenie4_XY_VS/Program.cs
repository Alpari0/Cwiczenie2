using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczby a,b,c i d aby obliczyć licznik X i mianownik Y");
        double x, y, xY;
        double a, b, c, d;
        Console.WriteLine("Podaj A");
        a = inputValue();
        Console.WriteLine("Podaj B");
        b = inputValue();
        Console.WriteLine("Podaj C");
        c = inputValue();
        Console.WriteLine("Podaj D");
        d = inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązań, ponieważ liczba b lub d wynosi 0");
        }
        else
        {
            xY = a * d / (b * d) + c * b / (d * b);
            x = a * d;
            y = c * b;
            while (x % 2 == 0 && y % 2 == 0)
            {
                x = x / 2;
                y = y / 2;
            }
            while (x % 3 == 0 && y % 3 == 0)
            {
                x = x / 3;
                y = y / 3;
            }
            while (x % 5 == 0 && y % 5 == 0)
            {
                x = x / 5;
                y = y / 5;
            }
            Console.WriteLine("Licznik X wynosi: " + x);
            Console.WriteLine("Mianownik Y wynsi: " + y);
            Console.WriteLine("X/Y wynosi:" + xY);
        }
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
