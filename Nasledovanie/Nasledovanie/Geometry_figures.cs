namespace figures
{

    public abstract class Geometry_figure       //Абстрактный класс фигуры где простые поля периметра и площади, а также функции их расчета и вывода
    {

        public double S;
        public double P;

        public abstract void fig_S();
        public abstract void fig_P();
        public abstract void Print();
    }
}