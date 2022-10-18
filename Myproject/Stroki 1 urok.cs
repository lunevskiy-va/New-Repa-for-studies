//Console.WriteLine("Введите число");
//string pars=Console.ReadLine();
//int a=int.Parse(pars);
//Console.Clear();
//Console.WriteLine($"Вы ввели число:  {a}");

//Console.WriteLine("Введите Сколько дней прошло:  ");
//string Stroka = Console.ReadLine();
//int day = int.Parse(Stroka);
//Console.Clear();
//Console.WriteLine($"У вас прошло полных недель:  {day/7}");

//__________________________________________________________________________________________________________________________________________________________

//Console.WriteLine("Введите Первое число:  ");
//string Stroka1 = Console.ReadLine();
//int one = int.Parse(Stroka1);
//Console.WriteLine("Введите Второе число:  ");
//string Stroka2 = Console.ReadLine();
//int two = int.Parse(Stroka2);
//Console.WriteLine("Введите Третье число:  ");
//string Stroka3 = Console.ReadLine();
//int three = int.Parse(Stroka3);

//if(one>two & one > three)
//{
//    Console.WriteLine($"Наибольшее число:  {one}");
//    if (two > three)
//    {
//        Console.WriteLine($"Наименьшее число:  {three}");
//    }
//    else
//    {
//        Console.WriteLine($"Наименьшее число:  {two}");
//    }
//}
//else if (two > three & two > one)
//{
//    Console.WriteLine($"Наибольшее число:  {two}");
//    if (one > three)
//    {
//        Console.WriteLine($"Наименьшее число:  {three}");
//    }
//    else
//    {
//        Console.WriteLine($"Наименьшее число:  {one}");
//    }
//}
//else
//{
//    Console.WriteLine($"Наибольшее число:  {three}");
//    if (one > two)
//    {
//        Console.WriteLine($"Наименьшее число:  {two}");
//    }
//    else
//    {
//        Console.WriteLine($"Наименьшее число:  {one}");
//    }
//}

//________________________________________________________________________________________________________________________________________________________

//Console.WriteLine("Введите Радиус круга:  ");
//string Stroka1 = Console.ReadLine();
//double one = double.Parse(Stroka1);
//double P = 3.14;
//double S_kruga = P * one;
//Console.WriteLine($"Площадь круга равна: {S_kruga}");
////Console.Clear();
//Console.WriteLine("Введите сторону квадрата:  ");
//string Stroka2 = Console.ReadLine();
//double two = double.Parse(Stroka2);
//double S_kvadrat=two*two;
//Console.WriteLine($"Площадь квадрата равна: {S_kvadrat}");
////Console.Clear();
//if(S_kruga> S_kvadrat)
//{
//    Console.WriteLine($"Плошадь круга больше и равна:{S_kruga} ");
//}
//else
//{
//    Console.WriteLine($"Плошадь квадрата больше и равна:{S_kvadrat} ");
//}

//__________________________________________________________________________________________________________________________________________________________

//Console.WriteLine("Введите два числа для работы с калькулятором:  ");
//Console.WriteLine("Введите Первое число:  ");
//string Stroka1 = Console.ReadLine();
//int one = int.Parse(Stroka1);
//Console.WriteLine("Введите Второе число:  ");
//string Stroka2 = Console.ReadLine();
//int two = int.Parse(Stroka2);

//char deyst = Console.ReadKey().KeyChar;
//if (deyst == '+')
//{
//    Console.WriteLine(one + two);
//}
//else if (deyst == '-')
//{
//    Console.WriteLine(one - two);
//}
//else if (deyst == '*')
//{
//    Console.WriteLine(one * two);
//}
//else
//{
//    Console.WriteLine(one / two);
//}

//__________________________________________________________________________________________________________________________________________________________

Console.WriteLine("Выбирите три варианта создания Массива:   ");

string Vibor=Console.ReadLine();
int a=int.Parse(Vibor);
int[] Arr1=new int[10];
switch (a)
{
    case 1:
        {

            for (int i = 0; i < Arr1.Length; i++)
            { Arr1[i] = i; }
            printarr(Arr1);
            break;
        }
    case 2:
        {
            for (int i = 0; i < Arr1.Length; i++)
            { Arr1[i] = int.Parse(Console.ReadLine()); }
            printarr(Arr1);
            break;
        }
    case 3:
        {

            for (int i = 0; i < Arr1.Length; i++)
            {
                Random rnd = new Random();
                Arr1[i] = rnd.Next(1, 100);
            }
            printarr(Arr1);
            break;
        }
}
int Find_elem = int.Parse(Console.ReadLine());
Console.WriteLine("Poisk po elemenu\n"+Array.IndexOf(Arr1, Find_elem));


static void printarr(int[] Arr1)
{
    Console.Write("MASSIV : ");
    for(int i=0; i<Arr1.Length; i++)
    {
        Console.Write(Arr1[i]+" ");
   //     Console.WriteLine();
    }
}
