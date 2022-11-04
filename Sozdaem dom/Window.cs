using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sozdaem_dom
{
    internal class Window : IPart
    {
        public bool Ready = false;

        public bool IsReady { get => Ready; set => Ready = value; }

        public override string ToString()
        {
            return $"Окна:{Ready}";
        }
    }

}
