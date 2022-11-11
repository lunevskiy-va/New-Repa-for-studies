

namespace Class_Garaj_InterFaces
{
   public class Auto
    {
        public string name;
        public string color;
        public int speed;

        public Auto() { }
        public Auto(string _name,string _color,int _speed)
        {
            name = _name;
            color = _color;
            speed = _speed;
        }


     
        public override string ToString()
        {
            return $"Автомобиль {name}, цветом {color}, развивающий скорость {speed}";
        }

    }

}
