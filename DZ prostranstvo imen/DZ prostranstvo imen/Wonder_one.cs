
namespace wonder_one
{
    class wonder_world
    {
        string name;
        string country;
        string date;
        public wonder_world() : this("Чудо", "Страна", "Нынешний год") { }
        public wonder_world(string _name,string _country,string _date)
        {
            name = _name;
            country = _country;
            date = _date;
        }
        public void Print()
        {
            Console.WriteLine(name + " было найдено в " + country + " в "+date);
        }
    }
}