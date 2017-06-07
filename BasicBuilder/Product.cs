using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBuilder
{
    class Product
    {
        ArrayList Parts = new ArrayList();

        public void Add(string part)
        {
            Parts.Add(part);
        }

        public void Show()
        {
            foreach (var part in Parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
