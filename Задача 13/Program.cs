Console.Write ("Введите число: ");
//13. Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int Number = Convert.ToInt32(Console.ReadLine ());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2) 
{
    Console.Write ("3-я цифра -> " + NumberText[2]);
}
else 
{
    Console.Write ("-> 3-ей цифры нет");
}