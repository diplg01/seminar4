// Задача 1: сумма чисел от 1 до A.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for(int i = 1; i <= A; i++)
{
    sum += i;
    Console.Write(i + " ");
}
Console.WriteLine();
int j = 1;
while(j <= A)
{
    Console.Write(j + " ");
    j++;
}
Console.WriteLine();
Console.WriteLine(sum);