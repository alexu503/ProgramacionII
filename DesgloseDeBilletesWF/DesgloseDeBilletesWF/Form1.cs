namespace DesgloseDeBilletesWF {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e) {

        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e) {
            int c = int.Parse(txtCantidad.Text);
            Conteo contar = new Conteo(c);

            lblBilletesDe100.Text = ("Billetes de a 100: " + c.BilletesDe100);
            Console.WriteLine("Billetes de a 50 : " + billetesDe50);
            Console.WriteLine("Billetes de a 20 : " + billetesDe20);
            Console.WriteLine("Billetes de a 10 : " + billetesDe10);
            Console.WriteLine("Billetes de a 5 : " + billetesDe5);
            Console.WriteLine("Billetes de a 1 : " + Cantidad);
        }
    }
}
