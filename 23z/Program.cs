Console.Clear();
Console.WriteLine("Программа выполняет возведение чисел в куб от 1 до n");
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine()), i;
for (i = 1; i <= n; i++)
Console.WriteLine($"Число {i} в кубе = {Math.Pow(i, 3)}");