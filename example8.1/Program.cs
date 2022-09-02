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
            if (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }                   
           }            
       }
    return array;
}

void Answer(int[,] array, int[,] resArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array [i,j];
        }
        row = BubbleSort(row);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            resArray[i,j] = row[j];
        }
    }
}

Random rnd = new Random();
int sizei = rnd.Next(3,15);
int sizej = rnd.Next(3,15);
int[,] array = new int[sizei,sizej];
int[,] sortedArray = new int[sizei,sizej];
FillArray2Rnd(array, rnd, 0, 100);
Answer(array,sortedArray);

Console.WriteLine("Исходный масив:"+PrintArray2(array));
Console.WriteLine("Сортированный по строкам массив:"+PrintArray2(sortedArray));






