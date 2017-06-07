using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBuilder builder = new ConcreteBuilder();

            Director director = new Director(builder);

            director.Construct();

            Product product = builder.GetResult();
            product.Show();

        }
    }
}
