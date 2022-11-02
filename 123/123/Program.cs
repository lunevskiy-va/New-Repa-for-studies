


Spisok Spisok = new Spisok();
for(int i=0; i < 2; i++) {
    Spisok.add();
 }
Spisok.ShowSpisok();
class Books
{
    public string name;
    public bool read;
   public Books()
    {
        Console.Write("\nДобавим книгу:\n Введите название: "); name = Console.ReadLine();
        Console.Write("\nПрочитана ли книга:\n  "); read = bool.Parse(Console.ReadLine());
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

class Spisok
{
    List<Books> Listbooks;
    public Spisok()
    {
        Listbooks = new List<Books>();
    }
    public void add()
    {
        Listbooks.Add(new Books());
    }
   
    public void ShowSpisok()
    {
        foreach (Books name in Listbooks)
            Console.WriteLine("\n{0}",name);
    }
}
