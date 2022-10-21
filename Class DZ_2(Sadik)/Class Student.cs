Student One=new Student("Иван","Добряк","Иванович","СТ-11",23);
One.Zapol();
One.Print();


class Student
{
    private string Name;
    private string Family;
    private string Surname;
    private string Group;
    private int Age;
    public int[][] Myarr=new int [3][];
    
    public Student(string? pName,string? pFamily,string? pSurname,string? pGroup,int pAge)
    {
        Name= pName;
        Family= pFamily;
        Surname= pSurname;
        Group= pGroup;
        Age= pAge;
        Myarr[0]= new int[5];
        Myarr[1]= new int[3];
        Myarr [2]= new int[5];

    }

    public void Setname(string pName)
    {
        this.Name=pName;
    }
    public void Setfamily(string pFamily)
    {
        this.Family= pFamily;
    }
    public void Setsurname(string pSurname)
    {
        this.Surname = pSurname;
    }
    public void Setgroup(string pGroup)
    {
        this.Group= pGroup;
    }
    public void SetAge(int pAge)
    {
        this.Age= pAge;
    }

    public string Getname()
    {
        return this.Name;
    }
    public string Getfamily()
    {
        return this.Family;
    }
    public string Getsurname()
    {
        return this.Surname;
    }
    public string Getgroup()
    {
        return this.Group;
    }
    public int Getage()
    {
        return this.Age;
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
        Console.WriteLine("Введите оценки по програмированию: ");
        for (int i = 0; i < 5; i++)
        {
            Myarr[0][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Введите оценки по администрированию: ");
        for (int i = 0; i < 3; i++)
        {
            Myarr[1][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("Введите оценки по дизайну: ");
        for (int i = 0; i < 5; i++)
        {
            Myarr[2][i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
    }
   
    public void Print()
    {
        Console.WriteLine($"Студент - {Family} {Name} {Surname} возрастом {Age} года, из группы № {Group}");

        Console.WriteLine("С оценками: ");
        Console.Write("Оценки по програмированию: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(Myarr[0][i]+" ");
        }
        Console.WriteLine("Средний бал по програмированию -"+Myarr[0].Average());
        Console.WriteLine();
        Console.Write("Оценки по администрированию: ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(Myarr[1][i]+" ");
        }
        Console.WriteLine("Средний бал по администрированию -" + Myarr[1].Average());
        Console.WriteLine();
        Console.Write("Оценки по дизайну: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(Myarr[2][i]+" ");
        }
        Console.WriteLine("Средний бал по дизайну -" + Myarr[2].Average());
        Console.WriteLine();
    }

}