using wonder_one;
using wonder_two;
using wonder_three;
using wonder_four;
using wonder_five;
using wonder_six;
using wonder_seven;

Seven_wonders Wonderfull=new Seven_wonders();
Console.WriteLine("Представляю вам семь чудес света: ");
Wonderfull.Print_all();


internal class Seven_wonders
{
    wonder_one.wonder_world One = new wonder_one.wonder_world("Пирамида Хеопса", "Гиза", "2550 г. до н. э.");
    wonder_two.wonder_world Two = new wonder_two.wonder_world("Висячие сады Семирамиды", "Вавилон", "600 г. до н. э.");
    wonder_three.wonder_world Three = new wonder_three.wonder_world("Статуя Зевса в Олимпиии", "Олимпия", "435 г. до н. э.");
    wonder_four.wonder_world Four = new wonder_four.wonder_world("Храм Артемиды Эфресской", "Эфес", "550 г. до н. э.");
    wonder_five.wonder_world Five = new wonder_five.wonder_world("Мавзолей в Галикарнасе", "Галикарнас", "351 г. до н. э.");
    wonder_six.wonder_world Six = new wonder_six.wonder_world("Колосс Родосский", "Родос", "292 и 280 гг. до н. э.");
    wonder_seven.wonder_world Seven = new wonder_seven.wonder_world("Александрийский маяк", "Александрия", "3 век до н. э.");

    public void Print_all()
    {
        One.Print();
        Two.Print();
        Three.Print();
        Four.Print();
        Five.Print();
        Six.Print();
        Seven.Print();

    }
}



