using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobucle6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TUTORIAL 6|  Encontrar La Suma Del Primer Y Último Dígito De Cualquier Número

            int numero, suma = 0, p, u;

            Console.WriteLine("Ingrese un Número: ");
            numero=Convert.ToInt32(Console.ReadLine());

            u = numero % 10;

            p = numero;

            while (numero >= 10)
            {
                numero=numero/10;
            }
            p = numero;

            suma = p + u;

            Console.WriteLine("La suma del primer y ultimo digito es: " + suma);
            Console.ReadLine();

        }
    }
}
