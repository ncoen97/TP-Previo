using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola121.Clases
{
    public class Control
    {
        public List<Cliente> clientes;

        public void ContarCuentas(int doc, int saldo)
        {
            Cliente cliente;
            int cantidad;

            cliente = BuscarCliente(doc);

            if (cliente == null)
                Console.WriteLine("El cliente no existe.");

            
            else
            { 
                cantidad = cliente.GetCuentas().Where(x => x.GetSaldo() > saldo).ToList().Count; //modularidad? que es eso? 
                Console.WriteLine("Lantidad de cuentas con un saldo mayor a {0} es igual {1}:", saldo, cantidad);
            }
        }

        public Cliente BuscarCliente(int doc)
        {
            Cliente cliente = null;
            cliente = clientes.Find(x => x.GetDoc() == doc);
            return cliente;
        }

        

    }
}
