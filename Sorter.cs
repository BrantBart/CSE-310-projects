using System.Collections.Generic;

namespace ApostlesApp
{
    abstract class Sorter
    {
        protected List<Apostle> Apostles;

        public Sorter(List<Apostle> apostles)
        {
            Apostles = apostles;
        }

        public abstract void Display();
    }
}
