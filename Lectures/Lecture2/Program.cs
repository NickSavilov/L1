﻿// Поиск максимального числа классический.

// int a1=15;
// int b1=21;
// int c1=39;
// int a2=12;
// int b2=23;
// int c2=33;
// int a3=13;
// int b3=23;
// int c3=33;

// int max = a1;
// if(b1>max) max = b1;
// if(c1>max) max = c1;

// if(a2>max) max = a2;
// if(b2>max) max = b2;
// if(c2>max) max = c2;

// if(a3>max) max = a3;
// if(b3>max) max = b3;
// if(c3>max) max = c3;

// Console.WriteLine (max);

// Поиск максимального с помощью функции.

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result;
// }

// int a1=15;
// int b1=21;
// int c1=39;
// int a2=12;
// int b2=23;
// int c2=33;
// int a3=13;
// int b3=23;
// int c3=33;

// // int max1= Max(a1,b1,c1);
// // int max2= Max(a2,b2,c2);
// // int max3= Max(a3,b3,c3);
// // int max=Max (max1,max2,max3);

// // ИЛИ

// int max=Max (Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));

// Console.WriteLine (max);

// ## С массивом из 9 чисел.

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if(arg2>result) result = arg2;
//     if(arg3>result) result = arg3;
//     return result;
// }
// //  ИНДЕКС    0  1  2  3  4  5  6  7  8
// int [] array={11,21,31,41,15,61,17,18,19,};

// int max = Max(
//     Max(array[0],array[1],array[2]),
//     Max(array[3],array[4],array[5]),
//     Max(array[6],array[7],array[8])
// );
// Console.WriteLine (max);

//№№ Поиск позиции нужного элемента. 
// Имеется одномерный масссив array ил n элементов, требуется найти элемент массива, равный find
// 1. Установить счетчик index в позиции 0
// 2. Если array [index]=find, алгоритм завершил работу успешно. 
// 3. Увеличить индекс на 1
// 4. Если index <n, то перейти к шагу 2. В противном случае алгоритм завершил работу безуспшно.

// int[] array = {1,12,31,4,18,15,16,17,18};
// int n = array.Length;
// int find = 18;
// int index = 0;

// while (index<n)
// {
//     if (array[index]==find)
//     {
//         Console.WriteLine (index);
//         break;
//     }

//     index++;
// }

// Поиск индекса числа.

// void FillArray(int [] collection)
// {
//     int Length=collection.Length;
//     int index = 0;
//     while (index<Length)
//     {
//         collection[index] = new Random().Next(1,10); 
//         index++;
//     }
// }

// void PrintArray (int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position<count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }

// }

// int IndexOf(int[] collection, int find)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position=-1;

//      while (index<count)
//      {
//         if (collection[index]==find)
//         {
//             position=index;
//             break;
//         }
//         index++;
//     }
//     return position;
// }

// int [] array = new int[10];

// FillArray(array);
// array [4]=4;
// array [6]=4;
// PrintArray(array);
// Console.WriteLine();

// int pos = IndexOf(array, 3);
// Console.WriteLine(pos);