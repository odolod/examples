string PrintArray(int[] array)
{
    string res = "[";
    for (int i = 0; i < array.Length; i++)
    {
        res = res + array[i];
        if (i < array.Length-1)
        {
            res = res + ", ";
        }
    }
    res = res + "]";
    return res;
}

void FillArrayRnd(int[] array, Random rnd, int minValue, int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
}

Random rnd = new Random();
int size = rnd.Next(3,15);
int[] array = new int[size];
FillArrayRnd(array, rnd, -100, 100);

int answer = 0;

for (int i = 1; i < size; i = i+2)
{
    answer = answer + array[i];
}

Console.Write("Масив:"+PrintArray(array));
Console.Write(", сумма чисел на нечетных позициях: " + answer);

