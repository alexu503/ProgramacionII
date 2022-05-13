using System;
using DesglosarBilletes.Logic;

namespace DesglosarBilletes {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

            string a = txtRecibirCantidad.Text;
            //ContarBilletes contar = new ContarBilletes();

            if (a.Equals("")) {
                MessageBox.Show("Ingrese un valor");
            }
            else {
                ContarBilletes contarBilletes = new ContarBilletes(int.Parse(a));

                //Lomismoqueenelparcial: no muestra lo que debe mostrat :'(
                lblBilletesDe100.Text = contarBilletes.BilletesDe100.ToString();
                lblBilletesDe50.Text = contarBilletes.BilletesDe50.ToString();
                lblBilletesDe20.Text = contarBilletes.BilletesDe20.ToString();
                lblBilletesDe10.Text = contarBilletes.BilletesDe10.ToString();
                lblBilletesDe5.Text = contarBilletes.BilletesDe5.ToString();
                lblCantidadTotal.Text = contarBilletes.Cantidad.ToString();
            }

            txtRecibirCantidad.Clear();
            txtRecibirCantidad.Focus();
        }

        private void txtRecibirCantidad_KeyPress(object sender, KeyPressEventArgs e) {
            if (!(char.IsDigit(e.KeyChar))) {
                MessageBox.Show("Solo valores numéricos");
            }
        }
    }
}
