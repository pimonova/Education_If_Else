﻿Console.WriteLine("Выбор первого игрока (камень, ножницы, бумага):");
string item1 = Console.ReadLine();
Console.Clear();
Console.WriteLine("Выбор второго игрока (камень, ножницы, бумага):");
string item2 = Console.ReadLine();
if (((item1 == "Камень")&&(item2 == "Ножницы"))||((item1 == "Ножницы")&& (item2 == "Бумага"))||((item1 == "Бумага")&&(item2 == "Камень")))
    Console.WriteLine($"Первый игрок выбрал '{item1}', второй игрок выбрал '{item2}'.Выиграл первый игрок ");

if (((item1 == "Камень")&&(item2 == "Бумага"))||((item1 == "Ножницы")&&(item2 == "Камень"))||((item1 == "Бумага")&&(item2 == "Ножницы")))
    Console.WriteLine($"Первый игрок выбрал '{item1}', второй игрок выбрал '{item2}'.Выиграл второй игрок ");

if (item1 == item2)
    Console.WriteLine($"Первый игрок выбрал '{item1}', второй игрок выбрал '{item2}'. Получилась ничья");
