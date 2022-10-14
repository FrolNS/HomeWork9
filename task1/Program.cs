/*
Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void getNumbers(int n)
{
    if (n != 0)
    {
        if(n != 1)
        {
            Console.Write($"{n}, ");
            getNumbers(n - 1);
        }
        else 
        {
            Console.Write($"{n}");
        }
    }
}

Console.Write("Введите число N: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
getNumbers(userNumber);