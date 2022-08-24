double GetNum(string message)
{
    Console.Write(message);
    double res = double.Parse(Console.ReadLine());
    return res;
}

string Intersect(double k1,double b1,double k2,double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = (k1*(b2-b1))/(k1-k2)+b1;
    string res = "(" + x + ":" + y + ")";
    return res;
}

double k1 = GetNum("Введите k1:");
double b1 = GetNum("Введите b1:");
double k2 = GetNum("Введите k2:");
double b2 = GetNum("Введите b2:");

if (k1 == k2 & b1 == b2)
{
    Console.Write("Прямые совпадают! (бесконечно точек пересечения)");
} else if (k1 == k2)
{
    Console.Write("Прямые паралельны! (нет точек пересечения)");
} else Console.Write("Точка пересечения:"+Intersect(k1,b1,k2,b2));

    
