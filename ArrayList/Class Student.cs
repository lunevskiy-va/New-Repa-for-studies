
namespace Stud
{
    class Student
    {
        public string name;
        public int age;
        public uint studbilet;

       public  Student(string _name, int _age, uint _studbilet)
        {
            name = _name;
            age = _age;
            studbilet = _studbilet;
        }

        public override string ToString()
        {
            return $"Студент по имени {name} возрастом {age} Номер студенческого билета {studbilet}";
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}