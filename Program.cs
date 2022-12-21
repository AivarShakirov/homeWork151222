// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

// Console.WriteLine("Введи первое число: ");
// int number1 = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введи второе число: ");
// int number2 = int.Parse(Console.ReadLine()!);

// if (Math.Pow(number2, 2) == number1 ) {
//     Console.WriteLine ($"Число {number1} является квадратом числа {number2} ");}
//     else
//     {
//        Console.WriteLine ($"Число {number1} не является квадратом числа {number2} ");
//     }

//Напишите программу, которая будет выдавать название дня недели по заданному номеру

// Console.WriteLine("Введите номер дня недели: ");
// int num = int.Parse(Console.ReadLine()!);

// if (num == 1) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Понедельник");
// if (num == 2) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Вторник");
// if (num == 3) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Среда");
// if (num == 4) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Четверг");
// if (num == 5) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Пятница");
// if (num == 6) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Суббота");
// if (num == 7) 
//     Console.WriteLine ($"Для числа {num} соотвествует день недели Воскресенье");

//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Последнее число числа {num} является { num % 10}");

// Домашнее задание

//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine ("Введите число 1");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine ("введите число 2");
int num2=int.Parse(Console.ReadLine());
if (num1>num2){
    Console.WriteLine("число 1 больше число 2");
}
else
    Console.WriteLine("число 2 больше число 1");


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine ("Введите число 1");
int num11=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число 2");
int num12=int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите число 3");
int num13=int.Parse(Console.ReadLine()!);
int max=num11;
if (num12>max) max=num12;
if (num13>max) max=num13;
Console.WriteLine ($"максимальное число {max}");


//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine ("Введите число");
int num21=int.Parse(Console.ReadLine()!);
if (num21%2==0) 
Console.WriteLine ("Четное"); 
else 
Console.WriteLine ("Нечетное");


//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите число(N)");
int N=int.Parse(Console.ReadLine()!);
int i=1;
while (i<=N)
{
    if (i%2==0)
    Console.Write($" {i} ");
    i++;
}
