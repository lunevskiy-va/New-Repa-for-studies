namespace figures
{
    public class Rectangle : Geometry_figure            //Класс Прямоугольник
    {
        double size_1;
        double size_2;
        public Rectangle(double _size_1, double _size_2)        // Конструктор с параметрами, не забываем засунуть в него функции
        {
            this.size_1 = _size_1;
            this.size_2 = _size_2;
            fig_P();
            fig_S();
        }

        public override void fig_P()        // Расчет периметра
        {
            this.P = (size_1+size_2) * 2;
        }

        public override void fig_S()        //Расчет площади
        {
            this.S = size_1 * size_2;
        }

        public override void Print()            //вывод
        {
            Console.WriteLine($"Периметр прямоугольника Равен: {P}, а пдощадь данного прямоугольника равен : {S}");
        }
    }
}