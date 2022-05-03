using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesgloseDeBilletes.Logic {
    internal abstract class Billetes {

        protected int cantidad;
        protected int billetesDe100;
        protected int billetesDe50;
        protected int billetesDe20;
        protected int billetesDe10;
        protected int billetesDe5;

        public int Cantidad {
            set { this.cantidad = value; }
            get { return this.cantidad; }
        }

        public int BilletesDe100 {
            set { this.billetesDe100 = value; }
            get { return this.billetesDe100; }
        }

        public int BilletesDe50 {
            set { this.billetesDe50 = value; }
            get { return this.billetesDe50; }
        }

        public int BilletesDe20 {
            set { this.billetesDe20 = value; }
            get { return this.billetesDe20; }
        }

        public int BilletesDe10 {
            set { this.billetesDe10 = value; }
            get { return this.billetesDe10; }
        }

        public int BilletesDe5 {
            set { this.billetesDe5 = value; }
            get { return this.billetesDe5; }
        }

        public abstract void Calcular();
    }
}
