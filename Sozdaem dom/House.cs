
using System.ComponentModel.DataAnnotations;

namespace Sozdaem_dom
{
    public class House
    {
        public IPart[] hs = { new Basement(), new Walls(), new Door(), new Window(), new Roof() };

        public House(bool Basement=false,bool Walls=false, bool Door=false,bool Window=false,bool Roof=false)
        {
            hs[0].IsReady = Basement;
            hs[1].IsReady = Walls;
            hs[2].IsReady = Door;
            hs[3].IsReady = Window;
            hs[4].IsReady = Roof;
        }

        public IPart[] HS
        {
            get { return hs; }
        }

        public bool this[int index]
        {
            get
            {
                return this.hs[index].IsReady;
            }
            set
            {
                this.hs[index].IsReady = value;
            }
        }

        public override string ToString()
        {
            return $"{hs[0]}\n{hs[1]}\n{hs[2]}\n{hs[3]}\n{hs[4]}";
        }

    }
}
