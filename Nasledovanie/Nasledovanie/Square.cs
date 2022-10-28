namespace figures { 
public class Square : Geometry_figure       //класс квадрат
    {
    double size_1;
    public Square(double _size_1)       // Конструктор с параметрами, не забываем засунуть в него функции
        {
        this.size_1 = _size_1;
        fig_P();
        fig_S();
    }

    public override void fig_P()        // Расчет периметра
        {
        this.P = size_1 * 4;
    }

    public override void fig_S()        //Расчет площади
        {
        this.S = size_1 * size_1;
    }

    public override void Print()        //вывод
        {
        Console.WriteLine($"Периметр квадрата Равен: {P}, а пдощадь данного квадрата равна : {S}");
    }
}
}