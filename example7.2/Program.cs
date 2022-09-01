int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

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

string Answer(int[,] array, int i, int j)
{
    if (array.GetLength(0) - i > 0 && array.GetLength(1) - j > 0)
    {
        return array[i,j].ToString();
    } else return " не существует в этом массиве";
}

Random rnd = new Random();
int i = GetNum("Задайте координату i массива:");
int j = GetNum("Задайте координату j массива:");
int sizei = rnd.Next(3,15);
int sizej = rnd.Next(3,15);
int[,] array = new int[sizei,sizej];
FillArray2Rnd(array, rnd, 0, 100);

Console.WriteLine("Масив:"+PrintArray2(array));

Console.WriteLine("Элемент массива i,j:"+Answer(array,i,j));





