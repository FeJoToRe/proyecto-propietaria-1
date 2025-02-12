﻿namespace CuentasPorCobrar
{
	partial class Vista_Balance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vista_Balance));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBalance = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxVistaBalance = new System.Windows.Forms.TextBox();
            this.cbxVistaBalance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscarBalance = new System.Windows.Forms.Button();
            this.cmdExportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Balance";
            // 
            // dgvBalance
            // 
            this.dgvBalance.AllowUserToAddRows = false;
            this.dgvBalance.AllowUserToDeleteRows = false;
            this.dgvBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBalance.Location = new System.Drawing.Point(-2, 56);
            this.dgvBalance.Name = "dgvBalance";
            this.dgvBalance.ReadOnly = true;
            this.dgvBalance.Size = new System.Drawing.Size(528, 368);
            this.dgvBalance.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvBalance);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 425);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtBoxVistaBalance);
            this.panel2.Controls.Add(this.cbxVistaBalance);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonBuscarBalance);
            this.panel2.Location = new System.Drawing.Point(551, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 152);
            this.panel2.TabIndex = 2;
            // 
            // txtBoxVistaBalance
            // 
            this.txtBoxVistaBalance.Location = new System.Drawing.Point(47, 72);
            this.txtBoxVistaBalance.Name = "txtBoxVistaBalance";
            this.txtBoxVistaBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVistaBalance.TabIndex = 3;
            this.txtBoxVistaBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxVistaBalance_KeyPress);
            // 
            // cbxVistaBalance
            // 
            this.cbxVistaBalance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVistaBalance.FormattingEnabled = true;
            this.cbxVistaBalance.Items.AddRange(new object[] {
            "ID_cliente",
            "ID_balance",
            " "});
            this.cbxVistaBalance.Location = new System.Drawing.Point(45, 28);
            this.cbxVistaBalance.Name = "cbxVistaBalance";
            this.cbxVistaBalance.Size = new System.Drawing.Size(102, 21);
            this.cbxVistaBalance.TabIndex = 2;
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
            // buttonBuscarBalance
            // 
            this.buttonBuscarBalance.Location = new System.Drawing.Point(55, 113);
            this.buttonBuscarBalance.Name = "buttonBuscarBalance";
            this.buttonBuscarBalance.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarBalance.TabIndex = 0;
            this.buttonBuscarBalance.Text = "Buscar";
            this.buttonBuscarBalance.UseVisualStyleBackColor = true;
            this.buttonBuscarBalance.Click += new System.EventHandler(this.buttonBuscarBalance_Click);
            // 
            // cmdExportar
            // 
            this.cmdExportar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdExportar.BackgroundImage")));
            this.cmdExportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExportar.Location = new System.Drawing.Point(607, 197);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(75, 65);
            this.cmdExportar.TabIndex = 8;
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // Vista_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 428);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Vista_Balance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Vista_Balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBalance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvBalance;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxVistaBalance;
        private System.Windows.Forms.ComboBox cbxVistaBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscarBalance;
        private System.Windows.Forms.Button cmdExportar;
    }
}