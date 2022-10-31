/*
int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
    
        sum += current;
    
    return sum;
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);

Console.WriteLine($"Sum of elements from 1 to {num} is {s}");\
*/

// Напишите программу, которая принимает на вход число
// и выдает количество цифр в числе.

/*
int DigitNumbers(int a)
/*
{
    int div = 10;
    int cur = 1;

    for(int n = a; n > 10; cur ++)
    {
        n = a / div;
        div *= 10;
    }
    return cur;
*/
/*
{   
    int count = 0;// тоже правильное решение
    while(a > 0) 
    {
      a /= 10;
      count++;  
    }
    return count;
    
    
}

Console.Write("Введите положительное число: " );
int a = Convert.ToInt32(Console.ReadLine());
int res = DigitNumbers(a);
Console.WriteLine(res);
*/

// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N

/*
int Factorial(int N)
{
    int fact = 1;
    for(int current = 1; current <= N; current ++)
        fact *= current;
    return fact;    
}
Console.Write("Enter a number: " );
int a = Convert.ToInt32(Console.ReadLine());
int res = Factorial(a);
Console.WriteLine(res);
*/

// Написать программу, которая выводит массив 
// из N элементов заполненный 0 и 1 в случайном порядке

/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
         Console.Write(array[i] + " ");

    Console.WriteLine();   
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/