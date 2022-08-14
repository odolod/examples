
int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

double cube(int n)
{
    return Math.Pow(n, 3);
}

int n = GetNum("Введите число N:");

Console.Write("Кубы чисел 1-N:");
for (int i = 1; i <= n; i++)
{
    Console.Write(cube(i) + ", ");
}