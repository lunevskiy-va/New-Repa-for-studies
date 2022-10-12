Console.WriteLine("Введите текст с цифрами:  ");
string text = Console.ReadLine();
char[] Arr = text.ToCharArray();
int[] Arr2=new int[Arr.Length];
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] >= '1' && Arr[i] <= '9')
    {
        Arr2[i] = (int)Char.GetNumericValue(Arr[i]);     
    }
}
Console.WriteLine(Arr2.Max());
Console.WriteLine(Arr2.Sum());

string text2 = Console.ReadLine();


//Ввести второе слово и сравнить его посимвольно с первым текстом