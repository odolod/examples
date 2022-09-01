string PrintArray2(int[,] array)
{
    string res = "[";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        res = res + "[";
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res = res /* + "(" + i + ":" + j + ")" */ + array[i,j];
            if (j < array.GetLength(1)-1)
            {
                res = res + "; ";
            }
        }
        res = res + "]";
    }
    res = res + "]";
    return res;
} 

void FillArray2Rnd(int[,] array, Random rnd, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue);
        }
    }
}

string ListArray(double[] array)
{
    string res = "";
    for (int i = 0; i < array.Length; i++)
    {
        res = res + array[i];
        if (i < array.Length-1)
        {
            res = res + "; ";
        }
    }
    return res;
}

string Answer(int[,] array)
{
    double[] totals = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        totals[i] = (double)sum / (double)array.GetLength(1);
    }
    return ListArray(totals);
}

Random rnd = new Random();
int sizei = rnd.Next(3,15);
int sizej = rnd.Next(3,15);
int[,] array = new int[sizei,sizej];
FillArray2Rnd(array, rnd, 0, 100);

Console.WriteLine("Масив:"+PrintArray2(array));

Console.WriteLine("Среднее арифметическое каждого столбца:"+Answer(array));





