int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

void Answer(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0) Console.Write(","+m);
        Answer(m+1,n);
    }
}

int m = GetNum("Задайте число M:");
int n = GetNum("Задайте число N:");
Console.Write("Ответ:");
Answer(m,n);