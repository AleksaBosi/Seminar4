// void Main()
// {
//     Console.WriteLine("Введите число.");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int result = 0;
//     while (number > 0)
//     {
//         result = result + number % 10;
//         number /= 10;
//     }
//     Console.WriteLine($"Сумма цифр в числе {result}");
// }
// Main();

void Main()
{
    Console.WriteLine("Введите число.");
    string number = Console.ReadLine();
    int res = 0;
    for (int i = 0; i < number.Length; i++)
    {
        res += Int32.Parse(number[i].ToString());
    }
    Console.WriteLine($"Сумма цифр в числе {res}");
}
Main();