Magazin Student=new Magazin("Ярче","Кемеровская область, г.Новокузнецк, пр. Ермакова 5","Продуктовый магазин",651943,"mail@mail.ru");
Student.Print();

class Magazin
{
    private string? Name;
    private string? Adress;
    private string? Profil;
    private int telephone;
    private string? email;
    public Magazin(string? PName, string? Padress, string? Pprofil, int Ptelephone, string? Pemail)
    {
        Name = PName;
        Adress = Padress;
        Profil = Pprofil;
        this.telephone = Ptelephone;
        this.email = Pemail;
    }

    public void Setname(string PName)
    {
        Name = PName;
    }
    public void SetAdres(string Padress)
    {
        Adress = Padress;
    }
    public void SetProfil(string PProfil)
    {
        Profil = PProfil;
    }
    public void Settelephone(int Ptelephone)
    {
        telephone = Ptelephone;
    }
    public void Setemail(string Pemail)
    {
        email = Pemail;
    }
    public string Getname()
    {
        return this.Name;
    }
    public string GetAdres()
    {
        return this.Adress;
    }
    public string GetProfil()
    {
       return this.Profil;
    }
    public int Gettelephone()
    {
       return this.telephone;
    }
    public string Getemail()
    {
        return this.email;
    }

    public void Print()
    {
        Console.WriteLine($"Ваш Магазин: С названием {Name} \nАдресом: {Adress}\nПрофилем {Profil}\nТелефоном {telephone}\nEmail: {email}");
    }
}

