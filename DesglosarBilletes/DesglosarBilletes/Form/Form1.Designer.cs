namespace DesglosarBilletes {
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
            this.txtRecibirCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblBilletesDe100Text = new System.Windows.Forms.Label();
            this.lblBilletesDe50Text = new System.Windows.Forms.Label();
            this.lblBilletesDe20Text = new System.Windows.Forms.Label();
            this.lblBilletesDe10Text = new System.Windows.Forms.Label();
            this.lblBilletesDe5Text = new System.Windows.Forms.Label();
            this.lblCantidadTotalText = new System.Windows.Forms.Label();
            this.lblBilletesDe100 = new System.Windows.Forms.Label();
            this.lblBilletesDe50 = new System.Windows.Forms.Label();
            this.lblBilletesDe20 = new System.Windows.Forms.Label();
            this.lblBilletesDe10 = new System.Windows.Forms.Label();
            this.lblBilletesDe5 = new System.Windows.Forms.Label();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecibirCantidad
            // 
            this.txtRecibirCantidad.Location = new System.Drawing.Point(30, 32);
            this.txtRecibirCantidad.Name = "txtRecibirCantidad";
            this.txtRecibirCantidad.PlaceholderText = "Cantidad:";
            this.txtRecibirCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtRecibirCantidad.TabIndex = 0;
            this.txtRecibirCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecibirCantidad_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(186, 31);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 24);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblBilletesDe100Text
            // 
            this.lblBilletesDe100Text.AutoSize = true;
            this.lblBilletesDe100Text.Location = new System.Drawing.Point(30, 104);
            this.lblBilletesDe100Text.Name = "lblBilletesDe100Text";
            this.lblBilletesDe100Text.Size = new System.Drawing.Size(84, 15);
            this.lblBilletesDe100Text.TabIndex = 2;
            this.lblBilletesDe100Text.Text = "Billetes de 100:";
            // 
            // lblBilletesDe50Text
            // 
            this.lblBilletesDe50Text.AutoSize = true;
            this.lblBilletesDe50Text.Location = new System.Drawing.Point(30, 151);
            this.lblBilletesDe50Text.Name = "lblBilletesDe50Text";
            this.lblBilletesDe50Text.Size = new System.Drawing.Size(78, 15);
            this.lblBilletesDe50Text.TabIndex = 2;
            this.lblBilletesDe50Text.Text = "Billetes de 50:";
            // 
            // lblBilletesDe20Text
            // 
            this.lblBilletesDe20Text.AutoSize = true;
            this.lblBilletesDe20Text.Location = new System.Drawing.Point(30, 206);
            this.lblBilletesDe20Text.Name = "lblBilletesDe20Text";
            this.lblBilletesDe20Text.Size = new System.Drawing.Size(78, 15);
            this.lblBilletesDe20Text.TabIndex = 2;
            this.lblBilletesDe20Text.Text = "Billetes de 20:";
            // 
            // lblBilletesDe10Text
            // 
            this.lblBilletesDe10Text.AutoSize = true;
            this.lblBilletesDe10Text.Location = new System.Drawing.Point(30, 260);
            this.lblBilletesDe10Text.Name = "lblBilletesDe10Text";
            this.lblBilletesDe10Text.Size = new System.Drawing.Size(78, 15);
            this.lblBilletesDe10Text.TabIndex = 2;
            this.lblBilletesDe10Text.Text = "Billetes de 10:";
            // 
            // lblBilletesDe5Text
            // 
            this.lblBilletesDe5Text.AutoSize = true;
            this.lblBilletesDe5Text.Location = new System.Drawing.Point(30, 315);
            this.lblBilletesDe5Text.Name = "lblBilletesDe5Text";
            this.lblBilletesDe5Text.Size = new System.Drawing.Size(72, 15);
            this.lblBilletesDe5Text.TabIndex = 2;
            this.lblBilletesDe5Text.Text = "Billetes de 5:";
            // 
            // lblCantidadTotalText
            // 
            this.lblCantidadTotalText.AutoSize = true;
            this.lblCantidadTotalText.Location = new System.Drawing.Point(30, 378);
            this.lblCantidadTotalText.Name = "lblCantidadTotalText";
            this.lblCantidadTotalText.Size = new System.Drawing.Size(85, 15);
            this.lblCantidadTotalText.TabIndex = 2;
            this.lblCantidadTotalText.Text = "Cantidad total:";
            // 
            // lblBilletesDe100
            // 
            this.lblBilletesDe100.AutoSize = true;
            this.lblBilletesDe100.Location = new System.Drawing.Point(186, 104);
            this.lblBilletesDe100.Name = "lblBilletesDe100";
            this.lblBilletesDe100.Size = new System.Drawing.Size(0, 15);
            this.lblBilletesDe100.TabIndex = 2;
            // 
            // lblBilletesDe50
            // 
            this.lblBilletesDe50.AutoSize = true;
            this.lblBilletesDe50.Location = new System.Drawing.Point(186, 151);
            this.lblBilletesDe50.Name = "lblBilletesDe50";
            this.lblBilletesDe50.Size = new System.Drawing.Size(0, 15);
            this.lblBilletesDe50.TabIndex = 2;
            // 
            // lblBilletesDe20
            // 
            this.lblBilletesDe20.AutoSize = true;
            this.lblBilletesDe20.Location = new System.Drawing.Point(186, 206);
            this.lblBilletesDe20.Name = "lblBilletesDe20";
            this.lblBilletesDe20.Size = new System.Drawing.Size(0, 15);
            this.lblBilletesDe20.TabIndex = 2;
            // 
            // lblBilletesDe10
            // 
            this.lblBilletesDe10.AutoSize = true;
            this.lblBilletesDe10.Location = new System.Drawing.Point(186, 260);
            this.lblBilletesDe10.Name = "lblBilletesDe10";
            this.lblBilletesDe10.Size = new System.Drawing.Size(0, 15);
            this.lblBilletesDe10.TabIndex = 2;
            // 
            // lblBilletesDe5
            // 
            this.lblBilletesDe5.AutoSize = true;
            this.lblBilletesDe5.Location = new System.Drawing.Point(186, 315);
            this.lblBilletesDe5.Name = "lblBilletesDe5";
            this.lblBilletesDe5.Size = new System.Drawing.Size(0, 15);
            this.lblBilletesDe5.TabIndex = 2;
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(186, 378);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(0, 15);
            this.lblCantidadTotal.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(297, 420);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.lblBilletesDe5);
            this.Controls.Add(this.lblCantidadTotalText);
            this.Controls.Add(this.lblBilletesDe10);
            this.Controls.Add(this.lblBilletesDe5Text);
            this.Controls.Add(this.lblBilletesDe20);
            this.Controls.Add(this.lblBilletesDe10Text);
            this.Controls.Add(this.lblBilletesDe50);
            this.Controls.Add(this.lblBilletesDe20Text);
            this.Controls.Add(this.lblBilletesDe100);
            this.Controls.Add(this.lblBilletesDe50Text);
            this.Controls.Add(this.lblBilletesDe100Text);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtRecibirCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Desglosar billetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtRecibirCantidad;
        private Button btnCalcular;
        private Label lblBilletesDe100Text;
        private Label lblBilletesDe50Text;
        private Label lblBilletesDe20Text;
        private Label lblBilletesDe10Text;
        private Label lblBilletesDe5Text;
        private Label lblCantidadTotalText;
        private Label lblBilletesDe100;
        private Label lblBilletesDe50;
        private Label lblBilletesDe20;
        private Label lblBilletesDe10;
        private Label lblBilletesDe5;
        private Label lblCantidadTotal;
    }
}