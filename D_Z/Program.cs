
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// Console.WriteLine("Введите число");
// int A = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int B = int.Parse(Console.ReadLine());

// int naturalDegree = A;
// for (int i = 1; i < B; i ++)
// {
//     naturalDegree = naturalDegree * A;
// }

// Console.WriteLine("Натуральная степень = " + naturalDegree );



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число");
// int a = int.Parse(Console.ReadLine());
// int sum = 0;
                                                    
//  while (a > 0)                                      
//   {
//     int num = a % 10;
//     a = a / 10;
//     sum = sum + num;
//   }
// Console.WriteLine("сумма всех числе равна = " + sum);


// Задача 29: Напишите программу, которая генерирует массив из 8 элементов - случайных чисел (от 0 до 20) и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 3 -> [1, 2, 5, 7, 19, 6, 1, 3]

int[] array = new int [8];
Console.Write("[ ");
for (int i = 0; i < 8; i++) 

{
    int randomNumber = new Random().Next(0, 21);
    array[i] = randomNumber;
    Console.Write(" " + array[i] + " ");
}
Console.Write(" ]");
