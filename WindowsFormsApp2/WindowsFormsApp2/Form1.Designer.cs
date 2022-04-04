
namespace WindowsFormsApp2 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.lblBiggerNegative = new System.Windows.Forms.Label();
            this.lblSmallNumber = new System.Windows.Forms.Label();
            this.lblBiggerNumber = new System.Windows.Forms.Label();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtAddNumber = new System.Windows.Forms.TextBox();
            this.txtSmallNumber = new System.Windows.Forms.TextBox();
            this.txtBiggerNegative = new System.Windows.Forms.TextBox();
            this.txtBiggerNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Location = new System.Drawing.Point(161, 32);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(86, 13);
            this.lblAddNumber.TabIndex = 0;
            this.lblAddNumber.Text = "Ingresar número:";
            // 
            // lblBiggerNegative
            // 
            this.lblBiggerNegative.AutoSize = true;
            this.lblBiggerNegative.Location = new System.Drawing.Point(161, 254);
            this.lblBiggerNegative.Name = "lblBiggerNegative";
            this.lblBiggerNegative.Size = new System.Drawing.Size(83, 13);
            this.lblBiggerNegative.TabIndex = 2;
            this.lblBiggerNegative.Text = "Mayor negativo:";
            // 
            // lblSmallNumber
            // 
            this.lblSmallNumber.AutoSize = true;
            this.lblSmallNumber.Location = new System.Drawing.Point(161, 201);
            this.lblSmallNumber.Name = "lblSmallNumber";
            this.lblSmallNumber.Size = new System.Drawing.Size(79, 13);
            this.lblSmallNumber.TabIndex = 3;
            this.lblSmallNumber.Text = "Número menor:";
            // 
            // lblBiggerNumber
            // 
            this.lblBiggerNumber.AutoSize = true;
            this.lblBiggerNumber.Location = new System.Drawing.Point(161, 147);
            this.lblBiggerNumber.Name = "lblBiggerNumber";
            this.lblBiggerNumber.Size = new System.Drawing.Size(78, 13);
            this.lblBiggerNumber.TabIndex = 4;
            this.lblBiggerNumber.Text = "Número mayor:";
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(350, 28);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(100, 21);
            this.btnAddNumber.TabIndex = 5;
            this.btnAddNumber.Text = "Agregar a la lista";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnViewResults
            // 
            this.btnViewResults.Location = new System.Drawing.Point(350, 91);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(100, 20);
            this.btnViewResults.TabIndex = 6;
            this.btnViewResults.Text = "Ver resultados";
            this.btnViewResults.UseVisualStyleBackColor = true;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(92, 288);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(253, 29);
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(75, 20);
            this.txtAddNumber.TabIndex = 8;
            // 
            // txtSmallNumber
            // 
            this.txtSmallNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSmallNumber.Enabled = false;
            this.txtSmallNumber.Location = new System.Drawing.Point(350, 194);
            this.txtSmallNumber.Name = "txtSmallNumber";
            this.txtSmallNumber.ReadOnly = true;
            this.txtSmallNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSmallNumber.TabIndex = 9;
            // 
            // txtBiggerNegative
            // 
            this.txtBiggerNegative.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBiggerNegative.Enabled = false;
            this.txtBiggerNegative.Location = new System.Drawing.Point(350, 254);
            this.txtBiggerNegative.Name = "txtBiggerNegative";
            this.txtBiggerNegative.ReadOnly = true;
            this.txtBiggerNegative.Size = new System.Drawing.Size(100, 20);
            this.txtBiggerNegative.TabIndex = 10;
            // 
            // txtBiggerNumber
            // 
            this.txtBiggerNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBiggerNumber.Enabled = false;
            this.txtBiggerNumber.Location = new System.Drawing.Point(350, 140);
            this.txtBiggerNumber.Name = "txtBiggerNumber";
            this.txtBiggerNumber.ReadOnly = true;
            this.txtBiggerNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBiggerNumber.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 348);
            this.Controls.Add(this.txtBiggerNumber);
            this.Controls.Add(this.txtBiggerNegative);
            this.Controls.Add(this.txtSmallNumber);
            this.Controls.Add(this.txtAddNumber);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnViewResults);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.lblBiggerNumber);
            this.Controls.Add(this.lblSmallNumber);
            this.Controls.Add(this.lblBiggerNegative);
            this.Controls.Add(this.lblAddNumber);
            this.Name = "Form1";
            this.Text = "Number list";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.Label lblBiggerNegative;
        private System.Windows.Forms.Label lblSmallNumber;
        private System.Windows.Forms.Label lblBiggerNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.TextBox txtAddNumber;
        private System.Windows.Forms.TextBox txtSmallNumber;
        private System.Windows.Forms.TextBox txtBiggerNegative;
        private System.Windows.Forms.TextBox txtBiggerNumber;
        public System.Windows.Forms.ListView listView1;
    }
}

