Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99999 || n < 10000)
{
    Console.WriteLine("Введено неверное число, введите заного: ");
    n = Convert.ToInt32(Console.ReadLine());
}
string m = Convert.ToString(n);
if (m[0] == m[4] && m[1] == m[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");