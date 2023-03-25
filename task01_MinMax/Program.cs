// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

int min = a;
int max = b;

if (a > b){
    min = b;
    max = a;
}

Console.WriteLine("max = " + max.ToString());
Console.WriteLine("min = " + min.ToString());
