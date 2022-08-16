// Изначально решение, ниже это же код, но внутри метода

// {
//     Console.WriteLine("Введите число дня недели и узнайте сегодня выходной или нет");
//     int numberDays = Convert.ToInt32(Console.ReadLine());

// if (numberDays == 6 | numberDays == 7)
// {
//     Console.WriteLine("Да, это выходной день");
    
// }
// else if (numberDays < 1 | numberDays > 7)
//     {
//         Console.WriteLine("Такого дня недели не существует");
//     }

// else 
// Console.WriteLine("нет, это рабочий"); 

// }

// Метод 

Console.WriteLine("Введите число дня недели и узнайте сегодня выходной или нет");
int numberDays = Convert.ToInt32(Console.ReadLine());
bool Checkweekend(int numberDays)
{
    if (numberDays == 6 | numberDays == 7)
    {
        return true;
    }

    else if (numberDays < 6 | numberDays > 0)
    {
        return false;
    }

    return true | false;

}

Checkweekend(numberDays);
bool result = Checkweekend(numberDays);
if (result == true)
{
    Console.WriteLine("Да, это выходной день");
}

else if (result == false)
{
    Console.WriteLine("Нет, это рабочий день");
}