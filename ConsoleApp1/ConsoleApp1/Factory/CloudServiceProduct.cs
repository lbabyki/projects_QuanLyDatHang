using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Factory
{
public class CloudServiceProduct : IDigitalProduct
{
    public void Deliver() => Console.WriteLine("Activating cloud service...");
}



}
