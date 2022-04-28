// задача 4: выводит массив с 0 и 1

int []mas = new int [15];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = new Random().Next(0, 2);
    Console.Write($"{mas[i]} ");
}

