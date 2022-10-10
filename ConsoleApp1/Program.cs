int[] Arr = new int[20];

for(int i = 0; i < Arr.Length; i++) 
{
    Random rnd = new Random();
    Arr[i] = rnd.Next(1, 100);

}

Array.Sort(Arr);
PrintArr(Arr);
Console.WriteLine("\n"+ Arr.Sum());
Console.WriteLine("\n" + Arr.Average());
Array.Reverse(Arr);
Console.WriteLine("\n");
PrintArr(Arr);
Console.WriteLine("\n");
PrintArr2(Arr);
Array.Clear(Arr);

for (int i = 0; i < Arr.Length; i++)
{
    Random rnd = new Random();
    Arr[i] = rnd.Next(1,30);
}

Console.WriteLine("\n");
PrintArr(Arr);

for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] > 10)
    {
        Arr[i] = (int)Math.Sqrt(Arr[i]);
    }
}

Console.WriteLine("\n");
PrintArr(Arr);

static void PrintArr(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    { Console.Write(Arr[i]+ " "); }
}

static void PrintArr2(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
      int a=Arr[i];
        if (a % 2==0)
        {
            Console.Write(Arr[i] + " ");
        }
    }
}