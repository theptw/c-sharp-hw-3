// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



// int cube(int n)
// {
//     int i = 1;
    

//     while (i<=n)
//     {
//         int Result = i*i*i;
//         i++;
//         return $"{i} в кубе = {Result}";
//     }
    

// }

Console.WriteLine("Программа выдаёт таблицу кубов чисел от 1 до введённого Вами");
Console.WriteLine("Введите число");

int N = Convert.ToInt32(Console.ReadLine());
int i = 0;


string cube(int n)
{
    for (i=1; i <= n; i++)
    {
        int result = i*i*i;
        Console.WriteLine($"{i} в кубе = {result}"); 
    }
return "";
}   


string Resultat = cube(N);
