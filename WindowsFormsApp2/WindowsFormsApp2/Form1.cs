using System;
using System.Windows.Forms;

namespace WindowsFormsApp2 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e) {
            if(txtAddNumber.Text != "") {
                listView1.Items.Add(txtAddNumber.Text);
                txtAddNumber.Clear();
                txtAddNumber.Focus();
            }
        }

        public int FindBigger() {

            int arraySize = listView1.Items.Count;
            int[] values = new int[arraySize];

            for (int x = 0; x < arraySize; x++) {
                values[x] = int.Parse(listView1.Items[x].Text);
            }

            for (int x = 0; x < arraySize; x++) {

                for (int i = 0; i < arraySize - 1; i++) {

                    if (values[i] > values[i + 1]) {
                        int aux = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = aux;
                        
                    }
                }
            }
            return values[arraySize - 1];
        }

        public int FindSmaller() {

            int arraySize = listView1.Items.Count;
            int[] values = new int[arraySize];

            for (int x = 0; x < arraySize; x++) {
                values[x] = int.Parse(listView1.Items[x].Text);
            }

            for (int x = 0; x < arraySize; x++) {

                for (int i = 0; i < arraySize - 1; i++) {

                    if (values[i] > values[i + 1]) {
                        int aux = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = aux;
                    }
                }
            }
            return values[0];
        }

        int FindBiggerNegative() {

            int arraySize = listView1.Items.Count;
            int[] values = new int[arraySize];
            int biggerNegative = -1000;

            for(int x = 0; x < arraySize; x++) {
                values[x] = int.Parse(listView1.Items[x].Text);
            }

            //burbuja
            for (int x = 0; x < listView1.Items.Count; x++) {

                for (int i = 0; i < listView1.Items.Count - 1; i++) {
                    if (values[i] > biggerNegative && values[i] < 0) {
                        biggerNegative = values[i];
                    }
                }
            }
            return biggerNegative;
        }

        private void btnViewResults_Click(object sender, EventArgs e) {
            txtBiggerNumber.Text = FindBigger().ToString();
            txtSmallNumber.Text = FindSmaller().ToString();
            txtBiggerNegative.Text = FindBiggerNegative().ToString();
        }
    }
}
