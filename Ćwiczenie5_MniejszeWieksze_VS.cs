using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;
        Console.WriteLine("Podaj dwie liczby A i B");
        a = (int)inputValue();
        b = (int)inputValue();
        if (a == b)
        {
            Console.WriteLine("Liczby są takie same");
        }
        else
        {
            if (a > b)
            {
                Console.WriteLine("Liczba A=" + a + " jest większa od B=" + b);
            }
            else
            {
                Console.WriteLine("Liczba B=" + b + " jest większa od A=" + a);
            }
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
