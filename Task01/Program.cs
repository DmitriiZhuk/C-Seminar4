Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int pow = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < pow; i++)
{
    result = result * num;
}

Console.WriteLine("Результат возведения числа " + num + " в степень " + pow + " = " + result);

