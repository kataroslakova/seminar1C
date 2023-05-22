// Напишите программу, которая на авход принимает число и выводит его квадрат
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
System.Console.WriteLine("Квадрат введенного числа равен " + result);
// git remote add origin https://github.com/kataroslakova/seminar1C.git
// git branch -M main
// git push -u origin main

if (num > 0)
{
    System.Console.WriteLine("Вы ввели положительное число");
}
else if (num == 0)
    System.Console.WriteLine("Вы ввели ноль");
else
    System.Console.WriteLine("Вы ввели отрицательное число");