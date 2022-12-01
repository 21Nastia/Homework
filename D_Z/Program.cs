// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[4]; // 4 - размер (количество) 
// int evenNumber = 0;

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     array[i] = new Random().Next(255, 800); // генерируем случайное число 
//     Console.WriteLine(" " + array[i]);
//     int currentNumber = array[i];


// if(currentNumber % 2 == 0) 
// {
//     evenNumber ++;
// }
 
// }
// Console.WriteLine($"Колличество четных чичел: " + evenNumber);




// // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0


        //  var rnd = new Random();
        //     var arr = new int[4];
 
        //     for (int i = 0; i < arr.Length; i++)
        //         Console.Write("{0}\t", arr[i] = rnd.Next(0, 10));
        //     Console.WriteLine();
 
        //     var odd = arr.Where((element, index) => index % 2 != 0);
            
 
        //     Console.WriteLine("Не чётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
            
 
        //     Console.ReadKey();



        // Задача 38: Задайте массив вещественных чисел. 
        // Найдите разницу между максимальным и минимальным элементов массива.
        // [3 7 22 2 78] -> 76


// Random rnd = new Random();
//             int[] d = new int[5];
//             int max = 0, min = 100;

//             for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
//             for (int i = 0; i < d.Length; i++)
//             {
//                 if (d[i] > max) max = d[i];
//                 if (d[i] < min) min = d[i];
//             }
           
//                for (int i = 0; i < d.Length; i++) Console.Write(" " + d[i]);//выводим массив
//                Console.WriteLine();
//                  Console.WriteLine("max:  " + max);
//                  Console.WriteLine("min:  " + min);
//                  Console.WriteLine("Разница максимального и минимального:  "+(max - min));
//                 Console.ReadKey();



