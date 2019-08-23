using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            CKunde einKunde = new CKunde();
            CKunde zweiterKunde = new CKunde("Maier", 123);
        }
    }
}
