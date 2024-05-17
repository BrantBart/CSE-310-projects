using System;
using System.Collections.Generic;
using System.Linq;

namespace ApostlesApp
{
    class ApostlesByAlphabeticalOrder : Sorter
    {
        public ApostlesByAlphabeticalOrder(List<Apostle> apostles) : base(apostles)
        {
            Apostles = apostles.OrderBy(a => a.Name).ToList();
        }

        public override void Display()
        {
            foreach (var apostle in Apostles)
            {
                Console.WriteLine($"{apostle.Name}");
            }
        }
    }
}
