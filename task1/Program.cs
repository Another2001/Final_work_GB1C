int N = Input("Введите размер массива : ");
string[] fullmas = new string[N];
string masstr = string.Empty;
Console.WriteLine("Введите строки: ");

int Input(string text)
{
    bool f = false;
    int number = 0;
    while (!f)
    {
        Console.Write(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}

string WritString()
{
    string str = Console.ReadLine();
    return str;
}

for (int i = 0; i < N; i++)
{
    fullmas[i] = WritString();
    masstr += fullmas[i] + " ";
}

string Formating()
{
    string str = string.Empty;
    for (int i = 0; i < N; i++)
    {
        if (fullmas[i].Length <= 3)
        {
            str += fullmas[i] + " ";
        }
    }
    return str;
}

Console.WriteLine($"полученный массив строк [{masstr}]");
Console.WriteLine("строки длиной <=3 символов:");
Console.Write($"[{Formating()}]");



