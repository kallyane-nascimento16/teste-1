using System;

class numero
{
    public static void Main(string[] args)

    {

        Console.WriteLine("agora iremos fazer a soma de dois numeros ");
        double numero1;
        double numero2;
        double resultado1;
        double resultado2;
        double resultado3;
        double resultado4;

        Console.WriteLine("digite o primeiro numero");
        numero1=double.Parse(Console.ReadLine());
        Console.WriteLine("digite o segundo numero");
        numero2=double.Parse(Console.ReadLine());

        resultado1 = numero1 + numero2;
        resultado2 = numero2  - numero1;
        resultado3 = numero1 * numero2;
        resultado4 = numero2 / numero1;

        Console.WriteLine("a soma do resultado é : " +  resultado1);
        Console.WriteLine("a subtração do resultado é: "+resultado2);
        Console.WriteLine("a multiplicação  do resultado é: " + resultado3);
        Console.WriteLine("a divisão do resultado é: " + resultado4);
    }
}