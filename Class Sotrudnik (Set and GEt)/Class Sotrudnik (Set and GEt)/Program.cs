Sodrudnik One=new Sodrudnik();
Console.WriteLine("Введите возраст: ");
One.age = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ФИО: ");
One.name = Console.ReadLine();
Console.WriteLine("Введите Должность: ");
One.function = Console.ReadLine();
Console.WriteLine("Введите заработную плату сотрудника: ");
One.wage = int.Parse(Console.ReadLine());
One.Print();
class Sodrudnik
{
    private string Name;
    private int Age;
    private string Function;
    private int Wage;
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    public int age
    {
        get { return Age; }
        set
        {
            if (age < 18 && age > 65)
            {
                Age = value;
            }
        }
    }
    public string function
    {
        get { return Function; }
        set { Function = value; }
    }
    public int wage
    {
        get { return Wage; }
        set
        {
            if (wage < 35000 && wage>110000)
            {
                Wage = value;
            }
        }
    }
    public void Print()
    {
        Console.WriteLine("Ваш сотрудник - "+Name+" ,возрастом "+Age+" лет, на долженности - "+Function+" ,с зароботной платой- "+Wage+ " Рублей");
    }
}