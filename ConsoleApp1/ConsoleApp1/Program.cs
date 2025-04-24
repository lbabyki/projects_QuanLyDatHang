using ConsoleApp1.Modelss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách các creator để thử nghiệm
            ProductCreator[] creators = new ProductCreator[]
            {
                new SoftwareProductCreator(),
                new CloudServiceProductCreator(),
                new MobileAppProductCreator(),
                new ApiProductCreator(),
                new DigitalDocumentProductCreator()
            };

            // Duyệt qua từng creator và gọi phương thức Deliver
            foreach (var creator in creators)
            {
                IDigitalProduct product = creator.CreateProduct();
                product.Deliver();
            }
        }
    }
}
