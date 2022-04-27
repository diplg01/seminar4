//количество цифр в числе

//string a = Convert.ToString(199234);
//Console.WriteLine(a.Length);

int a = 1234;
int count = 0;
while (a > 0)
{
    a = a / 10;
    count++;
}
Console.WriteLine(count);





