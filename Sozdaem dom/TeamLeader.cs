using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozdaem_dom
{
    public class TeamLeader:Iworker
    {
        public void Work(House obj)
        {
            for (int i = 0; i < obj.HS.Length; i++)
            {
                if (obj.HS[i].IsReady == false)
                {
                    Console.WriteLine("Дом не готов");
                    break;
                }
            }
        }

    }
}
