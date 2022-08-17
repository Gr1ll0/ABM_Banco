namespace _114224_Abrahamian_Alex_Problema1._3
{
    partial class CRUD_Cuenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_cbu = new System.Windows.Forms.TextBox();
            this.txbox_Saldo = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dTP_ultimoMov = new System.Windows.Forms.DateTimePicker();
            this.comB_tipoCuenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ultimo movimiento";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saldo";
            // 
            // txbox_cbu
            // 
            this.txbox_cbu.Location = new System.Drawing.Point(18, 54);
            this.txbox_cbu.Name = "txbox_cbu";
            this.txbox_cbu.Size = new System.Drawing.Size(119, 20);
            this.txbox_cbu.TabIndex = 0;
            // 
            // txbox_Saldo
            // 
            this.txbox_Saldo.Location = new System.Drawing.Point(18, 101);
            this.txbox_Saldo.Name = "txbox_Saldo";
            this.txbox_Saldo.Size = new System.Drawing.Size(119, 20);
            this.txbox_Saldo.TabIndex = 1;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(12, 269);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 28);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(102, 269);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 28);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // dTP_ultimoMov
            // 
            this.dTP_ultimoMov.Location = new System.Drawing.Point(18, 208);
            this.dTP_ultimoMov.Name = "dTP_ultimoMov";
            this.dTP_ultimoMov.Size = new System.Drawing.Size(144, 20);
            this.dTP_ultimoMov.TabIndex = 6;
            // 
            // comB_tipoCuenta
            // 
            this.comB_tipoCuenta.FormattingEnabled = true;
            this.comB_tipoCuenta.Location = new System.Drawing.Point(18, 154);
            this.comB_tipoCuenta.Name = "comB_tipoCuenta";
            this.comB_tipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.comB_tipoCuenta.TabIndex = 2;
            // 
            // CRUD_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 309);
            this.Controls.Add(this.comB_tipoCuenta);
            this.Controls.Add(this.dTP_ultimoMov);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txbox_Saldo);
            this.Controls.Add(this.txbox_cbu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CRUD_Cuenta";
            this.Text = "CRUD_Cuenta";
            this.Load += new System.EventHandler(this.CRUD_Cuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbox_cbu;
        private System.Windows.Forms.TextBox txbox_Saldo;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DateTimePicker dTP_ultimoMov;
        private System.Windows.Forms.ComboBox comB_tipoCuenta;
    }
}