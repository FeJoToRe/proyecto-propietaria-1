namespace CuentasPorCobrar
{
	partial class FrmGestion_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestion_clientes));
            this.txt_ID_cliente = new System.Windows.Forms.TextBox();
            this.label_ID_cliente = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_cedula = new System.Windows.Forms.Label();
            this.label_limite_credito = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbxCliente = new System.Windows.Forms.CheckBox();
            this.SaveCliente = new System.Windows.Forms.Button();
            this.SalirCliente = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ID_cliente
            // 
            this.txt_ID_cliente.Enabled = false;
            this.txt_ID_cliente.Location = new System.Drawing.Point(158, 19);
            this.txt_ID_cliente.Name = "txt_ID_cliente";
            this.txt_ID_cliente.ReadOnly = true;
            this.txt_ID_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_ID_cliente.TabIndex = 0;
            // 
            // label_ID_cliente
            // 
            this.label_ID_cliente.AutoSize = true;
            this.label_ID_cliente.Location = new System.Drawing.Point(36, 48);
            this.label_ID_cliente.Name = "label_ID_cliente";
            this.label_ID_cliente.Size = new System.Drawing.Size(21, 13);
            this.label_ID_cliente.TabIndex = 1;
            this.label_ID_cliente.Text = "ID ";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(3, 74);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(95, 13);
            this.label_nombre.TabIndex = 2;
            this.label_nombre.Text = "Nombre del cliente";
            this.label_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_cedula
            // 
            this.label_cedula.AutoSize = true;
            this.label_cedula.Location = new System.Drawing.Point(36, 156);
            this.label_cedula.Name = "label_cedula";
            this.label_cedula.Size = new System.Drawing.Size(40, 13);
            this.label_cedula.TabIndex = 3;
            this.label_cedula.Text = "Cédula";
            // 
            // label_limite_credito
            // 
            this.label_limite_credito.AutoSize = true;
            this.label_limite_credito.Location = new System.Drawing.Point(36, 205);
            this.label_limite_credito.Name = "label_limite_credito";
            this.label_limite_credito.Size = new System.Drawing.Size(84, 13);
            this.label_limite_credito.TabIndex = 4;
            this.label_limite_credito.Text = "Limite de crédito";
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Location = new System.Drawing.Point(36, 258);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(0, 13);
            this.label_estado.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(189, 198);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(100, 20);
            this.txtCredito.TabIndex = 8;
            this.txtCredito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCredito_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.chbxCliente);
            this.panel1.Controls.Add(this.label_nombre);
            this.panel1.Controls.Add(this.txt_ID_cliente);
            this.panel1.Location = new System.Drawing.Point(31, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 251);
            this.panel1.TabIndex = 10;
            // 
            // chbxCliente
            // 
            this.chbxCliente.AutoSize = true;
            this.chbxCliente.Location = new System.Drawing.Point(103, 223);
            this.chbxCliente.Name = "chbxCliente";
            this.chbxCliente.Size = new System.Drawing.Size(56, 17);
            this.chbxCliente.TabIndex = 3;
            this.chbxCliente.Text = "Activo";
            this.chbxCliente.UseVisualStyleBackColor = true;
            // 
            // SaveCliente
            // 
            this.SaveCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveCliente.BackgroundImage")));
            this.SaveCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SaveCliente.Location = new System.Drawing.Point(31, 326);
            this.SaveCliente.Name = "SaveCliente";
            this.SaveCliente.Size = new System.Drawing.Size(89, 59);
            this.SaveCliente.TabIndex = 11;
            this.SaveCliente.UseVisualStyleBackColor = false;
            this.SaveCliente.Click += new System.EventHandler(this.SaveCliente_Click);
            // 
            // SalirCliente
            // 
            this.SalirCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirCliente.BackgroundImage")));
            this.SalirCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalirCliente.Location = new System.Drawing.Point(229, 326);
            this.SalirCliente.Name = "SalirCliente";
            this.SalirCliente.Size = new System.Drawing.Size(75, 59);
            this.SalirCliente.TabIndex = 12;
            this.SalirCliente.UseVisualStyleBackColor = true;
            this.SalirCliente.Click += new System.EventHandler(this.SalirCliente_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(156, 118);
            this.txtCedula.Mask = "999-0000000-9";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 4;
            // 
            // FrmGestion_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 424);
            this.Controls.Add(this.SalirCliente);
            this.Controls.Add(this.SaveCliente);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.label_limite_credito);
            this.Controls.Add(this.label_cedula);
            this.Controls.Add(this.label_ID_cliente);
            this.Controls.Add(this.panel1);
            this.Name = "FrmGestion_clientes";
            this.Text = "Gestion de clientes";
            this.Load += new System.EventHandler(this.FrmGestion_clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txt_ID_cliente;
		private System.Windows.Forms.Label label_ID_cliente;
		private System.Windows.Forms.Label label_nombre;
		private System.Windows.Forms.Label label_cedula;
		private System.Windows.Forms.Label label_limite_credito;
		private System.Windows.Forms.Label label_estado;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCredito;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button SaveCliente;
		private System.Windows.Forms.Button SalirCliente;
		private System.Windows.Forms.CheckBox chbxCliente;
        private System.Windows.Forms.MaskedTextBox txtCedula;
    }
}