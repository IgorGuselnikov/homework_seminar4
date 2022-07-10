// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());
double result = exp(firstNumber, secondNumber);
Console.WriteLine(result);


double exp (double firstNumber, double secondNumber)
{
    double result = Math.Pow(firstNumber, secondNumber);
    return result;
}


