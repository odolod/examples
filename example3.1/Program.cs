int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int GetDigit(int value, int digit)
{
    int[] stack = new int[5];
    int index = 0;
    while(value > 0) {
        stack[index] = value % 10; 
        value = value/10;
        index++;     
    }  
    return stack[digit-1];
}

int userNum = GetNum("Введите пятизначное число: ");

if (userNum > 9999 && userNum < 1000000)
{
    if (GetDigit(userNum,1) == GetDigit(userNum,5) && GetDigit(userNum,2) == GetDigit(userNum,4))
    {
        Console.WriteLine("Число палиндром!");            
    } else
    {
        Console.WriteLine("Число НЕ палиндром!");
    }
} else
{
    Console.WriteLine("Число не пятизначное"); 
}
