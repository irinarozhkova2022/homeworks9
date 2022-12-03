//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*void ShowNumbers(int n)
{
    if(n>=1) 
    {        
        Console.Write(n+" ");     
        ShowNumbers(n-1);
    }
}
ShowNumbers(8);*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30//

/*void NaturaleNumSum (int m, int n, int sum)
{    
    if(m > n)   
        {
            Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
            return;
        }
        sum = sum + (m++); 
        NaturaleNumSum(m, n, sum);  
}  
    
Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное число N:");
int n = int.Parse(Console.ReadLine());

NaturaleNumSum(m, n, 0);*/




//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

/*int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);*/
