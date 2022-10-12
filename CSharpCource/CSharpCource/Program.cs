
int size = 5;
int size2 = 3;
int size3 = 4;
int[] A=new int[size];
double[,] B=new double[size2,size3];

//      Создаем одномерный массивчик на 5 с клавиатуры

Console.WriteLine("Заполните одномерный массив А числами:  ");
for (int i=0; i<size; i++)
{
    int a = int.Parse(Console.ReadLine());
    A[i]=a;
}

//      Выводим данный массивчик

PrintArr(A);
Console.WriteLine();

//      Создаем двумерный массив 3 на 4 с рандомным заполнением и выводим его на экран
Random ran = new Random();
Console.WriteLine("Ваш двумерный Массивчик :  ");
for (int i = 0; i < size2; i++)
{
    for (int j = 0; j < size3; j++)
    {
        B[i, j] = ran.NextDouble();
        Console.Write(Math.Round(B[i, j], 2) + " ");
    }
    Console.WriteLine();
}

//      Поиск Максимального значения в двух массивах

int maxValue = A.Max();
double Bmax = 0;
for (int i = 0; i < size2; i++)
{
    
    for (int j = 0; j < size3; j++)
    {
        if(B[i, j] > Bmax)
        {
            Bmax = B[i, j];
        }
    }
}
if(Bmax < maxValue) 
{
    Console.WriteLine("Максимальный элемент в массивах:  "+maxValue);
}
else
{
    Console.WriteLine("Максимальный элемент в массивах:  " + Bmax);

}

//      Поиск Минимального значения в двух массивах

int minValue = A.Min();
double min=15;
for (int i = 0; i < size2; i++)
{

    for (int j = 0; j < size3; j++)
    {
       
        if (B[i, j] < min)
        {
            min = B[i, j];
        }
    }
}
if (min > minValue)
{
    Console.WriteLine("Минимальный элемент в массивах:  " + minValue);
}
else
{
    Console.WriteLine("Минимальный элемент в массивах:  " + Math.Round(min, 2));                                                       
}

//      Сложение всех элементов массивов

double sum_B = 0;
double sumNch_B = 0;
for(int i = 0; i < size2; i++)
{
    for(int j = 0; j < size3; j++)
    {
        sum_B+=B[i, j];
        //      Сразу ищем и суммируем элементы в нечетных столбцах массива В
        if (j % 2 != 0)
        {
            sumNch_B=B[i, j];
        }
    }
}
int sumch_A = 0;
        //      Сразу ищем сумму четных элементов массива А
for(int i = 0; i < size; i++)
{
    if(i%2==0)
    {
        sumch_A=A[i];
    }
}
int sum_A=A.Sum();
double sum_AB=sum_B+sum_A;
Console.WriteLine("Сумма элементов массивов равна:  "+Math.Round(sum_AB,2));
Console.WriteLine("Сумма нечетных столбцов массива В равна:  "+ Math.Round(sumNch_B,2));
Console.WriteLine("Сумма четных Элементов массива A равна:  " + sumch_A);

//      Произведение Всех элементов Массива

double multi_B = 0;
for (int i = 0; i < size2; i++)
{
    for (int j = 0; j < size3; j++)
    {
        multi_B *= B[i, j];
    }
}
int multi_A = 0;
for(int i = 0; i < size; i++)
{
    multi_A *= A[i];
}
double multi_AB = sum_B * sum_A;
Console.WriteLine("Произведение всех элементов массивов равна:  " + Math.Round(multi_AB,2));

//      Функция вывода массива одномерного

static void PrintArr(int[]Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.Write(Arr[i]+" ");
    }
}
