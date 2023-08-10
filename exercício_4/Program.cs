using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        double numero, valorHora, horaTrabalhada, salario;
       

        Console.WriteLine("\nDigite o número do funcionário: ");
        numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("\nDigite as horas trabalhadas: ");
        horaTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("\nDigite o valor do valor hora: ");
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        salario = valorHora * horaTrabalhada;

        Console.WriteLine("\nNumber:  " + numero, CultureInfo.InvariantCulture);
        Console.WriteLine("Salary U$:  " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}