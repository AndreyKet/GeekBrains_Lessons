// Console.WriteLine("Hello, World!");
// int x = 5; //целочисленные
// double y = 2.4; //цисла с плавающей точкой, дробные
// string str = "Hello World!"; //строчные данные, строки
// bool b = y > x; // 2.5 > 5 == false юуленговые значения True/False


//Блок кода - пространство между двух фегурных скобочек {}

// if...else - Витвление
// if ( x == 5 )
// {
//     Console.WriteLine("x это пять");
// }
// else
// {
//     Console.WriteLine("x это Не пять");
// }

// //Цикл
// int a = 0
// while (a < 5)
// //Если условия в скобках верны выполняется даннй блок кода
// {
//     Console.WriteLine(a);
//     a++; //увеличивает значение а на 1, счетчик
//     //равнозначно с:
//     //а = а + 1;
//     //а += 1;
// }

//Напишием программу: программма получается данные с консоли
// возводит в квадрат и выводит на экран.

// Console.Write("Введите число ");
// string str = Console.ReadLine();
// int nummber = int.Parse(str);

// int square = nummber * nummber;

// Console.WriteLine("Квадрат вашего числа " + square);


// Задача #1
// Console.WriteLine("Введите первое число");
// string n1 = Console.ReadLine();
// int a = int.Parse(n1);
// Console.WriteLine("Введите второе число");
// string n2 = Console.ReadLine();
// int b = int.Parse(n2);
// if (a == b * b)
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }


// Console.WriteLine("Введите число ");
// string str = Console.ReadLine();
// int a = int.Parse(str);
// int b = a * -1;
// while (b <= a)
// {
//     Console.Write(b + " ");
//     b++;
// }

/////////////////////////////////////////////////////////

//Урок 1. Знакомство с языками программирования С#

//Практическое задание:

//Задача 2: Напишите программу, которая на вход принимает два
//числа и выдает, какое число больше а каоке меньше.


// Console.WriteLine("Введите первое число");
// string n1 = Console.ReadLine();
// int a = int.Parse(n1);
// Console.WriteLine("Введите второе число");
// string n2 = Console.ReadLine();
// int b = int.Parse(n2);
// if (a > b)
// {
//     Console.WriteLine("Max " + a);
//     Console.WriteLine("Min " + b);
// }
// else
// {
//     Console.WriteLine("Max " + b);
//     Console.WriteLine("Min " + a);
// }

////////////////////////////////////////////////////////////

//Задача 4: Напишите программу, котора принимает на 
//вход три числа и выдает максимальное из этих чисел


// Console.WriteLine("Введите числа ");
// string n1 = Console.ReadLine();
// int a = int.Parse(n1);
// string n2 = Console.ReadLine();
// int b = int.Parse(n2);
// string n3 = Console.ReadLine();
// int c = int.Parse(n3);

// if (a > b)
// { 
//     if (a > c)
//     {
//         Console.WriteLine("Max " + a);
//     }
//     else
//     {
//     Console.WriteLine("Max " + b);
//     }
// }
// else
// {
//     Console.WriteLine("Max " + c);
// }

/////////////////////////////////////////////////////////

//Задача 6: Напишите программу, которая на вход
//принимает число и выдает, является ли чосло четным 
//или нет.


// Console.WriteLine("Введите число ");
// string number = Console.ReadLine();
// int n = int.Parse(number);
// if (n % 2 == 0)
// {
//     Console.WriteLine("Четное число");
// }
// else
// {
//     Console.WriteLine("Не Четное число");
//}

/////////////////////////////////////////////////////

//Задача 8: Напишите программу, которая на входе
//принимает число (N), а на выходе показывает все
// все четные числа от 1 до N


Console.Write("Введите число ");
string number = Console.ReadLine();
int n = int.Parse(number);
int m = 1;

while (m <= n)
{
    if (m % 2 == 0)
    {
        Console.WriteLine(m);
    }
    m++;
}