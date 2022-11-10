

int[]arr=new int[10];
int ind = 0;
try
{
    for(int i=-7; i<=3; i++)
    {
        try
        {
            arr[ind] = 5 * i;
            
            
            if (arr[ind] > 0)
                throw new MyException();
            else
                Console.WriteLine(arr[ind]);
          
        }
        catch (MyException my)
        {
            Console.WriteLine(my.Message);
            Console.WriteLine(my.TimeExcept);
        }
        finally { ind++; }
    }
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Внешний CATCH"); ;
    Console.WriteLine(e.Message);
}






