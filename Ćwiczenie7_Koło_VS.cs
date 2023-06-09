using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj koordynaty A i B twojego punktu oraz promień koła");
        int a, b, x, y, r;
        a = 0;
        b = 0;
        Console.WriteLine("A");
        x = (int)inputValue();
        Console.WriteLine("B");
        y = (int)inputValue();
        Console.WriteLine("Promień");
        r = (int)inputValue();
        if ((x - a) * (x - a) + (y - b) * (y - b) >= r * r)
        {
            Console.WriteLine("Punkt leży na lini lub poza linią koła");
        }
        else
        {
            Console.WriteLine("Punkt leży w obrębie koła");
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
