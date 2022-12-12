Console.WriteLine("введите число");
int N1 =  Convert.ToInt32 (Console.ReadLine()); 


if ( N1 % 23 == 0)
{
    if ( N1 % 7 == 0)
    Console.WriteLine("число кратно 23 и 7");
}
else
{
    Console.WriteLine("не кратно");
}