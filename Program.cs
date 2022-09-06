try
{
Console.WriteLine ("Введите трёхзначное число");
int a = Convert.ToInt32 (Console.ReadLine ());
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
int a2 = ((a % 100) - (a % 10)) / 10;
Console.WriteLine ("Вторая цифра " + a2);
};
}
catch 
{
Console.WriteLine ("Нужно ввести трёхзначное число!");
};

