
using System.Reflection.Metadata.Ecma335;
Driver A = new Driver("Петька", "Иванов", 35, "г. Новокузнецк, пр. Ермакова 9А", 35000.95, "Тойота Камри", "Н 999 АС 777");
Console.WriteLine(A);
public abstract class Human
{
    string name;
    string fname;
    int age;
    public Human ():this("Иван", "Иванов", 18) { }
    public Human(string _name,string _fname,int _age)
    {
        name= _name;
        fname= _fname;
        age= _age;
    }

    public override string ToString()
    {
        return $"\n Имя: {name} \n Фамилия: {fname} \n Возраст: {age}";
    }
}

public abstract class Buyer : Human
{
    string type_calc;

    public Buyer(string _name,string _fname,int _age,string _type_calc) : base(_name, _fname, _age) 
    { type_calc = _type_calc; }

    public override string ToString()
    {
        return base.ToString()+$" С типом расчета: {type_calc}";
    }
}

public abstract class Employer : Human
{
    string addres;
    double pay;

    public Employer(string _name, string _fname, int _age, string _addres,double _pay) : base(_name, _fname, _age) 
    { addres= _addres; pay= _pay; }

    public override string ToString()
    {
        return base.ToString() + $"\n Работает по адресу: {addres} c зароботной платой - {pay}";
    }
}

public class Director : Human
{
    int kab;

    public Director(string _name, string _fname, int _age, int _kab) : base(_name, _fname, _age) { kab = _kab; }

    public override string ToString()
    {
        return base.ToString() + $"\n Кабинет директора номер: {kab}";
    }
}

public class Face : Buyer
{
    string addres_dost;

    public Face(string _name, string _fname, int _age, string _type_calc, string _addres_dost) : base(_name, _fname, _age, _type_calc) { addres_dost = _addres_dost; }

    public override string ToString()
    {
        return base.ToString() + $"\n Доставить по адресу: {addres_dost} "; 
    }
}

public class Entity : Buyer
{
    string entity;

    public Entity(string _name, string _fname, int _age, string _type_calc, string _entity) : base(_name, _fname, _age, _type_calc) { entity = _entity; }

    public override string ToString()
    {
        return base.ToString() + $"\n Организация: {entity} ";
    }
}

public class Manager : Employer
{
    string departament;
    public Manager(string _name, string _fname, int _age, string _addres, double _pay, string _departament) : base(_name, _fname, _age,_addres, _pay)
    {
        departament = _departament;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n Манагер работает в отделе: {departament}";
    }
}

public class Worker : Employer
{
    string stock;
    public Worker(string _name, string _fname, int _age, string _addres, double _pay, string _stock) : base(_name, _fname, _age, _addres, _pay)
    {
        stock = _stock;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n Данный работник склада ответственный за отдел: {stock}";
    }
}

public class Driver : Employer
{
    string auto;
    string Nomber_auto;
    public Driver(string _name, string _fname, int _age, string _addres, double _pay, string _auto, string nomber_auto) : base(_name, _fname, _age, _addres, _pay)
    {
        auto = _auto;
        Nomber_auto = nomber_auto;
    }

    public override string ToString()
    {
        return base.ToString() + $"\n Водитель закреплен за ТС: {auto} \n С государственным номером: {Nomber_auto}";
    }
}