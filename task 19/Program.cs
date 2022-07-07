// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string [] array = new string[5];
Console.WriteLine("Введите пятизначное число");


array[0] = Convert.ToString(Console.Read());
array[1] = Convert.ToString(Console.Read());
array[2] = Convert.ToString(Console.Read());
array[3] = Convert.ToString(Console.Read());
array[4] = Convert.ToString(Console.Read());   


if (array[0] == array[4] && array[1] == array[3]) 
Console.WriteLine("Число является палиндромом");

else Console.WriteLine("Число не является палиндромом");

