//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, соответствующую дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void Day (int num) 
{
  if (num == 6 || num == 7) 
  {
  Console.WriteLine("Этот день выходной");
  }
  else if (num < 1 || num > 7) 
  {
    Console.WriteLine("Вы ввели не верное значение дня недели");
  }
  else Console.WriteLine("Этот день не выходной ");
}
Day(num);