Shop Mag1 = new Shop("Пятерочка", "г. Новокузнецк, Ермакова 3", 150);
Shop Mag2 = new Shop("Ярче", "г. Новокузнецк, Ермакова 5", 120);
Console.WriteLine($"Площадь Пятерочки больше Ярче-{Mag1>Mag2}");
Console.WriteLine($"Площадь Пятерочки меньше Ярче-{Mag1 < Mag2}");
Console.WriteLine($"Площадь Пятерочки равна Ярче-{Mag1 == Mag2}");
Console.WriteLine($"Площадь Пятерочки Не равна Ярче-{Mag1 != Mag2}");
Mag1 += 25;
Mag2 += 40;
Console.WriteLine(Mag1);
Console.WriteLine(Mag2);

class Shop
{
    string name;
    string addres;
    int S;
    
    public Shop():this("Мария-Ра","г. Новокузнецк, пр. Ермакова 3", 130) { }
    public Shop(string _name, string _addres, int _S)
    {
        name = _name;
        addres = _addres;
        S = _S;
    }
    public string Name 
    { 
        get { return Name; }
        set { Name = value; }
    }
    public string Addres
    {
        get { return addres; }
        set { addres = value; }
    }
    public int s
    {
        get { return S; }
        set { S = value; }
    }

    public static Shop operator +(Shop A,int V)
    {
        A.S+=V;
        return A;
    }

    public static Shop operator -(Shop A, int V)
    {
        A.S -= V;
        return A;
    }

    public static bool operator ==(Shop A, Shop B)
    {
       
        return A.S==B.S;
    }
    public static bool operator !=(Shop A, Shop B)
    {

        return !(A.S == B.S);
    }
    public static bool operator >(Shop A, Shop B)
    {

        return A.S > B.S;
    }
    public static bool operator <(Shop A, Shop B)
    {

        return A.S < B.S;
    }

    public override bool Equals(object? obj)
    {
        return this.ToString()==obj.ToString();
    }

    public override string ToString()
    {
        return $"Магазин с названием: {name} по адресу: {addres} и площадью- {S}";
    }
}