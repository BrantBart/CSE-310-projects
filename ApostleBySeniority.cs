using System;
using System.Collections.Generic;
using System.Linq;

namespace ApostlesApp
{
    class ApostlesBySeniority : Sorter
    {
        public ApostlesBySeniority(List<Apostle> apostles) : base(apostles)
        {
            Apostles = apostles.OrderBy(a => a.Seniority).ToList();
        }

        public override void Display()
        {
            foreach (var apostle in Apostles)
            {
                Console.WriteLine($"{apostle.Seniority}. {apostle.Name}");
            }
        }
    }
}
