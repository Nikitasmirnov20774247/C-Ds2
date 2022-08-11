Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string FinelNumber = Convert.ToString(Number);

if (FinelNumber.Length <= 2)
{
  Console.WriteLine("!! третьей цифры нет !!");
}

else if (FinelNumber.Length > 2)
{
  Console.WriteLine("третья цифра -> " + FinelNumber[2]);
}