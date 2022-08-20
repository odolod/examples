int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

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

int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    int index = i+1;
    array[i] = GetNum("Введите " + index + "-e число массива:");
}

Console.Write("Масив:"+PrintArray(array));
Array.Sort(array);
Console.Write(", второй максимум: " + array[6]);



/* Console.Write("Сумма цифр N:");

int sum = 0;
int index = 0;
while(n > 0) {
    sum = sum + n % 10; 
    n = n/10;
    index++;     
}  

Console.Write(sum); */