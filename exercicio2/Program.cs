Console.Clear();

List<string> nameList = new();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Cadastre um nome [{i+1}/5] : ");
    nameList.Add(Console.ReadLine()!);
}

nameList.Sort();

foreach (var item in nameList)
{
    Console.WriteLine(item);
}