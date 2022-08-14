Console.Write("Число a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Число b = ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("max = " + a + ", min = " + b);    
} else {Console.WriteLine("max = " + b + ", min = " + a);}

Console.Write("Число a = ");
int a1 = int.Parse(Console.ReadLine());
Console.Write("Число b = ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Число c = ");
int c1 = int.Parse(Console.ReadLine());
int max = a1;
if (max < b1) {
    max = b1;     
} 
if (max < c1) {
    max = c1;
}
Console.WriteLine("max = " + max);

Console.Write("Число для проверки = ");
int a2 = int.Parse(Console.ReadLine());
if (a2 % 2 == 0)
{
    Console.WriteLine(a2 + "- четное");
} else {Console.WriteLine(a2 + "- НЕ четное");}

Console.Write("Число N = ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n+1; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    } 
}
