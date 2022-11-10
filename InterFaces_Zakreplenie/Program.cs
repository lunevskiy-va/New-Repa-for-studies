using InterFaces_Zakreplenie;



    iCar[] arr =
    {
        new Car("Рено","Черная",170),
        new Car("Лада","Белая",160),
        new Track("Man","Красная",150),
         new Track("КАМАЗ","Оранжевый",120)
    };

   foreach(iCar item in arr)
        {
        item.Show();
        Console.WriteLine();
        }

