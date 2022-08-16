Console.Clear();
Console.Write("Введи трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numb = num % 100 / 10;
Console.Write ("вторая цифра числа -> ");
Console.WriteLine (numb);
