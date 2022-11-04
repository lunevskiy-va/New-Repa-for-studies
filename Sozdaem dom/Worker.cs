
namespace Sozdaem_dom
{
    public class Worker : Iworker
    {

        public void Work(House obj)
        {
            for (int i = 0; i < obj.HS.Length; i++)
            {
                if (obj.HS[i].IsReady == false)
                {
                    obj.HS[i].IsReady = true;
                    break;
                }
            }
        }

    }
   
}
