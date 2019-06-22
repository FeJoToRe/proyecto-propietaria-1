namespace CuentasPorCobrar
{
	partial class Vista_cliente
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
			this.DgvClientes = new System.Windows.Forms.DataGridView();
			this.buttonBorrar = new System.Windows.Forms.Button();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.panelClientes = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonCrear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// DgvClientes
			// 
			this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvClientes.Location = new System.Drawing.Point(7, 49);
			this.DgvClientes.Name = "DgvClientes";
			this.DgvClientes.Size = new System.Drawing.Size(788, 158);
			this.DgvClientes.TabIndex = 0;
			// 
			// buttonBorrar
			// 
			this.buttonBorrar.Location = new System.Drawing.Point(226, 245);
			this.buttonBorrar.Name = "buttonBorrar";
			this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
			this.buttonBorrar.TabIndex = 1;
			this.buttonBorrar.Text = "Borrar";
			this.buttonBorrar.UseVisualStyleBackColor = true;
			this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
			// 
			// buttonEditar
			// 
			this.buttonEditar.Location = new System.Drawing.Point(540, 245);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(75, 23);
			this.buttonEditar.TabIndex = 2;
			this.buttonEditar.Text = "Editar";
			this.buttonEditar.UseVisualStyleBackColor = true;
			this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
			// 
			// panelClientes
			// 
			this.panelClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelClientes.Location = new System.Drawing.Point(2, 44);
			this.panelClientes.Name = "panelClientes";
			this.panelClientes.Size = new System.Drawing.Size(798, 172);
			this.panelClientes.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Clientes";
			// 
			// buttonCrear
			// 
			this.buttonCrear.Location = new System.Drawing.Point(380, 245);
			this.buttonCrear.Name = "buttonCrear";
			this.buttonCrear.Size = new System.Drawing.Size(75, 23);
			this.buttonCrear.TabIndex = 5;
			this.buttonCrear.Text = "Crear";
			this.buttonCrear.UseVisualStyleBackColor = true;
			this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
			// 
			// Vista_cliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 280);
			this.Controls.Add(this.buttonCrear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.buttonBorrar);
			this.Controls.Add(this.DgvClientes);
			this.Controls.Add(this.panelClientes);
			this.Name = "Vista_cliente";
			this.Text = "Vista de clientes";
			this.Load += new System.EventHandler(this.Vista_cliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DgvClientes;
		private System.Windows.Forms.Button buttonBorrar;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Panel panelClientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonCrear;
	}
}