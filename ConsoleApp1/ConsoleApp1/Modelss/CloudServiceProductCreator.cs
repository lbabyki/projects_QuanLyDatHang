using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelss
{
    public class CloudServiceProductCreator : ProductCreator
    {
        public override IDigitalProduct CreateProduct() => new CloudServiceProduct();
    }
}
