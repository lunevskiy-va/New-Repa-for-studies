using Stud;
using System.Collections;

SortedList SibGiu = new SortedList();

while (true)
{

    Console.WriteLine("Введите имя студента: ");
    string name = Console.ReadLine();
    Console.WriteLine("Введите Возраст студента: ");
    int age = int.Parse(Console.ReadLine());

    uint studbilet = 0;
    do
    {
        Console.WriteLine("Введите студенческий билет: ");
        studbilet = uint.Parse(Console.ReadLine());
        if (SibGiu.ContainsKey(studbilet))
        {
            Console.WriteLine("Такой номер билета уже существует!");
        }
    }
    while (SibGiu.ContainsKey(studbilet));
    SibGiu.Add(studbilet, new Student(name, age, studbilet));
    Console.WriteLine("Список студентов");
    foreach(object item in SibGiu.Values)
    {
        Console.WriteLine(item);
    }
}    
