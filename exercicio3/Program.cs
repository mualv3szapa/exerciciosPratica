Console.Clear();

int[] vetor = new int[10];

vetor[0] = 12;
vetor[1] = 25;
vetor[2] = 32;
vetor[3] = 44;
vetor[4] = 50;
vetor[5] = 64;
vetor[6] = 71;
vetor[7] = 83;
vetor[8] = 91;
vetor[9] = 103;

int somaPares = 0;

// Laço for para percorrer o vetor
for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 == 0)
    {
        somaPares += vetor[i];
    }
}

Console.WriteLine("A soma dos números pares é: " + somaPares);