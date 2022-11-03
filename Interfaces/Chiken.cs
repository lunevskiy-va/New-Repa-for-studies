

namespace Animal
{
    class Chiken:Home_animal,Icompat
    {
        public bool comp = false;
        string place_leave;
        string production;
        public Chiken(bool _comp, string _place_leave, string _production, string _name, int _age) : base(_name, _age)
        {
            comp = _comp;
            place_leave = _place_leave;
            production = _production;
        }

        public bool IsComp => comp;

        public string NameAnimal()
        {
            return "Курица";
        }

        public string Voice()
        {
            return "КУКАРЕКУУУУУУУУУУУ";
        }

        public override string ToString()
        {
            return base.ToString() + $" {NameAnimal()} Проживает в {place_leave}, производит {production} и кричит: {Voice()} ";
        }
    }
}
