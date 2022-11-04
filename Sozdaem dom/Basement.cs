

namespace Sozdaem_dom
{
 public class Basement: IPart
    {
       public bool Ready=false;

        public bool IsReady { get => Ready; set => Ready = value; }

        public override string ToString()
        {
            return $"Фундамент:{Ready}";
        }


    }
}
