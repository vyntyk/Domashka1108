/*Задача 19
Напишите программу, которая принимает на вход
 пятизначное число и проверяет, является 
 ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите число для проверки палиндрома: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((number == 0) || (Reverse(number, 0) == number));

int Reverse(int number, int revers)
{
    while (number > 0)
    { 
        revers = revers * 10 + number % 10; 
        number /= 10; 
    }
    return revers;
}