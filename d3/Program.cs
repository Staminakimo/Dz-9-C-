/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/


int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {

        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))

            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

int m = GetNumber("Введите m: ");
int n = GetNumber("Введите n: ");

int functionAkkerman = СalculationAckermannFunction(n, m);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int СalculationAckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return СalculationAckermannFunction(m - 1, 1);
    else return СalculationAckermannFunction(m - 1, СalculationAckermannFunction(m, n - 1));
}
Console.WriteLine();
