using System;
//Skrobol Adrian
public class MyProgram
{
    public static void Main(string[] args)
    {
        double obwód, pole, promień, liczbaPi;
        liczbaPi = 3.141592;
        Console.WriteLine("Podaj pole koła aby obliczyć obwód");
        pole = inputValue();
        promień = Math.Sqrt(pole / liczbaPi);
        obwód = 2 * liczbaPi * Math.Sqrt(pole / liczbaPi);
        Console.WriteLine("Obwód koła o polu: " + pole + " wynosi: " + obwód);
    }
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
