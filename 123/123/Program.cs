list One = new list();
One.Add();
One.Read_Books();

class Books
{
    public string name;
    public bool read=false;
    public Books() { }
   public Books(string _name)
    {
        name = _name;
    }
    public bool _read
    {
        get { return read; }
        set 
        {
            read = value; 
        }
    }
    public void Print()
    {
        Console.WriteLine($"Книга {name}");
        if (read == true)
        {
            Console.WriteLine("мы ее прочли");
        }
        else { Console.WriteLine("мы ее не прочли"); }
    }
}

class list
{
    public List<Books> Spisok;
    public list()
    {
        Spisok = new List<Books>();
    }
    public void Add()
    {
        Console.WriteLine("Введите название книги:");
        string Name = Console.ReadLine();
        Spisok.Add(new Books(Name));
    }
    public void removeBoobks()
    {
        Console.WriteLine("Введите индекс книги которую необходимо удалить: ");
        int Id_Books=int.Parse(Console.ReadLine());
        Spisok.RemoveAt(Id_Books);
    }
    public void Read_Books()
    {
        Console.WriteLine("Введите индекс книги которую необходимо проверить читали вы или нет: ");
        int Id_Books = int.Parse(Console.ReadLine());
       
        if(Spisok[Id_Books].read == false) 
        { Console.WriteLine("Вы не читали эту книгу"); }
        else
        {
            Console.WriteLine("Вы читали эту книгу");
        }
        Console.WriteLine("Хотите прочесть? 0- Нет , 1- Да");
        int variant=int.Parse(Console.ReadLine());
        if(variant == 0)
        {
            Spisok[Id_Books].read == false;
        }
        else
        {
            Spisok[Id_Books].read == true;
            Console.WriteLine("Книга прочитана!");
        }

    }

 
}
