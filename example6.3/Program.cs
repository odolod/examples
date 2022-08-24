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
                res = res + ", ";
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

Random rnd = new Random();
int sizei = rnd.Next(3,15);
int sizej = rnd.Next(3,15);
int[,] array = new int[sizei,sizej];
FillArray2Rnd(array, rnd, -100, 100);

Console.Write("Масив:"+PrintArray2(array));



