try
{
Console.WriteLine ("Введите целое число");
int a = Convert.ToInt32 ( Console.ReadLine () );
if (a > 999) 
{
Console.WriteLine ("Нужно ввести трёхзначное число!");
}
else if (a < 100) 
{
Console.WriteLine ("Нужно ввести трёхзначное число!");
}
else 
{
a = a % 10;
Console.WriteLine ("Третья цифра " + a);
}
}
catch 
{
Console.WriteLine ("error");
};

