Console.Write("Введи трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string Num2 = Convert.ToString(Number);

if (Num2.Length <= 2 || Num2.Length > 3)
{
    Console.WriteLine("!! Введённое число не является трёхзначным !!");
}

else if (Num2.Length > 2)
{
    Console.WriteLine("Вторая цифра введённого трёхзначного числа: " + Num2[1]);
}