int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int Answer(int m, int n)
{
    if (m <= n)
    {
        return Answer(m+1,n)+m;
    } else return 0;
}

int m = GetNum("Задайте число M:");
int n = GetNum("Задайте число N:");
Console.Write("Ответ:"+Answer(m,n).ToString());
