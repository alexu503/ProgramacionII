namespace DesgloseDeBilletesWF {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblBilletesDe100 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtBilletesDe100 = new System.Windows.Forms.TextBox();
            this.txtBilletesDe50 = new System.Windows.Forms.TextBox();
            this.txtBilletesDe20 = new System.Windows.Forms.TextBox();
            this.txtBilletesDe10 = new System.Windows.Forms.TextBox();
            this.txtBilletesDe5 = new System.Windows.Forms.TextBox();
            this.txtBilletesDe1 = new System.Windows.Forms.TextBox();
            this.txtCantidadTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(40, 48);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(85, 22);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // lblBilletesDe100
            // 
            this.lblBilletesDe100.AutoSize = true;
            this.lblBilletesDe100.Location = new System.Drawing.Point(40, 145);
            this.lblBilletesDe100.Name = "lblBilletesDe100";
            this.lblBilletesDe100.Size = new System.Drawing.Size(81, 15);
            this.lblBilletesDe100.TabIndex = 2;
            this.lblBilletesDe100.Text = "Billetes de 100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Billetes de 50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Billetes de 20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Billetes de 10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Billetes de 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Billetes de 1";
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(40, 469);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(85, 15);
            this.lblCantidadTotal.TabIndex = 2;
            this.lblCantidadTotal.Text = "Cantidad total:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(202, 48);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 22);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtBilletesDe100
            // 
            this.txtBilletesDe100.Location = new System.Drawing.Point(202, 142);
            this.txtBilletesDe100.Multiline = true;
            this.txtBilletesDe100.Name = "txtBilletesDe100";
            this.txtBilletesDe100.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe100.TabIndex = 1;
            // 
            // txtBilletesDe50
            // 
            this.txtBilletesDe50.Location = new System.Drawing.Point(202, 188);
            this.txtBilletesDe50.Multiline = true;
            this.txtBilletesDe50.Name = "txtBilletesDe50";
            this.txtBilletesDe50.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe50.TabIndex = 1;
            // 
            // txtBilletesDe20
            // 
            this.txtBilletesDe20.Location = new System.Drawing.Point(202, 238);
            this.txtBilletesDe20.Multiline = true;
            this.txtBilletesDe20.Name = "txtBilletesDe20";
            this.txtBilletesDe20.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe20.TabIndex = 1;
            // 
            // txtBilletesDe10
            // 
            this.txtBilletesDe10.Location = new System.Drawing.Point(202, 292);
            this.txtBilletesDe10.Multiline = true;
            this.txtBilletesDe10.Name = "txtBilletesDe10";
            this.txtBilletesDe10.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe10.TabIndex = 1;
            // 
            // txtBilletesDe5
            // 
            this.txtBilletesDe5.Location = new System.Drawing.Point(202, 350);
            this.txtBilletesDe5.Multiline = true;
            this.txtBilletesDe5.Name = "txtBilletesDe5";
            this.txtBilletesDe5.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe5.TabIndex = 1;
            // 
            // txtBilletesDe1
            // 
            this.txtBilletesDe1.Location = new System.Drawing.Point(202, 408);
            this.txtBilletesDe1.Multiline = true;
            this.txtBilletesDe1.Name = "txtBilletesDe1";
            this.txtBilletesDe1.Size = new System.Drawing.Size(100, 26);
            this.txtBilletesDe1.TabIndex = 1;
            // 
            // txtCantidadTotal
            // 
            this.txtCantidadTotal.Location = new System.Drawing.Point(202, 466);
            this.txtCantidadTotal.Multiline = true;
            this.txtCantidadTotal.Name = "txtCantidadTotal";
            this.txtCantidadTotal.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadTotal.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(366, 531);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBilletesDe100);
            this.Controls.Add(this.txtCantidadTotal);
            this.Controls.Add(this.txtBilletesDe1);
            this.Controls.Add(this.txtBilletesDe5);
            this.Controls.Add(this.txtBilletesDe10);
            this.Controls.Add(this.txtBilletesDe20);
            this.Controls.Add(this.txtBilletesDe50);
            this.Controls.Add(this.txtBilletesDe100);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCantidad;
        private Label lblBilletesDe100;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblCantidadTotal;
        private Button btnCalcular;
        private TextBox txtBilletesDe100;
        private TextBox txtBilletesDe50;
        private TextBox txtBilletesDe20;
        private TextBox txtBilletesDe10;
        private TextBox txtBilletesDe5;
        private TextBox txtBilletesDe1;
        private TextBox txtCantidadTotal;
    }
}