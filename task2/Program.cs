/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int getSumOfNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    int sum = n;
    return sum + getSumOfNumbers(m, n - 1);
}

Console.Write("Введите число M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int sum = getSumOfNumbers(userNumberM, userNumberN);
Console.WriteLine(sum);


