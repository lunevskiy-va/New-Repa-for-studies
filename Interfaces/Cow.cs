

namespace Animal
{
    class Cow:Home_animal,Icompat,Imesto
    {
        public bool comp = false;
        string place_leave;
        string production;
        public Cow(bool _comp, string _place_leave, string _production,string _name,int _age):base(_name,_age)
        {
           comp = _comp;
           place_leave = _place_leave;
           production = _production;
        }

        public bool IsComp => comp ;

        public string Place_leave { get => place_leave; set => place_leave=value; }
        public string Production { get => production; set => production=value; }

        public string NameAnimal()
        {
            return "Корова";
        }

        public string Voice()
        {
            return "МУУУУУУУУУУУУУУУУУУУУУ";
        }

        public override string ToString()
        {
            return base.ToString()+$" {NameAnimal()} Проживает в {Place_leave}, производит {Production} и кричит: {Voice()} ";
        }


    }
}
