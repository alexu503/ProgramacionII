using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgloseDeBilletes.Logic {
    internal class ContarBilletes: Billetes {

        public override void Calcular() {

            if(Cantidad >= 100) {
                billetesDe100 = (Cantidad / 100);
                Cantidad = Cantidad - (billetesDe100 * 100);
            }
            if (Cantidad >= 50 && Cantidad < 100) {
                billetesDe50 = (Cantidad / 50);
                Cantidad = Cantidad - (billetesDe50 * 50);
            }
            if (Cantidad >= 20 && Cantidad < 50) {
                billetesDe20 = (Cantidad / 20);
                Cantidad = Cantidad - (billetesDe20 * 20);
            }
            if (Cantidad >= 10 && Cantidad < 20) {
                billetesDe10 = (Cantidad / 10);
                Cantidad = Cantidad - (billetesDe10 * 10);
            }
            if (Cantidad >= 5 && Cantidad < 10) {
                billetesDe5 = (Cantidad / 5);
                Cantidad = Cantidad - (billetesDe5 * 5);
            }
        }

        public ContarBilletes(int c) {
            Cantidad = c;
        }

        public void BilletesContados() {
            Console.WriteLine("Billetes de a 100: " + billetesDe100);
            Console.WriteLine("Billetes de a 50 : " + billetesDe50);
            Console.WriteLine("Billetes de a 20 : " + billetesDe20);
            Console.WriteLine("Billetes de a 10 : " + billetesDe10);
            Console.WriteLine("Billetes de a 5 : " + billetesDe5);
            Console.WriteLine("Billetes de a 1 : " + Cantidad);
        }
    }
}
