Console.WriteLine("Введите первое число: ");
string str1 = Console.ReadLine();
int ask = Convert.ToInt32(str1);
Console.WriteLine("Введите второе число: ");
string str2 = Console.ReadLine();
int ask2 = Convert.ToInt32(str2);
if (ask > ask2)
{
    Console.WriteLine (ask);
}
else
Console.WriteLine ("Наибольшее число: ");
Console.WriteLine (ask2);
