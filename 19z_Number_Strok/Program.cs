/*Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99999 || n < 10000)
{
    Console.WriteLine("Введено неверное число, введите заного: ");
    n = Convert.ToInt32(Console.ReadLine());
}
string m = n.ToString();
//string m = Convert.ToString(n);
if (m[0] == m[4] && m[1] == m[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");*/
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string? n = Console.ReadLine();
while (n.Length != 5)
{
    Console.WriteLine("Введено неверное число, введите заного: ");
    n = Console.ReadLine();
}
if (n[0] == n[4] && n[1] == n[3])
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
int m = Convert.ToInt32(n);