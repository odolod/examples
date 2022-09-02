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

int[,] matrixMultiplicate(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i,j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + array1[i,k]*array2[k,j];
            }
        }
    }
    return result;
}

Random rnd = new Random();
int size = rnd.Next(3,15);
int sizei = rnd.Next(3,15);
int sizej = rnd.Next(3,15);
int[,] array1 = new int[sizei,size];
int[,] array2 = new int[size,sizej];
FillArray2Rnd(array1, rnd, 0, 100);
FillArray2Rnd(array2, rnd, 0, 100);
Console.WriteLine("Исходная матрица 1:"+PrintArray2(array1));
Console.WriteLine("Исходная матрица 2:"+PrintArray2(array2));
Console.WriteLine("Итоговая матрица:"+PrintArray2(matrixMultiplicate(array1,array2)));








