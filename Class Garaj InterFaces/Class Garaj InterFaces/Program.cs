using Class_Garaj_InterFaces;


Garaj One = new Garaj(3);
Console.WriteLine(One);

Console.WriteLine("Сортируем по Марке Авто");
One.SortName();
Console.WriteLine(One);
Console.WriteLine("Сортируем по Скорости Авто");
One.SortSpeed();
Console.WriteLine(One);
Console.WriteLine("Сортируем по Цвету Авто");
One.SortColor();
Console.WriteLine(One);


