Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine().ToLower(); // Converte o texto para minúsculas para evitar diferenciação entre 'A' e 'a'

Dictionary<char, int> contadorDeLetras = new Dictionary<char, int>();

foreach (char c in texto)
{
    if (char.IsLetter(c))
    {
        if (contadorDeLetras.ContainsKey(c))
        {
            contadorDeLetras[c]++;
        }
        else
        {
            contadorDeLetras[c] = 1;
        }
    }
}

Console.WriteLine("Contagem de cada letra no texto:");
foreach (KeyValuePair<char, int> par in contadorDeLetras)
{
    Console.WriteLine($"{par.Key}: {par.Value}");
}