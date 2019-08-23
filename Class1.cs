using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    class CPerson
    {
        private string name;
        public CPerson()
        {
            name = "LEER";
        }
        public CPerson(string nameParam)
        {
            name = nameParam;
        }
    }

    class CKunde : CPerson
    {
        private int KundenID;
        public CKunde() : base()
        {
            KundenID = 0;
        }


        public CKunde(string nameParam, int KundenIDParam) :
            base(nameParam)

        {
            KundenID = KundenIDParam;
        }

        class Program
        {
            CKunde einKunde = new CKunde();
            CKunde zweiterKunde = new CKunde("Maier", 123);
        }
    }
}
