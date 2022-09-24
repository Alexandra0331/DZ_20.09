Console.Write ("Введите 3-х значное число: ");
// 10. Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int Number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(Number);
Console.WriteLine("вторая цифра числа -> "+stringNumber[1]);