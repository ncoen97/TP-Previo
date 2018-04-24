using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola121.Clases
{

    public class Cliente
    {
        public List<Cuenta> cuentas;
        public int doc; 

        public List<Cuenta> GetCuentas() {

            return cuentas;

        }
        public int GetDoc()
        {

            return doc;

        }
    }
}
