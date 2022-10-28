namespace figures
{
    public class Circle : Geometry_figure       //Класс Круг
    {
        double radius;
       
        public Circle(double _radius)       // Конструктор с параметрами, не забываем засунуть в него функции
        {
            this.radius = _radius;
            fig_P();
            fig_S();
        }

        public override void fig_P()        // Расчет окружности
        {
            this.P = 2*3.14*radius;
        }

        public override void fig_S()        // Расчет площади
        {
            this.S = (radius * radius) * 3.14;
        }

        public override void Print()        //вывод
        {
            Console.WriteLine($"Длина окружности Равна: {P}, а пдощадь данного круга равна : {S}");
        }
    }
}