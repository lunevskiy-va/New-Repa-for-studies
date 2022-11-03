
namespace Animal
{
    class Cat:Home_animal,Idom
    {
        string opisanie;
        string master;
        public Cat(string _opisanie, string _master,string _name,int _age) : base(_name, _age)
        {
            opisanie = _opisanie;
            master = _master;
        }

        public string Opisanie { get => opisanie; set => opisanie=value; }
        public string Master { get => master; set => master=value; }

        public override string ToString()
        {
            return base.ToString() + $" Живет у человека по имени {Master} и проецирует себя как {Opisanie} ";
        }
    }
}
