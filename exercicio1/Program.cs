Console.Clear();

int n;

Console.WriteLine($"Informe um número inteiro");

n = int.Parse(Console.ReadLine()!);

if ( n % 2 == 0) {
    Console.WriteLine($"O número {n} é par"); 
} else {
    Console.WriteLine($"O número {n} é impar");
}
