namespace figures
{
    public class Triangle : Geometry_figure     //класс треугольник
    {
        double katet_1;
        double katet_2;
        double gipotenuza;
        public Triangle(double _katet_1, double _katet_2, double _gipotenuza)       // Конструктор с параметрами, не забываем засунуть в него функции
        {
            this.katet_1 = _katet_1;
            this.katet_2 = _katet_2;
            this.gipotenuza = _gipotenuza;
            fig_P();
            fig_S();
        }

        public override void fig_P()        // Расчет периметра
        {
            this.P = katet_1 + katet_2 + gipotenuza;
        }

        public override void fig_S()        //Расчет площади
        {
            this.S = (katet_1 * katet_2)/2;
        }

        public override void Print()        //вывод
        {
            Console.WriteLine($"Периметр треугольника Равен: {P}, а пдощадь данного треугольника равна : {S}");
        }
    }
}