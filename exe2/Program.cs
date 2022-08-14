int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int userNum = GetNum("Введите трехзначное число: ");
Console.WriteLine(userNum / 10 % 10);

int random = new Random().Next(100, 999);
Console.WriteLine("Случайное трехзначное число: " + random);
Console.WriteLine("     Число без второй цифры: " + random / 100 % 10 + " " + random % 10);

int userNum1 = GetNum("Введите число: ");
if (userNum1 / 100 > 0)
{
    Console.WriteLine("третья цифра: " + userNum1 % 10);
} else
{
    Console.WriteLine("третьей цифры нет!");
}

int userNum2 = GetNum("Введите день недели числом: ");
if (userNum2 == 6 ^ userNum2 == 7)
{
    Console.WriteLine("Выходной!");
}
