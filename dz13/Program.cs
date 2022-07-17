// Задача 13: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.

int n;
Console.WriteLine("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
if (n<=99)
{
    Console.WriteLine("третьей цифры нет");
} 
if (n>99)
{
    String str = n.ToString ();
   Console.WriteLine(str[2]); 
}
