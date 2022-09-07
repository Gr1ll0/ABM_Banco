namespace _114224_Abrahamian_Alex_Problema1._3
{
    partial class CRUD
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
            this.txbox_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.txbox_Apellido = new System.Windows.Forms.TextBox();
            this.txbox_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cbu = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.dtp_ultimoMovimiento = new System.Windows.Forms.DateTimePicker();
            this.cbo_tipoCuenta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbox_nombre
            // 
            this.txbox_nombre.Location = new System.Drawing.Point(178, 51);
            this.txbox_nombre.Name = "txbox_nombre";
            this.txbox_nombre.Size = new System.Drawing.Size(96, 20);
            this.txbox_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(178, 32);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(178, 87);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txbox_Apellido
            // 
            this.txbox_Apellido.Location = new System.Drawing.Point(178, 103);
            this.txbox_Apellido.Name = "txbox_Apellido";
            this.txbox_Apellido.Size = new System.Drawing.Size(96, 20);
            this.txbox_Apellido.TabIndex = 3;
            // 
            // txbox_dni
            // 
            this.txbox_dni.Location = new System.Drawing.Point(178, 153);
            this.txbox_dni.Name = "txbox_dni";
            this.txbox_dni.Size = new System.Drawing.Size(96, 20);
            this.txbox_dni.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(15, 269);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 28);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(181, 269);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 28);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CBU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo de Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ultimo movimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Saldo";
            // 
            // txt_cbu
            // 
            this.txt_cbu.Location = new System.Drawing.Point(7, 48);
            this.txt_cbu.Name = "txt_cbu";
            this.txt_cbu.Size = new System.Drawing.Size(119, 20);
            this.txt_cbu.TabIndex = 0;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(7, 95);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(119, 20);
            this.txt_saldo.TabIndex = 2;
            // 
            // dtp_ultimoMovimiento
            // 
            this.dtp_ultimoMovimiento.Location = new System.Drawing.Point(7, 202);
            this.dtp_ultimoMovimiento.Name = "dtp_ultimoMovimiento";
            this.dtp_ultimoMovimiento.Size = new System.Drawing.Size(144, 20);
            this.dtp_ultimoMovimiento.TabIndex = 6;
            // 
            // cbo_tipoCuenta
            // 
            this.cbo_tipoCuenta.FormattingEnabled = true;
            this.cbo_tipoCuenta.Location = new System.Drawing.Point(7, 148);
            this.cbo_tipoCuenta.Name = "cbo_tipoCuenta";
            this.cbo_tipoCuenta.Size = new System.Drawing.Size(121, 21);
            this.cbo_tipoCuenta.TabIndex = 4;
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 309);
            this.Controls.Add(this.cbo_tipoCuenta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dtp_ultimoMovimiento);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbox_dni);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_cbu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbox_Apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbox_nombre);
            this.Controls.Add(this.label2);
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.CRUD_Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbox_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.TextBox txbox_Apellido;
        private System.Windows.Forms.TextBox txbox_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cbu;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.DateTimePicker dtp_ultimoMovimiento;
        private System.Windows.Forms.ComboBox cbo_tipoCuenta;
    }
}