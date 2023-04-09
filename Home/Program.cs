/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число для сравнения ");

int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число для сравнения ");

int numberB = int.Parse(Console.ReadLine());

if (numberA < numberB){

    Console.WriteLine("Большее число" + numberB);

 Console.WriteLine("Меньшее число" + numberA);
}

*/


/*Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22


Console.WriteLine( "Введите число 1 ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число 2 ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine( "Введите число 3 ");
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB | numberA > numberC){
    Console.WriteLine("Максимальное число" + numberA);
}
else {
    Console.WriteLine("Максимальное число" + numberC);
}
if  (numberB > numberC){
    Console.WriteLine("Максимальное число" + numberB);
}
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.WriteLine("Введите число ");
string input = (Console.ReadLine());
int number = int.Parse(input);
int number2 = 2;
    if (number % number2 == 0){
    Console.WriteLine("Это четное число");
}
    else{

Console.WriteLine("Это нечетное число");
}
*/


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8


Console.WriteLine( "Введите число ");
int N = int.Parse(Console.ReadLine());
int a = 1;
while  (a <= N)
{
    if (a % 2 == 0)
    Console.WriteLine($"Четные числа {a}");
    a = a + 1;
}

*/