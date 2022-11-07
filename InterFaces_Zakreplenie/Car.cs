

namespace InterFaces_Zakreplenie
{
    public class Car : iCar
    {

        string name;
        string color;
        int speed;
        public Car(){ }
        public Car(string _name, string _color, int _speed)
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
            Console.WriteLine($"Тачка Фирмы: {name} цвет данной курвы: {color} развивающей скорость - {speed}"); 
        }
    }
}
