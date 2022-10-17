
Sadik one = new Sadik("Победа", "Новокузнецк, пр. Кузнецкстроевский, 44");
one.SetSad("Спортивный", 19);
one.Info();
Sadik two = new Sadik("Спортик", "Новокузнецк, ул. Запорожская, 67");
two.SetSad("Танцевальный", 27);
two.Info();


class Sadik
{
    public string Name;
    public string Addres;
    public string Spec;
    public int Deti;
    public static int Deti2;

    public Sadik():this("Святой","Новокузнецк, ул. Павловского, 11") { }
    public Sadik(string name, string addres)
    {
        Name = name;
        Addres = addres;
    }
    static Sadik()
    {
        Deti2 = 25;
    }
    public void SetSad(string pSpec,int pDeti)
    {
       Spec=pSpec;
       Deti = pDeti;
    }

    public void Info()
    {
        if (this.Deti > Deti2)
        {
            double info = (double)this.Deti / (double)Deti2;
            Console.WriteLine("У вас перебор детей на: "+ (info * 100 - 100) + "%");
        }
        else
        {
            double info = (double)this.Deti / (double)Deti2;
            Console.WriteLine("У вас Недобор детей, сад заполнен на: " + (info * 100 )+"%");
        }
    }
}
