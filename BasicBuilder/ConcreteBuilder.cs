using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicBuilder
{
    class ConcreteBuilder : IBuilder
    {
        Product product = new Product();
        public void BuildPartA()
        {
            product.Add("Part A");
        }

        public void BuildPartB()
        {
            product.Add("Part B");
        }

        public void BuildPartC()
        {
            product.Add("Part C");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
