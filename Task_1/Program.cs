// Напишите программу, которая на авход принимает число и выводит его квадрат
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num*num;
System.Console.WriteLine("Квадрат введенного числа равен " +result);