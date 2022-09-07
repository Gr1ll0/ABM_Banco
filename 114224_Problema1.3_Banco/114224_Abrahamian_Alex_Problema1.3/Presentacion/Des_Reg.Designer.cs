namespace _114224_Abrahamian_Alex_Problema1._3.Presentacion
{
    partial class Des_Reg
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
            this.dgv_reg_des = new System.Windows.Forms.DataGridView();
            this.Btn_habilitar_confi = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg_des)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_reg_des
            // 
            this.dgv_reg_des.AllowUserToAddRows = false;
            this.dgv_reg_des.AllowUserToDeleteRows = false;
            this.dgv_reg_des.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reg_des.Location = new System.Drawing.Point(12, 12);
            this.dgv_reg_des.Name = "dgv_reg_des";
            this.dgv_reg_des.ReadOnly = true;
            this.dgv_reg_des.Size = new System.Drawing.Size(537, 280);
            this.dgv_reg_des.TabIndex = 0;
            this.dgv_reg_des.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_habilitar_confi
            // 
            this.Btn_habilitar_confi.Location = new System.Drawing.Point(110, 298);
            this.Btn_habilitar_confi.Name = "Btn_habilitar_confi";
            this.Btn_habilitar_confi.Size = new System.Drawing.Size(91, 40);
            this.Btn_habilitar_confi.TabIndex = 1;
            this.Btn_habilitar_confi.Text = "Confirmar";
            this.Btn_habilitar_confi.UseVisualStyleBackColor = true;
            this.Btn_habilitar_confi.Click += new System.EventHandler(this.Btn_habilitar_confi_Click);
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(474, 298);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(75, 40);
            this.Btn_Volver.TabIndex = 2;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            this.Btn_Volver.Click += new System.EventHandler(this.Btn_Volver_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(207, 298);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 40);
            this.Btn_Cancelar.TabIndex = 3;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Des_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 350);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Volver);
            this.Controls.Add(this.Btn_habilitar_confi);
            this.Controls.Add(this.dgv_reg_des);
            this.Name = "Des_Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Des_Reg";
            this.Load += new System.EventHandler(this.Des_Reg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reg_des)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_reg_des;
        private System.Windows.Forms.Button Btn_habilitar_confi;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}