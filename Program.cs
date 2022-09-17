Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine(a + " " + "= max," + b +" " + "= min");
}
else if(a<b)
{
    Console.WriteLine(b + " "+ "= max," + a + " " + "= min");
}
else if(a==b)
{
    Console.WriteLine(a + " "+ "=" +" " + b);
}
