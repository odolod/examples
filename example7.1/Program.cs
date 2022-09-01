int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

string PrintArray2(double[,] array)
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

void FillArray2Rnd(double[,] array, Random rnd, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue) * rnd.NextDouble();
        }
    }
}

Random rnd = new Random();
int n = GetNum("Задайте размер массива n:");
int m = GetNum("Задайте размер массива m:");
double[,] array = new double[n,m];
FillArray2Rnd(array, rnd, -100, 100);

Console.Write("Масив:"+PrintArray2(array));




