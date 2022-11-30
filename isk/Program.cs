

try
{

    student One = new student("Евгений", "Егоров", 255);
    Console.WriteLine(One);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}


class student
{
    string name;
    string fname;
    byte age;

   public student(string _name,string _fname,byte _age)
    {
        if(_name == null)
        throw new ArgumentNullException(nameof(_name));
        this.name = _name;
        if (_fname == null) 
        throw new ArgumentNullException(nameof(_fname));
        this.fname = _fname;
        if(_age == 0)
        throw new ArgumentOutOfRangeException(nameof(_age));
        this.age = _age;
    }

    public override string ToString()
    {
        return $"Студент {name} {fname} возрастом {age}";
    }
}