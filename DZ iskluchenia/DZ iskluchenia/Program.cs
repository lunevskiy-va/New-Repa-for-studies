

Console.WriteLine("Введите Число - А");
byte a=byte.Parse(Console.ReadLine());

Console.WriteLine("Введите Число - Б");
byte b = byte.Parse(Console.ReadLine());

Delenie(a, b);

void Slojenie(byte a, byte b)
{
    Console.WriteLine("Какой вариант решения вас устраивает?");
    Console.WriteLine("1 - Ошибка при выходе за границы | 2 - выход за границы");
    int d = int.Parse(Console.ReadLine());
    if (d == 1)
    {
        try
        {
            byte c = checked((byte)(a + b));
            Console.WriteLine("Результат сложения равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
    else
    {
        try
        {
            byte c = unchecked((byte)(a + b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
}

void Raznost(byte a, byte b)
{
    Console.WriteLine("Какой вариант решения вас устраивает?");
    Console.WriteLine("1 - Ошибка при выходе за границы | 2 - выход за границы");
    int d=int.Parse(Console.ReadLine());
    if (d == 1)
    {
        try
        {
            byte c = checked((byte)(a - b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
    else
    {
        try
        {
            byte c = unchecked((byte)(a - b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
}

void Umnojenie(byte a, byte b)
{
    Console.WriteLine("Какой вариант решения вас устраивает?");
    Console.WriteLine("1 - Ошибка при выходе за границы | 2 - выход за границы");
    int d = int.Parse(Console.ReadLine());
    if (d == 1)
    {
        try
        {
            byte c = checked((byte)(a * b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
    else
    {
        try
        {
            byte c = unchecked((byte)(a * b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
}


void Delenie(byte a, byte b)
{
    Console.WriteLine("Какой вариант решения вас устраивает?");
    Console.WriteLine("1 - Ошибка при выходе за границы | 2 - выход за границы");
    int d = int.Parse(Console.ReadLine());
    if (d == 1)
    {
        try
        {
            byte c = checked((byte)(a / b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
    else
    {
        try
        {
            byte c = unchecked((byte)(a / b));
            Console.WriteLine("Результат разности равняется ");
            Console.WriteLine((byte)c);
        }
        catch (Exception me)
        {
            Console.WriteLine(me.Message);
        }
    }
}