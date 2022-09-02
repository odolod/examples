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

int[] BubbleSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }                   
           }            
       }
    return array;
}

string Answer(int[,] array)
{
    int[] sums = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sums[j] = sums[j] + array[i,j];
        }
    }
    int index = 0;
    for (int j = 1; j < sums.Length; j++)
    {
        if (sums[index] < sums[j])
        {
            index = j;
        }
    }
    return index.ToString();
}

Random rnd = new Random();
int size = rnd.Next(3,15);
int[,] array = new int[size,size];
FillArray2Rnd(array, rnd, 0, 100);

Console.WriteLine("Исходный масив:"+PrintArray2(array));
Console.WriteLine("Номер строки с наименьшей суммой элементов:"+Answer(array));







