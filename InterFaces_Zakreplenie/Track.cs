

namespace InterFaces_Zakreplenie
{
    public class Track:iCar
    {
        string name;
        string color;
        int speed;

        public Track() { }
        public Track(string _name, string _color, int _speed)
        {
            name = _name;
            color = _color;
            speed = _speed;
        }

        public string Name { get => name; set => name=value; }
        public string Color { get => color; set => color=value; }
        public int Speed { get => speed; set => speed=value; }

        public void Show()
        {
            Console.WriteLine($"Наша грузовая конфетка фирмы: {name} цвет данной кобылки: {color} развивающей скорость - {speed}"); ;
        }
    }
}
