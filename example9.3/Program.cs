int GetNum(string message)
{
    Console.Write(message);
    int res = int.Parse(Console.ReadLine());
    return res;
}

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

int n = GetNum("Задайте число N:");
int m = GetNum("Задайте число M:");
Console.Write("A(N,M)="+A(n,m).ToString());
