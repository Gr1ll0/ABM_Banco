namespace _114224_Abrahamian_Alex_Problema1._3
{
    partial class CRUD_Cliente
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
            this.txbox_cbu = new System.Windows.Forms.TextBox();
            this.lbl_cbu = new System.Windows.Forms.Label();
            this.txbox_dni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbox_nombre
            // 
            this.txbox_nombre.Location = new System.Drawing.Point(42, 55);
            this.txbox_nombre.Name = "txbox_nombre";
            this.txbox_nombre.Size = new System.Drawing.Size(96, 20);
            this.txbox_nombre.TabIndex = 0;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(42, 36);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(42, 91);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido";
            // 
            // txbox_Apellido
            // 
            this.txbox_Apellido.Location = new System.Drawing.Point(42, 107);
            this.txbox_Apellido.Name = "txbox_Apellido";
            this.txbox_Apellido.Size = new System.Drawing.Size(96, 20);
            this.txbox_Apellido.TabIndex = 1;
            // 
            // txbox_cbu
            // 
            this.txbox_cbu.Location = new System.Drawing.Point(42, 205);
            this.txbox_cbu.Name = "txbox_cbu";
            this.txbox_cbu.Size = new System.Drawing.Size(96, 20);
            this.txbox_cbu.TabIndex = 2;
            // 
            // lbl_cbu
            // 
            this.lbl_cbu.AutoSize = true;
            this.lbl_cbu.Location = new System.Drawing.Point(42, 189);
            this.lbl_cbu.Name = "lbl_cbu";
            this.lbl_cbu.Size = new System.Drawing.Size(29, 13);
            this.lbl_cbu.TabIndex = 5;
            this.lbl_cbu.Text = "CBU";
            // 
            // txbox_dni
            // 
            this.txbox_dni.Location = new System.Drawing.Point(42, 157);
            this.txbox_dni.Name = "txbox_dni";
            this.txbox_dni.Size = new System.Drawing.Size(96, 20);
            this.txbox_dni.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(12, 269);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 28);
            this.btn_registrar.TabIndex = 8;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(102, 269);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 28);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CRUD_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 309);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbox_dni);
            this.Controls.Add(this.lbl_cbu);
            this.Controls.Add(this.txbox_cbu);
            this.Controls.Add(this.txbox_Apellido);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txbox_nombre);
            this.Name = "CRUD_Cliente";
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
        private System.Windows.Forms.TextBox txbox_cbu;
        private System.Windows.Forms.Label lbl_cbu;
        private System.Windows.Forms.TextBox txbox_dni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}