namespace CuentasPorCobrar
{
	partial class Vista_Transacciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransacciones = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxVistaTransc = new System.Windows.Forms.TextBox();
            this.cbxVistaTransc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscarVista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvTransacciones);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 425);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(448, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(367, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(286, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de transacciones";
            // 
            // dgvTransacciones
            // 
            this.dgvTransacciones.AllowUserToAddRows = false;
            this.dgvTransacciones.AllowUserToDeleteRows = false;
            this.dgvTransacciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransacciones.Location = new System.Drawing.Point(-2, 56);
            this.dgvTransacciones.Name = "dgvTransacciones";
            this.dgvTransacciones.ReadOnly = true;
            this.dgvTransacciones.Size = new System.Drawing.Size(528, 368);
            this.dgvTransacciones.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBoxVistaTransc);
            this.panel2.Controls.Add(this.cbxVistaTransc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonBuscarVista);
            this.panel2.Location = new System.Drawing.Point(566, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 152);
            this.panel2.TabIndex = 1;
            // 
            // txtBoxVistaTransc
            // 
            this.txtBoxVistaTransc.Location = new System.Drawing.Point(47, 72);
            this.txtBoxVistaTransc.Name = "txtBoxVistaTransc";
            this.txtBoxVistaTransc.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVistaTransc.TabIndex = 3;
            this.txtBoxVistaTransc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxVistaTransc_KeyPress);
            // 
            // cbxVistaTransc
            // 
            this.cbxVistaTransc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVistaTransc.FormattingEnabled = true;
            this.cbxVistaTransc.Items.AddRange(new object[] {
            "ID transaccion",
            "Tipo movimiento",
            "Nro documento",
            " "});
            this.cbxVistaTransc.Location = new System.Drawing.Point(45, 28);
            this.cbxVistaTransc.Name = "cbxVistaTransc";
            this.cbxVistaTransc.Size = new System.Drawing.Size(102, 21);
            this.cbxVistaTransc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criterio";
            // 
            // buttonBuscarVista
            // 
            this.buttonBuscarVista.Location = new System.Drawing.Point(55, 113);
            this.buttonBuscarVista.Name = "buttonBuscarVista";
            this.buttonBuscarVista.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarVista.TabIndex = 0;
            this.buttonBuscarVista.Text = "Buscar";
            this.buttonBuscarVista.UseVisualStyleBackColor = true;
            this.buttonBuscarVista.Click += new System.EventHandler(this.buttonBuscarVista_Click);
            // 
            // Vista_Transacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 446);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Vista_Transacciones";
            this.Text = "Vista de Transacciones";
            this.Load += new System.EventHandler(this.Vista_Transacciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransacciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvTransacciones;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarVista;
        private System.Windows.Forms.ComboBox cbxVistaTransc;
        private System.Windows.Forms.TextBox txtBoxVistaTransc;
    }
}