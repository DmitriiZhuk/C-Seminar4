/*
Задача 2:* Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
(для получения цифр числа операцию приведения числа к строке не использовать)
452 -> 6
82 -> 2
9012 -> 3
23 -> 0
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// 1 часть - получаю длину числа
int temp = num;
int counter = 1;
while (temp / 10 != 0)
{
    temp /= 10;
    counter++;
}
Console.WriteLine("Длина числа = " + counter);

// 2 часть - получаю каждое число отдельно в массив
temp = num;
int[] numArray = new int[counter];
for (int i = 0; i < counter; i++)
{
    numArray[i] = temp % 10;
    temp /= 10;
}
Console.WriteLine("Содержимое массива = " + string.Join(" ", numArray));

// 3 часть - сумму цифр в числе, которые являются делителями этого числа
int sumDel = 0;

for (int j = 0; j < counter; j++)
{
    if (numArray[j] != 0)
    {
        if (num % numArray[j] == 0)
        {
            sumDel = sumDel + numArray[j];
        }
    }
}
Console.WriteLine("Сумма цифр = " + sumDel);
