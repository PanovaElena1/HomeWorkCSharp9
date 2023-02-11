// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

System.Console.WriteLine(SumNumbers (4, 8));

int SumNumbers (int FirstNumb, int LastNumb)
{
    if (FirstNumb > LastNumb)
    {
        return 0;
    }
    return (FirstNumb + SumNumbers(FirstNumb+1, LastNumb));
}
