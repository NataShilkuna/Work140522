// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

int day = new Random().Next(1, 7);
Console.WriteLine(day);

//1 способ
//if(day<=5){Console.WriteLine(day + " -> рабочий");}  
//else{Console.WriteLine(day + " -> выходной");}

//2 способ 
Console.WriteLine(day<=5 ? day + " -> рабочий" : day + " -> выходной");
