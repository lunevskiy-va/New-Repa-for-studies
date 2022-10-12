
Console.WriteLine("Введите слово с клавиатуры:  ");
string Slovo=Console.ReadLine();
Console.WriteLine("Вставляем Звездочки слева и справа равную длине введенного слова: ");
int Dlina =Slovo.Length;
Slovo=Slovo.PadLeft(Dlina+Slovo.Length,'*');
int Dlina2=Slovo.Length;
Slovo = Slovo.PadRight(Dlina+Slovo.Length, '*');
Console.WriteLine(Slovo);
Console.WriteLine("Заменяем * на # в строке: ");
Slovo=Slovo.Replace('*', '#');
Console.WriteLine(Slovo);
Console.WriteLine("Вырезаем все # в строке: ");
Slovo =Slovo.Replace("#", "");
Console.WriteLine(Slovo);
Console.WriteLine("Введите слово из двух символов с клавиатуры и сравниваем его встречается ли она в первом слове:  ");
string Slovo_2=Console.ReadLine();

if(Slovo.Contains(Slovo_2))
{
    Console.WriteLine(Slovo.IndexOf(Slovo_2));
}
else
{
    Console.WriteLine("Danger Danger");
}