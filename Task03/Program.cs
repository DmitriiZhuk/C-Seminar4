/*
Задача 3:*(Дополнительная, не обязательная задача): Назовём число «интересным» если его 
произведение цифр делится на их сумму. Напишите программу, которая заполняет массив на N 
«интересных» случайных целых чисел. (Каждый эл-т массива должен быть сгенерирован случайно)
*/

/*
Предисловие от автора - сначала делал просто пошагово без зацикливаний и методов
потому получилось весьма громоздко
*/

// Поиск и возврат либо интересного числа либо просто какого-то числа один (1)
// 1 ниже используется в функции перебора
int SearchInterestNum()
{
    //10000 взято просто - можно поставить Int32.MaxValue
    int randomNumber = new Random().Next(1, 10000);
    // Console.WriteLine("Сгенерированное случайное число = " + randomNumber);

    //Пробую делать через функцию - получения длины числа
    //потому что раньше не делал через функции - новый опыт
    int NumberLength(int number)
    {
        int counter = 1;
        while (number / 10 != 0)
        {
            number /= 10;
            counter++;
        }
        return counter;
    }

    int length = NumberLength(randomNumber);
    // Console.WriteLine("Длина сгенерированного случайного числа = " + length);

    //1 заношу его в массив где будет все перемножаться и суммироваться
    int[] array = new int[length];
    int temp = randomNumber;
    for (int i = 0; i < length; i++)
    {
        array[i] = temp % 10;
        temp /= 10;
    }
    //Console.WriteLine("Содержимое массива = " + string.Join(" ", array));

    //2 перемножаю, суммирую
    int multiple = 1;
    int sum = 0;

    for (int j = 0; j < length; j++)
    {
        multiple = multiple * array[j];
        sum = sum + array[j];
    }
    //Console.WriteLine("Произведение цифр = " + multiple + " , сумма чисел цифр = " + sum);

    //3 произведение цифр делится на их сумму
    if (multiple % sum == 0)
    {
        //    Console.WriteLine(randomNumber + " = произведение цифр делится на их сумму");
        return randomNumber;
    }
    else
    {
        //   Console.WriteLine(randomNumber + " произведение цифр НЕ делится на их сумму");
        return 1;
    }

}


/*
Сгенерированное случайное число = 9042
Длина сгенерированного случайного числа = 4
Содержимое массива = 2 4 0 9
Произведение чисел = 0 , сумма чисел = 15
произведение цифр делится на их сумму
и
Сгенерированное случайное число = 7558
Длина сгенерированного случайного числа = 4
Содержимое массива = 8 5 5 7
Произведение чисел = 1400 , сумма чисел = 25
произведение цифр делится на их сумму

оба формально подходят  - то есть и 9042 и 7558 далее должны быть занесены в массив;
хоть и при 9042 произведение чисел = 0 , сумма чисел = 15 
 Однако, ноль можно поделить на 15
*/

// Функция поиска числа перебором
int loto()
{
    int lotoNum;
    do
    {
        lotoNum = SearchInterestNum();
    } while (lotoNum == 1);

    return lotoNum;

}

Console.Write("Введите размер массива: ");
int arrNum = Convert.ToInt32(Console.ReadLine());

int[] interestArray = new int[arrNum];
for (int k = 0; k < arrNum; k++)
{
    int checkNum = loto();
    interestArray[k] = checkNum;
}

Console.WriteLine("Содержимое интересного массива = " + string.Join(" ", interestArray));