int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int n = GetNum("Введите число N:");

Console.Write("Сумма цифр N:");

int sum = 0;
int index = 0;
while(n > 0) {
    sum = sum + n % 10; 
    n = n/10;
    index++;     
}  

Console.Write(sum);