using System;

class cadastro
{
    public static void Main(string[] args)

    {
        string nome1;
        double altura;
        double cpf;
        double peso;
        string rua;
        double numerodacasa;
        string cidade;
        double cep;

        Console.WriteLine ("ola seja bem-vindo !");
        Console.WriteLine("qual o seu nome?");
        nome1=Console.ReadLine();

        Console.WriteLine("qual a sua altura");
        altura=double.Parse ( Console.ReadLine());

        Console.WriteLine("qual o seu CPF");
        cpf=double.Parse (Console.ReadLine());

        Console.WriteLine("qual o seu peso");
        peso=double.Parse(Console.ReadLine());

        Console.WriteLine("qual cidade voce mora");
        cidade=Console.ReadLine();

        Console.WriteLine("qual o CEP  de dua cidade");
        cep = double.Parse(Console.ReadLine());         

        Console.WriteLine("qual nome da sua rua??");
        rua=Console.ReadLine();

        Console.WriteLine("qual o numero de sua casa");
        numerodacasa=double.Parse(Console.ReadLine());


    } 
}
