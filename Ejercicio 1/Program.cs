using System;

class Program
{
    static void Main()
    {
        Ejercicios();
    }

    static void Ejercicios()
    {
        Console.WriteLine("Calcular el perímetro de un cuadrado");
        Console.Write("Escriba el valor de un lado del cuadrado: ");
        int lado = Convert.ToInt32(Console.ReadLine());
        int perimetro = lado * 4;
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");

        Console.WriteLine("Suma y producto de 4 números");
        Console.Write("Primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Tercer número: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cuarto número: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int suma = num1 + num2;
        int producto = num3 * num4;
        Console.WriteLine($"La suma de los dos primeros números es: {suma}, y el producto de los dos últimos es: {producto}");

        Console.WriteLine("Promedio de la sumatoria de cuatro números");
        Console.Write("Escriba el primer número: ");
        int valor1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escriba el segundo número: ");
        int valor2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escriba el tercer número: ");
        int valor3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Escriba el cuarto número: ");
        int valor4 = Convert.ToInt32(Console.ReadLine());
        int sumatoria = valor1 + valor2 + valor3 + valor4;
        double promedio = (double)sumatoria / 4;

        Console.WriteLine($"El promedio de la sumatoria de los cuatro números es: {promedio}");
    }
}
