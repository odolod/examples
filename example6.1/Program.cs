double GetNum(string message)
{
    Console.Write(message);
    double res = double.Parse(Console.ReadLine());
    return res;
}

int NotZeroCount(double[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) res++;
    }
    return res;
}

int m = 5;
double[] array = new double[m];

Console.WriteLine("Введите M="+m+" чисел:");
for (int i = 0; i < m; i++)
{
    array[i] = GetNum("Введите число:");
}

Console.Write("Введено чисел больше нуля:"+NotZeroCount(array));


