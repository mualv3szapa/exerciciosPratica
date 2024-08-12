static void ImprimirTabuada(double numero)
{
    for (int i = 1; i <= 10; i++)
    {
       
        Console.WriteLine($"{numero} x {i} = {numero*i}");
    }
}

Console.Clear();
Console.WriteLine("Digite o número que você quer saber a tabuada");
ImprimirTabuada(double.Parse(Console.ReadLine()!));