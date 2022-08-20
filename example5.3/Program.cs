double GetNum(string message)
{
    Console.Write(message);
    double res = double.Parse(Console.ReadLine());
    return res;
}

string PrintArray(double[] array)
{
    string res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        res = res + array[i];
        if (i < array.Length-1)
        {
            res = res + "; ";
        }
    }
    res = res + "]";
    return res;
}

Random rnd = new Random();
int size = rnd.Next(3,8);
double[] array = new double[size];

Console.WriteLine("Введите массив вещественных чисел:");
for (int i = 0; i < size; i++)
{
    int index = i+1;
    array[i] = GetNum("Введите " + index + "-e число массива:");
}

Console.Write("Масив:"+PrintArray(array));

Array.Sort(array);
double answer = array[size-1] - array[0];

Console.Write(", разница между масимальным и минимальным элементом массива: " + answer);


