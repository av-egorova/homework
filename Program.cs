/*void PrintRange(int n, int m = 1)
{
if (m > n)
{
Console.WriteLine();
return;
}

Console.Write($"{m} ");

PrintRange(n, m + 1);
}

PrintRange(5);

PrintRange(12);*/



/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
void PrintNumbers(int m, int n)
{
if (m <= n)
{
Console.Write(m + " "); 
PrintNumbers(m + 1, n); 
}
}


{
Console.Write("Write number m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write number n: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNumbers(m, n);
Console.WriteLine();
}*/

/*// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int akkerman(int m, int n)
{
if (m == 0) 
return n + 1;
else 
if (n == 0) 
return akkerman(m - 1, 1);
else 
return akkerman(m - 1, akkerman(m, n - 1));
}


{
Console.Write("Write number n: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Write number m: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Function Akkerman =  {akkerman(n, m)} ");
}*/



// 3 задача. Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.



// int[] arr = { 1, 2, 3, 4, 5 };
//         PrintArrayReverse(arr, arr.Length - 1);


//      void PrintArrayReverse(int[] arr, int index)
//     {
//         if (index < 0)
//             return;

//         Console.Write(arr[index]);
//         PrintArrayReverse(arr, index - 1);
//     }


int[] array = { 1, 2, 5, 0, 10, 34 };


PrintReversedArray(array, array.Length - 1);

void PrintReversedArray(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array[index] + " ");
    PrintReversedArray(array, index - 1);
}




