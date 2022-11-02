
Urovnenie One = Urovnenie.Parse("2*X-8=0");
One.print();
One.Reshenie();

class Urovnenie
{
	string? text;
    public int A;
    public int B;
    public Urovnenie(int a, int b,string Text)
    {
        A = a;
        B = b;
        text = Text;
    }
    
    public static Urovnenie Parse(string Text)
	{
        string[] Ur = Text.Split('*','X','+','=');
        int A = int.Parse(Ur[0]);
        int B = int.Parse(Ur[2]);
		return new Urovnenie(A, B,Text);
    }

    public void print()
    {
        Console.WriteLine(text);
        Console.WriteLine(A);
        Console.WriteLine(B);
    }
	public void Reshenie()
	{
      Console.WriteLine($"X у нас равен = {-B / A}");
          
	}
	
}