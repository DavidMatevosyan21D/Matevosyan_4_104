﻿Console.WriteLine("Введите номер дня недели");
 int a = int.Parse(Console.ReadLine());

switch(a)
    {
    case 1:
        Console.WriteLine(day.Monday);
        break;
    case 2:
        Console.WriteLine(day.Tuesday);
        break;
    case 3:
        Console.WriteLine(day.Wednesday);
        break;
    case 4:
        Console.WriteLine(day.Thursday);
        break;
    case 5:
        Console.WriteLine(day.Friday);
        break;
    case 6:
        Console.WriteLine(day.Saturday);
        break;
    case 7:
        Console.WriteLine(day.Sunday);
        break;
    default:
        Console.WriteLine("Такого дня нет");
        break;

}

enum day
 {
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
