using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola121
{
    class Program
    {
        static void Main(string[] args)
        {

            int doc;
            int saldo;
            char c;

            Clases.Control control = new Clases.Control();

            control.clientes = new List<Clases.Cliente>();
            control.clientes.Add(
              new Clases.Cliente() { doc = 123456789, cuentas = new List<Clases.Cuenta> () {
                 new Clases.Cuenta(){nombre = "Caja de Ahorro", saldo = 20 },
                 new Clases.Cuenta(){nombre = "Cuenta Corriente", saldo = 35 },
                 new Clases.Cuenta(){nombre = "Caja de ahorro en U$S", saldo = 2*20 }
              }
              });
            control.clientes.Add(
              new Clases.Cliente(){ doc = 456789123, cuentas = new List<Clases.Cuenta>() {
                 new Clases.Cuenta(){nombre = "Caja de Ahorro", saldo = 20 },
                 new Clases.Cuenta(){nombre = "Cuenta Corriente", saldo = 35 },
                 new Clases.Cuenta(){nombre = "Caja de ahorro en U$S", saldo = 1*20 }
              }
              });

            do
            {
                Console.WriteLine("\nIngrese el documento del cliente que desea buscar:");
                doc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el saldo minimo en las cuentas:");
                saldo = Convert.ToInt32(Console.ReadLine());

                control.ContarCuentas(doc, saldo);

                Console.WriteLine("Desea verificar otro Cliente?(s/n):");
                c = Console.ReadKey().KeyChar;
                
            } while (c != 'n');


            

        }
    }
}
