//int a = 5; // целочисленный 32 бит ограничение 

//double b = 23.6; // вещественный с дробной частью 

//bool c = true;  // логический тип true or folse

//string d = "строка это набор массив символов ";

//char e = 'd';

//Console.WriteLine("переменной а присвоно значение = " + a); // конкотинация ОБЬЕДИНЕНИЕ сложение строк 


//Console.WriteLine("пример два числа " + a + " and " + b + " вот так");

//Console.WriteLine($"изящный пример двух чисел {a} and {b} nice"); // кривый кавычки лучше {{{{}}}}

/* пишем микропрогу
Console.Write("напиши число: ");
int number = Convert.ToInt32(Console.ReadLine()); // скобки производятся в первую очередь
Console.WriteLine(number);
*/

/*Seminar 1
апишите программу, которая на вход принимает два числа 
и проверяет,
 является ли первое число квадратом второго.*/

/*Console.WriteLine("введи два числа через энтер для проверки  ");
Console.WriteLine("является ли первое число квалратом второго:  ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("первое число  " + number1);
Console.WriteLine("второе число  " + number2);

int quad2 = number2 * number2;

if(number1 == quad2)
{
    Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No!");
}*/

/* Seminar 1 задача 2 
Напишите программу, которая на вход принимает одно число (N), а на 
выходе показывает все целые числа в промежутке от -N до N.*/

/*Console.WriteLine("Данная программа показывает все целые числа в промежутке от -N до +N" );
Console.WriteLine("Введите пожалуйста число N: ");

int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while(current <= num)
{
    Console.Write(current + " ");
    current = current+1; //current += 1 прибовляем  1
} 

*/
/*
32465 / 10 = 3245
32465 / 100 = 325
32465 / 1000 = 32
32465 / 10000 = 3

32465 % 10 = 5
32465 % 100 = 65
32465 % 1000 = 465
32465 % 10000 = 2465*/
