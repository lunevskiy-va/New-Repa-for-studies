
using Animal;

Cow One = new Cow(false, "Коровнике", "Молоко", "Лила", 5);
Console.WriteLine(One);
Chiken Two = new Chiken(false, "Курятнике", "Яички", "Лола", 3);
Console.WriteLine(Two);
Cat Three = new Cat("Шерстяное жидкое создание которое вечно хочет есть и лежать на тебе", "Иван", "Луиза", 11);
Console.WriteLine(Three);
Dog Four = new Dog("Гавкающее по любому поводу создание которое вечно хочет гулять", "Алексей", "Дог", 6);
Console.WriteLine(Four);


namespace Animal
{

    abstract class Home_animal
    {
       public string name;
       public int age;

      public  Home_animal(string _name, int _age)
        {
           name = _name;
            age = _age;
        }
        public override string ToString()
        {
            return $"Домашнее животное с именем: {name} и возрастом {age} Лет";
        }
    }

  

}