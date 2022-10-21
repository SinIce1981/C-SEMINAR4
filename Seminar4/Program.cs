// Напишите прорамму  которая принимает на вход число А и выдает  сумму чисел от 1 до А

void Zadacha24()
{
    int number = 5;
    int sum = 0;

    for ( int i = 1; i <=number; i++)
    {
        // Console.Write($"{i}" );
        sum += i;
    }
    Console.Write($"{sum}" );
}
// Zadacha24();

// Задача 26. Напишите программу, которая принимает 
// на вход число  и выдает количесство цифр  в числе

void Zadacha26()
{
    int number = 123451216;
    int current = number;
    int count = 0;
    while (current > 0)
    {
        current = current / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {number} = {count} ");

}
// Zadacha26();

// Задача 28. Напишите программу, которая принимает  на вход число Н
//  и выдает произведение  чисел от 1 до Н

void Zadacha28()
{
    int number = 5;
    int proizv = 1;

    for ( int i = 1; i <=number; i++)
    {
        // Console.Write($"{i}" );
        proizv *= i;
    }
    Console.Write($"{proizv}" );
}
// Zadacha28();

// Задача 30. Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами  в случайном порядке

void Zadacha30()
{
    Random random = new Random();
    int size = random.Next(4, 10);
    int[] numbers = new int[size];
    Console.WriteLine(size);
     
    FillArray(numbers);
    PrintArray(numbers);

    // for (int i = 0; i<size; i++)
    // {
    //     numbers[i] = random.Next(0, 2);
    // }
    // for (int i = 0; i<size; i++)
    // {
    //     Console.Write(numbers[i] + " " );
       
    // }
     Console.WriteLine();
}

void FillArray(int[]num)
{
    Random random = new Random();
    for (int i = 0; i<num.Length; i++)
    {
        num[i] = random.Next(0, 2);
 
    }
}
    void PrintArray(int[]num)
{
    Random random = new Random();
    for (int i = 0; i<num.Length; i++)
    {
        Console.Write(num[i]+ "  ");
    }
}
Zadacha30 ();