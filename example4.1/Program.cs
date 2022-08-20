
int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int a = GetNum("Введите число которое будет возведено в степень:");
int b = GetNum("Введите степень:");

if (b < 0)
{
    Console.Write(b + " не 0 и не натуральное число!");
} else 
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.Write(a + " в степени " + b + " равно: " + result);
}