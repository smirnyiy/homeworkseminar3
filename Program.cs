// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

/*
void Palindrome(int number) 
{ 
if(number > 99999 || number < 10000){
    Console.WriteLine("Число не является пятизначным");
}
else{
    if(number/10000 == number % 10){
        if((number/1000)%10 == (number % 100)/10) 
        Console.WriteLine("Число  является палиндромом");
}     
    else Console.WriteLine("Число не является палиндромом"); 
} 
}
 
Console.WriteLine("Введите пятизначное число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
 
 
Palindrome(num);
*/



// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double Distance(int xa, int xb, int ya, int yb, int za, int zb){
    double ab = Math.Sqrt((xb-xa)*(xb-xa) + (yb-ya)*(yb-ya) + (zb-za)*(zb-za));
    return ab;
}

Console.Write("Введите координаты xa: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты xb: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты ya: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты yb: ");
int n4 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты za: ");
int n5 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты zb: ");
int n6 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Расстояние между точками ({n1},{n3}) и ({n2},{n4}) и ({n5},{n6}) равно {Distance(n1, n2, n3, n4, n5, n6)}");
*/


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

/*
void TableOfCube(int n){
        int start = 1;
    while(start<=n){
        Console.Write($"{start*start*start} ");
        start++;
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
TableOfCube(n);
*/