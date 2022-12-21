using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class ExecutaTestes
    {
        static void Main(string[] args)
        {
            Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.1M, 90));
            Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.1M, 100));
            Console.WriteLine(POV.funcaoRetornaQuantitadePOV(0.2M, 70));
        }
    }
}
