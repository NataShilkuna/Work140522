﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей
//цифры нет.

//int num = int.Parse(Console.ReadLine()); - необходимо ввести число 
int num = new Random().Next(10, 1000);  /// - случайное число
Console.WriteLine(num>99 ? num + " -> " + num.ToString()[2] : num + " -> третьей цифры нет");