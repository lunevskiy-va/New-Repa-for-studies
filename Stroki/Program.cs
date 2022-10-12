Console.WriteLine("Введите Имя");
string Name=Console.ReadLine();
Console.WriteLine("Введите Фамилию");
string Familia=Console.ReadLine();
Console.WriteLine("Введите Отчество");
string Surname=Console.ReadLine();

Console.WriteLine("Выбирите вывод данных: ФИО - 1, ИФО - 2, ФИ");
string str= Console.ReadLine();
int Vibor = int.Parse(str);

if (Vibor == 1)
{
    Console.WriteLine(Familia+Name+Surname);
}
else if(Vibor == 2)
{
    Console.WriteLine(Name + Familia + Surname);
}
else if (Vibor == 3)
{
    Console.WriteLine(Familia + Name);
}
else
{
    Console.WriteLine("DAGER - вы ввели неверный вариант выбора!!!");
}
Console.WriteLine("Введите вторую фамилию: ");
string Surname_2=Console.ReadLine();

if (Surname.Length > Surname_2.Length)
{
    Console.WriteLine("В первой фамилии букв:  " + Surname.Length+ "Во второй фамилии букв:  " + Surname_2.Length+"Больше букв в: " + Surname.Length);
}
else
{
    Console.WriteLine("В первой фамилии букв:  " + Surname.Length + "Во второй фамилии букв:  " + Surname_2.Length + "Больше букв в: " + Surname_2.Length);
}