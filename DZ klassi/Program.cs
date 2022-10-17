Student One=new Student("Иван","Добряк","Иванович","СТ-11",23);
One.Print();



class Student
{
    private string Name;
    private string Family;
    private string Surname;
    private string Group;
    private int Age;
    public int[][] Myarr=new int [2][];
    
    public Student(string? pName,string? pFamily,string? pSurname,string? pGroup,int pAge, int[][] pMyarr)
    {
        Name= pName;
        Family= pFamily;
        Surname= pSurname;
        Group= pGroup;
        Age= pAge;
        Myarr= pMyarr;
    }

    public string name
    {
        get { return Name; }
        set { Name =value; }
    }

    public string family
    {
        get { return Family; }
        set { Family = value; }
    }

    public string surname
    {
        get { return Surname; }
        set { Surname = value; }
    }

    public int age
    {
        get { return Age; }
        set { Age = value; }
    }

    public string group
    {
        get { return Group; }
        set { Group = value; }
    }

    public void Zapol()
    {
        Console.WriteLine("Введите Имя: ");
        Name = Console.ReadLine();
        Console.WriteLine("Введите Фамилию: ");
        Family = Console.ReadLine();
        Console.WriteLine("Введите Отчество: ");
        Surname = Console.ReadLine();
        Console.WriteLine("Введите Возраст: ");
        Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите № группы: ");
        Group = Console.ReadLine();
    }
    public void Print()
    {
        Console.WriteLine($"Студент - {Family} {Name} {Surname} возрастом {Age} года, из группы № {Group}");
    }

}