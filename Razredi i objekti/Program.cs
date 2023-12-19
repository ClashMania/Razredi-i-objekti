using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razredi_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder neboder = new Neboder();
            neboder.SetVisina(200);
            neboder.SetBrojKatova(100);

            Console.WriteLine("Tower: ");
            Console.WriteLine(neboder.ToString());
                        
            Console.ReadKey();
        }
    }
}
