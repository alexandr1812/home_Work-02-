// Тут у меня два решения этой задачи

// int number = Convert.ToInt32(Console.ReadLine());
// int numberA = number % 10;
// if (number > 999)
// {
//     numberA = number % 100/10;
// }
// if (number > 1999)
// {
//     numberA = number % 1000/100;
// }
// if (number > 99)
// {
//      Console.WriteLine (numberA);
// }
// else{
//     Console.WriteLine ("цифры нет");
// }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberA = Convert.ToString(number);
if (numberA.Length > 2)
{
    Console.WriteLine("третье число -> " + numberA[2]);
}
else
{
     Console.WriteLine("третьей цифры нет");
}
