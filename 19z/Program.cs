Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine()), n0, n1, n2, n3, n4;
while (n > 99999 || n < 10000)
{
    Console.WriteLine("Введено неверное число, введите заного: ");
    n = Convert.ToInt32(Console.ReadLine());
}
n4 = n % 10;
n = n / 10;
n3 = n % 10;
n = n / 10;
n2 = n % 10;
n = n / 10;
n1 = n % 10;
n = n / 10;
n0 = n;
if (n0 == n4 && n1 == n3)
{
    Console.WriteLine("Число является палиндромом");
}
else
    Console.WriteLine("Число не является палиндромом");