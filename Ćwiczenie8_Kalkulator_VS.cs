using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj dwie liczby A i B");
        int a, b, wynik, działanie;
        a = (int)inputValue();
        b = (int)inputValue();
        Console.WriteLine("Dodawanie - 1, Odejmowanie - 2, mnożenie - 3, dzielenie - 4");
        działanie = (int)inputValue();
        if (działanie == 1)
        {
            Console.WriteLine(a + b);
        }
        else
        {
            if (działanie == 2)
            {
                Console.WriteLine(a - b);
            }
            else
            {
                if (działanie == 3)
                {
                    Console.WriteLine(a * b);
                }
                else
                {
                    if (działanie == 4)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine(a.ToString() + "/0");
                        }
                        else
                        {
                            Console.WriteLine((double)a / b);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wybierz poprawne działanie z zakresu 1-4");
                    }
                }
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
