


Russia.Capital One = new Russia.Capital();
Kazahstan.Capital Two = new Kazahstan.Capital();
Kirgizia.Capital Three = new Kirgizia.Capital();

One.name = "Москва";
Two.name = "Астана";
Three.name = "Бишкек";
One.population = 75000000;
Two.population = 30000000;
Three.population = 20000000;
One.Print();
Two.Print();
Three.Print();

Podschet(One,Two, Three);

void Podschet(in Russia.Capital a,in Kazahstan.Capital b,in Kirgizia.Capital c)
{
    if (a.population > b.population && a.population > c.population)
    {
        Console.WriteLine("Самая большая столица "+a.name+" с населением "+a.population);
    }
    else if(b.population > a.population && b.population > c.population)
    {
        Console.WriteLine("Самая большая столица " + b.name + " с населением " + b.population);
    }
    else
    {
        Console.WriteLine("Самая большая столица " + c.name + " с населением " + c.population);
    }
}
namespace Russia
{
    class Capital
    {
        string _name;
        int _population;

        public Capital() : this("столица", 1000) { }
        public Capital(string name, int population)
        {
            this._population = population;
            this._name = name;
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int population
        {
            get { return _population; }
            set { _population = value; }
        }

        public void Print()
        {
            Console.WriteLine("Ваша столица - " + name + " с населением " + population + " человек");
        }

    }
}

namespace Kazahstan
{
    class Capital
    {
        string _name;
        int _population;

        public Capital() : this("столица", 1000) { }
        public Capital(string name, int population)
        {
            this._population = population;
            this._name = name;
        }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int population
        {
            get { return _population; }
            set { _population = value; }
        }

        public void Print()
        {
            Console.WriteLine("Ваша столица - " + name + " с населением " + population + " человек");
        }

    }
}

namespace Kirgizia
{
    class Capital
    {
        string _name;
        int _population;

        public Capital() : this("столица", 1000) { }
        public Capital(string name, int population)
        {
            this._population = population;
            this._name = name;
        }


        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int population
        {
            get { return _population; }
            set { _population = value; }
        }

        public void Print()
        {
            Console.WriteLine("Ваша столица - " + name + " с населением " + population + " человек");
        }

    }
}