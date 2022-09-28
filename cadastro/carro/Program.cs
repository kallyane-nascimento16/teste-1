using System;

class consumo
{
    public static void Main(string[] args)
    {
        double quilometro;
        double combustivel;
        double resultado;
        Console.WriteLine("qual a distacia percorrida por km");
        quilometro = double.Parse(Console.ReadLine());
        Console.WriteLine("quanto voce colocou de gasolina");
        combustivel = double.Parse(Console.ReadLine());
        resultado=quilometro/combustivel;
        Console.WriteLine("o consumo de combustivel é "+  resultado);
    }
     
}

 









