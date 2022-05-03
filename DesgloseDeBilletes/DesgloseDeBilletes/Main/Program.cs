using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesgloseDeBilletes.Logic;

namespace DesgloseDeBilletes {
    internal class Program {
        static void Main(string[] args) {

            int cantidad = 0;

            Console.Write("Digite una cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            ContarBilletes c = new ContarBilletes(cantidad);

            c.Calcular();
            c.BilletesContados();
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
