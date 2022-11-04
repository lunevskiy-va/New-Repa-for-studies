using Sozdaem_dom;

House One=new House();
Console.WriteLine(One);
Team team=new Team();
int day = 1;

while(true)
{
    Console.WriteLine($"День {day}");
    if (One.hs[4].IsReady == true)
    {
        team.tl.Work(One);
        Console.WriteLine("Дом построен");
        break;
    }
    else
    {
        team.tl.Work(One);
        team.worker.Work(One);
        day++;
        Console.ReadKey();
    }
}
