// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number > 9999 & number < 100000)
{ 
    if (number/10000 == number%10 && (number/1000)%10 == number%100/10)
    {
       Console.WriteLine("число является палиндромом");
    }
    else
    {
       Console.WriteLine("число не является палиндромом"); 
    }
}     
else
{
    Console.WriteLine("Число не является пятизначным!");
}