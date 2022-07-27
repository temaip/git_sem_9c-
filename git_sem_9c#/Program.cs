

// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = M; i <= N; i++)
// {
//     Console.Write($"{i} ");
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int x = 0;
// for (int i = M; i <= N; i++)
// {
//     x = x + i;
// }
// Console.Write($"сумма элементов = {x}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int Akkerman = Akk(m, n);

// Console.Write($"Функция Аккермана = {Akkerman} ");

// int Akk(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0 && m > 0) return Akk(m - 1, 1);
//   else return Akk(m - 1, Akk(m, n - 1));
// }





//  с семинара сохрнаил, к дз отношение не имеет 


// Задача 67:** Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{N}->{SumNumbers(N)}");

// int SumNumbers(int number){
//     if (number == 0) return 0;
// return number % 10 + SumNumbers(number/10);
// }