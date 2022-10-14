Console.WriteLine("Введите текст с цифрами:  ");
string text = Console.ReadLine();       //Вводим первую строку с числами
char[] Arr = text.ToCharArray();
int[] Arr2=new int[Arr.Length];
for (int i = 0; i < Arr.Length; i++)        //Проганяем по циклу в поисках чисел и загоняем их в интовый массив
{
    if (Arr[i] >= '1' && Arr[i] <= '9')
    {
        Arr2[i] = (int)Char.GetNumericValue(Arr[i]);     
    }
}

Console.WriteLine("Максимальное числовое значение в вашем тексте: "+Arr2.Max());        //Находим максимальное число в интовом массиве
Console.WriteLine("Сумма числовых элементов в вашем тексте: "+Arr2.Sum());              //Находим сумму числе в интовом массиве

Console.WriteLine("Введите слово для сравнение с текстом: ");               //Вводим вторую строку для сравнения с первой
string text2 = Console.ReadLine();

char[] MyArr = text2.ToCharArray();

for(int i = 0; i < MyArr.Length; i++)               //Прогоняем Посимвольно и сравниваем два массива
{
    for(int j = 0; j < Arr.Length; j++)
    {
     
       if(MyArr[i]==Arr[j])
        {
            Console.WriteLine($"{MyArr[i]} присутствует в слове {text}");
            break;
        }
       else if (j == Arr.Length-1)
        {
            Console.WriteLine($"{MyArr[i]} Отсутствует слове {text}");
        }
    }
   
}


//Ввести второе слово и сравнить его посимвольно с первым текстом

