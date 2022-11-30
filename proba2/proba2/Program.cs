
List<Smartphone> Phone = new List<Smartphone>()
{
    new Smartphone("Alcatel","2001","Синий",7500),
    new Smartphone("Samsung","2001","Серо-синий",7100),
    new Smartphone("SonyEricson","1998","Черный",6500),
    new Smartphone("Siemens","2002","Серо-красный",7500),
    new Smartphone("Samsung","2002","Серо-синий",7900),
    new Smartphone("Ericson","1997","черный",6000)
};


foreach(Smartphone phone in Phone)
{
    Console.WriteLine(phone);
}
void FindAll(List<Smartphone> Phone)
{
    string yy = null;
    Console.WriteLine("Введите год поиска телефона: ");
    yy=Console.ReadLine();

    for (int i = 0; i < Phone.Count; i++)
    {
        if (Phone[i].year == yy)
        {
            Console.WriteLine();
            Console.WriteLine(Phone[i]);
        }

    }
}


FindAll(Phone);
public class Smartphone
{
    public string name;
    public string year;
    public string color;
    public decimal price;

    public Smartphone(string _name,string _year, string _color, decimal _price)
    {
        this.name = _name;
        this.year = _year;
        this.color = _color;
        this.price = _price;
    }

    public override string ToString()
    {
        return $"Телефон {name}\nГод выпуска:{year}\nЦветом - {color}\nЦеной - {price}\n";
    }

}
