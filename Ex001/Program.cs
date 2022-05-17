// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int num2 = ((num % 100) / 10); // 1 способ
Console.WriteLine(num + " -> " + num2);

string text = num.ToString(); // 2 способ
Console.WriteLine(text + " -> " + text[1]);

