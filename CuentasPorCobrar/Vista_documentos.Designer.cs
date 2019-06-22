namespace CuentasPorCobrar
{
	partial class Vista_documentos
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
			this.labelVistaDocs = new System.Windows.Forms.Label();
			this.DgvDocumentos = new System.Windows.Forms.DataGridView();
			this.buttonEditar = new System.Windows.Forms.Button();
			this.buttonCrear = new System.Windows.Forms.Button();
			this.buttonEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvDocumentos)).BeginInit();
			this.SuspendLayout();
			// 
			// labelVistaDocs
			// 
			this.labelVistaDocs.AutoSize = true;
			this.labelVistaDocs.Location = new System.Drawing.Point(12, 24);
			this.labelVistaDocs.Name = "labelVistaDocs";
			this.labelVistaDocs.Size = new System.Drawing.Size(102, 13);
			this.labelVistaDocs.TabIndex = 0;
			this.labelVistaDocs.Text = "Lista de Documento";
			// 
			// DgvDocumentos
			// 
			this.DgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvDocumentos.Location = new System.Drawing.Point(15, 53);
			this.DgvDocumentos.Name = "DgvDocumentos";
			this.DgvDocumentos.Size = new System.Drawing.Size(773, 230);
			this.DgvDocumentos.TabIndex = 1;
			// 
			// buttonEditar
			// 
			this.buttonEditar.Location = new System.Drawing.Point(129, 319);
			this.buttonEditar.Name = "buttonEditar";
			this.buttonEditar.Size = new System.Drawing.Size(75, 23);
			this.buttonEditar.TabIndex = 2;
			this.buttonEditar.Text = "Editar";
			this.buttonEditar.UseVisualStyleBackColor = true;
			this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
			// 
			// buttonCrear
			// 
			this.buttonCrear.Location = new System.Drawing.Point(341, 319);
			this.buttonCrear.Name = "buttonCrear";
			this.buttonCrear.Size = new System.Drawing.Size(75, 23);
			this.buttonCrear.TabIndex = 3;
			this.buttonCrear.Text = "Crear";
			this.buttonCrear.UseVisualStyleBackColor = true;
			this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
			// 
			// buttonEliminar
			// 
			this.buttonEliminar.Location = new System.Drawing.Point(553, 319);
			this.buttonEliminar.Name = "buttonEliminar";
			this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
			this.buttonEliminar.TabIndex = 4;
			this.buttonEliminar.Text = "Eliminar";
			this.buttonEliminar.UseVisualStyleBackColor = true;
			this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
			// 
			// Vista_documentos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 378);
			this.Controls.Add(this.buttonEliminar);
			this.Controls.Add(this.buttonCrear);
			this.Controls.Add(this.buttonEditar);
			this.Controls.Add(this.DgvDocumentos);
			this.Controls.Add(this.labelVistaDocs);
			this.Name = "Vista_documentos";
			this.Text = "Vista_documentos";
			this.Load += new System.EventHandler(this.Vista_documentos_Load);
			((System.ComponentModel.ISupportInitialize)(this.DgvDocumentos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelVistaDocs;
		private System.Windows.Forms.DataGridView DgvDocumentos;
		private System.Windows.Forms.Button buttonEditar;
		private System.Windows.Forms.Button buttonCrear;
		private System.Windows.Forms.Button buttonEliminar;
	}
}