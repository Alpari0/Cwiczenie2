using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj wymiary boków trójkąta");
        int a, b, c, suma;
        Console.WriteLine("Podaj bok A");
        a = (int)inputValue();
        Console.WriteLine("Podaj bok B");
        b = (int)inputValue();
        Console.WriteLine("Podaj bok C");
        c = (int)inputValue();
        if (a + b <= c || b + c <= a || c + a <= b)
        {
            Console.WriteLine("Nie można utworzyć trójkóta, ponieważ suma dwóch boków jest mniejsza od długości trzeciego boku");
        }
        else
        {
            if (a == b || b == c || c == a)
            {
                Console.WriteLine("Można utworzyć trójkąt równoboczny o bokach o długości: " + a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine("Nie można utworzyć trójkąta równobocznego o bokach o długości: " + a + " " + b + " " + c);
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
