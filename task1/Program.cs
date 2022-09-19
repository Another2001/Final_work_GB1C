int N = Input("Введите размер массива : ");
string[] fullmas = new string[N];
string masstr = string.Empty;
Console.WriteLine("Введите строки: ");

int Input(string text) // метод, который проверяет введенные данные и, если это не число, заставляет вводить данные снова (пока данными не окажется число)
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

string WritString() // метод для заполнения элементов массива
{
    string str = Console.ReadLine();
    return str;
}

for (int i = 0; i < N; i++) // цикл для заполнения массива и запоминания элементов в одну строку
{
    fullmas[i] = WritString();
    masstr += "\"" + fullmas[i] + "\"  ";
}

string Formating() // метод для отсеивания массива строк длина которых больше 3 символов
{
    string str = string.Empty;
    for (int i = 0; i < N; i++)
    {
        if (fullmas[i].Length <= 3)
        {
            str += "\"" + fullmas[i] + "\"      ";
        }
    }
    return str;
}

Console.WriteLine($"полученный массив строк [{masstr}]");
Console.WriteLine("строки длиной <=3 символов:");
Console.Write($"[{Formating()}]");



