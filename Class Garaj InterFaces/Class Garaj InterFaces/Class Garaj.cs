

namespace Class_Garaj_InterFaces
{
    public class Garaj:iSort

    {
        public Auto[] arr;
      
        public Garaj(int Count)
        {
            arr = new Auto[Count];
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine("Введите Марку, цвет, Скорость");
                arr[i] = new Auto(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            }

        }
    
        public void SortName()
        {
          
            Array.Sort(arr, (x,y) =>x.name.CompareTo(y.name));
       

        }
        public void SortColor()
        {
            
            Array.Sort(arr, (x, y) => x.color.CompareTo(y.color));

        }
        public void SortSpeed()
        {
            
            Array.Sort(arr, (x, y) => x.speed.CompareTo(y.speed));

        }

        public override string ToString()
        {
            string vivod=null;
            for (int i = 0; i < arr.Length; i++)
            {
               vivod+=arr[i].ToString() + "\n";
            }
            return vivod;
        }

    }
}
