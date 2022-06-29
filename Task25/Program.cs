Console.WriteLine("Введите первое число.");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число.");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result * a;
}
Console.WriteLine($"Первое число в натуральной степени второго числа {result}");
