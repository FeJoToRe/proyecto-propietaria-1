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
            this.buttonBuscarDocs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVistaDocs = new System.Windows.Forms.ComboBox();
            this.textBoxVistaDocs = new System.Windows.Forms.TextBox();
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
            // buttonBuscarDocs
            // 
            this.buttonBuscarDocs.Location = new System.Drawing.Point(296, 12);
            this.buttonBuscarDocs.Name = "buttonBuscarDocs";
            this.buttonBuscarDocs.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarDocs.TabIndex = 5;
            this.buttonBuscarDocs.Text = "Buscar";
            this.buttonBuscarDocs.UseVisualStyleBackColor = true;
            this.buttonBuscarDocs.Click += new System.EventHandler(this.buttonBuscarDocs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Criterio";
            // 
            // cbxVistaDocs
            // 
            this.cbxVistaDocs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVistaDocs.FormattingEnabled = true;
            this.cbxVistaDocs.Items.AddRange(new object[] {
            "ID documento",
            "Descripcion",
            " "});
            this.cbxVistaDocs.Location = new System.Drawing.Point(475, 14);
            this.cbxVistaDocs.Name = "cbxVistaDocs";
            this.cbxVistaDocs.Size = new System.Drawing.Size(121, 21);
            this.cbxVistaDocs.TabIndex = 7;
            this.cbxVistaDocs.SelectedIndexChanged += new System.EventHandler(this.cbxVistaDocs_SelectedIndexChanged);
            // 
            // textBoxVistaDocs
            // 
            this.textBoxVistaDocs.Location = new System.Drawing.Point(640, 14);
            this.textBoxVistaDocs.Name = "textBoxVistaDocs";
            this.textBoxVistaDocs.Size = new System.Drawing.Size(100, 20);
            this.textBoxVistaDocs.TabIndex = 8;
            this.textBoxVistaDocs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVistaDocs_KeyPress);
            // 
            // Vista_documentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.textBoxVistaDocs);
            this.Controls.Add(this.cbxVistaDocs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscarDocs);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.DgvDocumentos);
            this.Controls.Add(this.labelVistaDocs);
            this.Name = "Vista_documentos";
            this.Text = "Vista de documentos";
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
        private System.Windows.Forms.Button buttonBuscarDocs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVistaDocs;
        private System.Windows.Forms.TextBox textBoxVistaDocs;
    }
}