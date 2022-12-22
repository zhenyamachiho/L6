double GetNumber(string message)
{
    double result;

    while (true)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}


double b1 = GetNumber("Введите b1: ");
double k1 = GetNumber("Введите k1: ");
double b2 = GetNumber("Введите b2: ");
double k2 = GetNumber("Введите k2: ");

double x = -(b1 - b2) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");

