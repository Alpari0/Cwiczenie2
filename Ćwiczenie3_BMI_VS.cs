using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        double waga, wzrost, bMI;
        Console.WriteLine("Podaj swój wzrost w cm ");
        wzrost = inputValue();
        Console.WriteLine("Podaj swoją wagę");
        waga = inputValue();
        bMI = waga / (wzrost / 100 * (wzrost / 100));
        Console.WriteLine("Twoje BMI wynosi: " + bMI);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
