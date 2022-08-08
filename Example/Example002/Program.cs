Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int z = Convert.ToInt32(Console.ReadLine());
if (a>b) 
{
    if (a>z)
    {
        Console.WriteLine("Максимальное число = " + a);
    }
    else
    {
       Console.WriteLine("Максимальное число = " + z); 
    }
}
if (b>a) 
{
    if (b>z)
    {
        Console.WriteLine("Максимальное число = " + b);
    }
    else
    {
       Console.WriteLine("Максимальное число = " + z); 
    }
}