
int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

double distance(int[] a, int [] b)
{
    return Math.Sqrt(Math.Pow(b[0]-a[0], 2)+Math.Pow(b[1]-a[1], 2)+Math.Pow(b[2]-a[2], 2));
}

int ax = GetNum("Введите координату x точки А:");
int ay = GetNum("Введите координату y точки А:");
int az = GetNum("Введите координату z точки А:");

int bx = GetNum("Введите координату x точки B:");
int by = GetNum("Введите координату y точки B:");
int bz = GetNum("Введите координату z точки B:");

int[] a = new int[3] {ax, ay, az};
int[] b = new int[3] {bx, by, bz}; 

Console.WriteLine("Расстояние:" + distance(a,b));