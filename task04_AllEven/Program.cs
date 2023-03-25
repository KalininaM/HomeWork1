// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  Например, 5 -> 2, 4
Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine());

string even = "";

if (number != 1 && number != 0)
{
    for (int i = 1; i < number + 1; i ++){
        if (i % 2 == 0){
            even = even + i.ToString() + " ";
        }
    }
    Console.WriteLine(even);
}
else{
    Console.WriteLine("Четных чисел нет");
}