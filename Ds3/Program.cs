Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void День_недели (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("Этот день выходной? -- да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("!! Такого дня нет !!");
  }
  else Console.WriteLine("Этот день выходной? -- нет");
}

День_недели (dayNumber);