// Задача 19. Напишите программу, которая принимает на 
// вход пятизначное число и проверяет, является ли оно 
// палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int n=Convert.ToInt32(Console.ReadLine());


//for (int i=0; i<n; i++)

while (n<10000||n>100000)
{
    Console.Write("Ты издеваешься? Попробуй еще раз: ");
    n=Convert.ToInt32(Console.ReadLine());
}

int n1=n/10000;
int n2=(n/1000)-n1*10;
int n3=(n%1000)/100;//delete
int n4=(n%100)/10;
int n5=n%10;
if (n1==n5 && n2==n4)
    Console.WriteLine("Это палиндром: " + n);
else
    Console.WriteLine("Это не палиндром: " + n);