using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelss
{
    public class MobileAppProduct : IDigitalProduct
    {
        public void Deliver() => Console.WriteLine("🔹 Deploying Mobile Application...");
    }
}
