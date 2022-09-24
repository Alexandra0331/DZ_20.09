Console.Write ("Введите цифру дня недели: " );
// Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDay0fTheWeek (int dayNumber){
  if (dayNumber == 6 || dayNumber == 7) {
 Console.WriteLine ("(этот день выходной) -> yes"); 
}
else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine ("этo не день недели");
}
else Console.WriteLine("(этот день не выходной) -> no");
}
CheckingTheDay0fTheWeek (dayNumber);