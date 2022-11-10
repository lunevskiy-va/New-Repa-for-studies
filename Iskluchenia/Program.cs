
Console.WriteLine("Введите число А - ");
int A=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B - ");
int B = int.Parse(Console.ReadLine());

try
{
	if (A % B != 0)
		throw new MyException();
	else
		Console.WriteLine("Делятся ребята без остатка");
}
catch (MyException my)
{
	Console.WriteLine(my.Message);
	Console.WriteLine(my.TimeExcept);
}
finally
{
	Console.WriteLine("Good JOB");
}