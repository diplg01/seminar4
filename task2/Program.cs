// произведение чисел от 1 до N

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 1; i <= N; i++)
{
    Console.Write(i + " ");
    sum = sum * i;

}
Console.WriteLine(sum);