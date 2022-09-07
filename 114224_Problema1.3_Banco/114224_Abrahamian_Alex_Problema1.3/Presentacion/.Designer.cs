namespace _114224_Abrahamian_Alex_Problema1._3
{
    partial class GridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dGV_out = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.inhabilitarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaYClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosDeshabilitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_out)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_out
            // 
            this.dGV_out.AllowUserToAddRows = false;
            this.dGV_out.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightYellow;
            this.dGV_out.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_out.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_out.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV_out.Location = new System.Drawing.Point(12, 23);
            this.dGV_out.Name = "dGV_out";
            this.dGV_out.ReadOnly = true;
            this.dGV_out.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_out.Size = new System.Drawing.Size(746, 286);
            this.dGV_out.TabIndex = 0;
            this.dGV_out.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_out_CellContentClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(585, 315);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(99, 49);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.registrarToolStripMenuItem.Text = "Registro";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem1});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.editarToolStripMenuItem.Text = "Edición";
            // 
            // registroToolStripMenuItem1
            // 
            this.registroToolStripMenuItem1.Name = "registroToolStripMenuItem1";
            this.registroToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.registroToolStripMenuItem1.Text = "Registro";
            this.registroToolStripMenuItem1.Click += new System.EventHandler(this.registroToolStripMenuItem1_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem2,
            this.inhabilitarRegistroToolStripMenuItem});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.borrarToolStripMenuItem.Text = "Bajas";
            // 
            // registroToolStripMenuItem2
            // 
            this.registroToolStripMenuItem2.Name = "registroToolStripMenuItem2";
            this.registroToolStripMenuItem2.Size = new System.Drawing.Size(170, 22);
            this.registroToolStripMenuItem2.Text = "Borrar Registro";
            this.registroToolStripMenuItem2.Click += new System.EventHandler(this.registroToolStripMenuItem2_Click);
            // 
            // inhabilitarRegistroToolStripMenuItem
            // 
            this.inhabilitarRegistroToolStripMenuItem.Name = "inhabilitarRegistroToolStripMenuItem";
            this.inhabilitarRegistroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.inhabilitarRegistroToolStripMenuItem.Text = "Inhabilitar registro";
            this.inhabilitarRegistroToolStripMenuItem.Click += new System.EventHandler(this.inhabilitarRegistroToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem3,
            this.clienteToolStripMenuItem3,
            this.cuentaYClienteToolStripMenuItem,
            this.registrosDeshabilitadosToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.verToolStripMenuItem.Text = "Vista";
            // 
            // cuentaToolStripMenuItem3
            // 
            this.cuentaToolStripMenuItem3.Name = "cuentaToolStripMenuItem3";
            this.cuentaToolStripMenuItem3.Size = new System.Drawing.Size(202, 22);
            this.cuentaToolStripMenuItem3.Text = "Cuenta";
            this.cuentaToolStripMenuItem3.Click += new System.EventHandler(this.cuentaToolStripMenuItem3_Click);
            // 
            // clienteToolStripMenuItem3
            // 
            this.clienteToolStripMenuItem3.Name = "clienteToolStripMenuItem3";
            this.clienteToolStripMenuItem3.Size = new System.Drawing.Size(202, 22);
            this.clienteToolStripMenuItem3.Text = "Cliente";
            this.clienteToolStripMenuItem3.Click += new System.EventHandler(this.clienteToolStripMenuItem3_Click);
            // 
            // cuentaYClienteToolStripMenuItem
            // 
            this.cuentaYClienteToolStripMenuItem.Name = "cuentaYClienteToolStripMenuItem";
            this.cuentaYClienteToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cuentaYClienteToolStripMenuItem.Text = "Cuenta y Cliente";
            this.cuentaYClienteToolStripMenuItem.Click += new System.EventHandler(this.cuentaYClienteToolStripMenuItem_Click);
            // 
            // registrosDeshabilitadosToolStripMenuItem
            // 
            this.registrosDeshabilitadosToolStripMenuItem.Name = "registrosDeshabilitadosToolStripMenuItem";
            this.registrosDeshabilitadosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registrosDeshabilitadosToolStripMenuItem.Text = "Registros Deshabilitados";
            this.registrosDeshabilitadosToolStripMenuItem.Click += new System.EventHandler(this.registrosDeshabilitadosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.estadisticosToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeCuentaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tipoDeCuentaToolStripMenuItem
            // 
            this.tipoDeCuentaToolStripMenuItem.Name = "tipoDeCuentaToolStripMenuItem";
            this.tipoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipoDeCuentaToolStripMenuItem.Text = "Tipo de Cuenta";
            this.tipoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.tipoDeCuentaToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // estadisticosToolStripMenuItem
            // 
            this.estadisticosToolStripMenuItem.Name = "estadisticosToolStripMenuItem";
            this.estadisticosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadisticosToolStripMenuItem.Text = "Estadísticos";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Enabled = false;
            this.btn_confirmar.Location = new System.Drawing.Point(226, 315);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(99, 49);
            this.btn_confirmar.TabIndex = 2;
            this.btn_confirmar.Text = "Confirmar";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            this.btn_confirmar.Visible = false;
            this.btn_confirmar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(331, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 49);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Visible = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Enabled = false;
            this.btn_editar.Location = new System.Drawing.Point(121, 315);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(99, 49);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Visible = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 372);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dGV_out);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GridView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GridView";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_out)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_out;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cuentaYClienteToolStripMenuItem;
        private System.Windows.Forms.Button btn_confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.ToolStripMenuItem inhabilitarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosDeshabilitadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticosToolStripMenuItem;
    }
}