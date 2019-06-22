using System;

namespace CuentasPorCobrar
{
	partial class FrmTransaccion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransaccion));
			this.panel1 = new System.Windows.Forms.Panel();
			this.DTP_fecha_transc = new System.Windows.Forms.DateTimePicker();
			this.cbxTipoMov = new System.Windows.Forms.ComboBox();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.labelMonto = new System.Windows.Forms.Label();
			this.label_ID_cliente2 = new System.Windows.Forms.Label();
			this.labelFecha = new System.Windows.Forms.Label();
			this.txtNro_doc = new System.Windows.Forms.TextBox();
			this.txtID_transc = new System.Windows.Forms.TextBox();
			this.labelNro_doc = new System.Windows.Forms.Label();
			this.label_ID_doc2 = new System.Windows.Forms.Label();
			this.labelTipoMov = new System.Windows.Forms.Label();
			this.label_ID_transc = new System.Windows.Forms.Label();
			this.SaveTransc = new System.Windows.Forms.Button();
			this.SalirTransc = new System.Windows.Forms.Button();
			this.cbxIDTipo = new System.Windows.Forms.ComboBox();
			this.cbxIDCliente = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cbxIDCliente);
			this.panel1.Controls.Add(this.cbxIDTipo);
			this.panel1.Controls.Add(this.DTP_fecha_transc);
			this.panel1.Controls.Add(this.cbxTipoMov);
			this.panel1.Controls.Add(this.txtMonto);
			this.panel1.Controls.Add(this.labelMonto);
			this.panel1.Controls.Add(this.label_ID_cliente2);
			this.panel1.Controls.Add(this.labelFecha);
			this.panel1.Controls.Add(this.txtNro_doc);
			this.panel1.Controls.Add(this.txtID_transc);
			this.panel1.Controls.Add(this.labelNro_doc);
			this.panel1.Controls.Add(this.label_ID_doc2);
			this.panel1.Controls.Add(this.labelTipoMov);
			this.panel1.Controls.Add(this.label_ID_transc);
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(386, 471);
			this.panel1.TabIndex = 0;
			// 
			// DTP_fecha_transc
			// 
			this.DTP_fecha_transc.Location = new System.Drawing.Point(161, 430);
			this.DTP_fecha_transc.Name = "DTP_fecha_transc";
			this.DTP_fecha_transc.Size = new System.Drawing.Size(198, 20);
			this.DTP_fecha_transc.TabIndex = 16;
			// 
			// cbxTipoMov
			// 
			this.cbxTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTipoMov.FormattingEnabled = true;
			this.cbxTipoMov.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
			this.cbxTipoMov.Location = new System.Drawing.Point(219, 82);
			this.cbxTipoMov.Name = "cbxTipoMov";
			this.cbxTipoMov.Size = new System.Drawing.Size(100, 21);
			this.cbxTipoMov.TabIndex = 15;
			// 
			// txtMonto
			// 
			this.txtMonto.Location = new System.Drawing.Point(219, 375);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(100, 20);
			this.txtMonto.TabIndex = 13;
			// 
			// labelMonto
			// 
			this.labelMonto.AutoSize = true;
			this.labelMonto.Location = new System.Drawing.Point(28, 375);
			this.labelMonto.Name = "labelMonto";
			this.labelMonto.Size = new System.Drawing.Size(37, 13);
			this.labelMonto.TabIndex = 10;
			this.labelMonto.Text = "Monto";
			// 
			// label_ID_cliente2
			// 
			this.label_ID_cliente2.AutoSize = true;
			this.label_ID_cliente2.Location = new System.Drawing.Point(28, 303);
			this.label_ID_cliente2.Name = "label_ID_cliente2";
			this.label_ID_cliente2.Size = new System.Drawing.Size(52, 13);
			this.label_ID_cliente2.TabIndex = 9;
			this.label_ID_cliente2.Text = "ID cliente";
			// 
			// labelFecha
			// 
			this.labelFecha.AutoSize = true;
			this.labelFecha.Location = new System.Drawing.Point(28, 430);
			this.labelFecha.Name = "labelFecha";
			this.labelFecha.Size = new System.Drawing.Size(37, 13);
			this.labelFecha.TabIndex = 8;
			this.labelFecha.Text = "Fecha";
			// 
			// txtNro_doc
			// 
			this.txtNro_doc.Location = new System.Drawing.Point(219, 224);
			this.txtNro_doc.Name = "txtNro_doc";
			this.txtNro_doc.Size = new System.Drawing.Size(100, 20);
			this.txtNro_doc.TabIndex = 7;
			// 
			// txtID_transc
			// 
			this.txtID_transc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtID_transc.Location = new System.Drawing.Point(219, 30);
			this.txtID_transc.Name = "txtID_transc";
			this.txtID_transc.Size = new System.Drawing.Size(100, 20);
			this.txtID_transc.TabIndex = 4;
			this.txtID_transc.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
			// 
			// labelNro_doc
			// 
			this.labelNro_doc.AutoSize = true;
			this.labelNro_doc.Location = new System.Drawing.Point(28, 224);
			this.labelNro_doc.Name = "labelNro_doc";
			this.labelNro_doc.Size = new System.Drawing.Size(83, 13);
			this.labelNro_doc.TabIndex = 3;
			this.labelNro_doc.Text = "Nro. documento";
			// 
			// label_ID_doc2
			// 
			this.label_ID_doc2.AutoSize = true;
			this.label_ID_doc2.Location = new System.Drawing.Point(28, 160);
			this.label_ID_doc2.Name = "label_ID_doc2";
			this.label_ID_doc2.Size = new System.Drawing.Size(94, 13);
			this.label_ID_doc2.TabIndex = 2;
			this.label_ID_doc2.Text = "ID tipo documento";
			// 
			// labelTipoMov
			// 
			this.labelTipoMov.AutoSize = true;
			this.labelTipoMov.Location = new System.Drawing.Point(28, 90);
			this.labelTipoMov.Name = "labelTipoMov";
			this.labelTipoMov.Size = new System.Drawing.Size(69, 13);
			this.labelTipoMov.TabIndex = 1;
			this.labelTipoMov.Text = "Tipo de mov.";
			// 
			// label_ID_transc
			// 
			this.label_ID_transc.AutoSize = true;
			this.label_ID_transc.Location = new System.Drawing.Point(28, 30);
			this.label_ID_transc.Name = "label_ID_transc";
			this.label_ID_transc.Size = new System.Drawing.Size(76, 13);
			this.label_ID_transc.TabIndex = 0;
			this.label_ID_transc.Text = "ID transacción";
			// 
			// SaveTransc
			// 
			this.SaveTransc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveTransc.BackgroundImage")));
			this.SaveTransc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SaveTransc.Location = new System.Drawing.Point(46, 500);
			this.SaveTransc.Name = "SaveTransc";
			this.SaveTransc.Size = new System.Drawing.Size(49, 42);
			this.SaveTransc.TabIndex = 1;
			this.SaveTransc.UseVisualStyleBackColor = true;
			this.SaveTransc.Click += new System.EventHandler(this.SaveTransc_Click);
			// 
			// SalirTransc
			// 
			this.SalirTransc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirTransc.BackgroundImage")));
			this.SalirTransc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SalirTransc.Location = new System.Drawing.Point(234, 500);
			this.SalirTransc.Name = "SalirTransc";
			this.SalirTransc.Size = new System.Drawing.Size(46, 42);
			this.SalirTransc.TabIndex = 13;
			this.SalirTransc.UseVisualStyleBackColor = true;
			this.SalirTransc.Click += new System.EventHandler(this.SalirTransc_Click);
			// 
			// cbxIDTipo
			// 
			this.cbxIDTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxIDTipo.FormattingEnabled = true;
			this.cbxIDTipo.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
			this.cbxIDTipo.Location = new System.Drawing.Point(219, 157);
			this.cbxIDTipo.Name = "cbxIDTipo";
			this.cbxIDTipo.Size = new System.Drawing.Size(100, 21);
			this.cbxIDTipo.TabIndex = 17;
			// 
			// cbxIDCliente
			// 
			this.cbxIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxIDCliente.FormattingEnabled = true;
			this.cbxIDCliente.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
			this.cbxIDCliente.Location = new System.Drawing.Point(219, 300);
			this.cbxIDCliente.Name = "cbxIDCliente";
			this.cbxIDCliente.Size = new System.Drawing.Size(100, 21);
			this.cbxIDCliente.TabIndex = 18;
			// 
			// FrmTransaccion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 554);
			this.Controls.Add(this.SalirTransc);
			this.Controls.Add(this.SaveTransc);
			this.Controls.Add(this.panel1);
			this.Name = "FrmTransaccion";
			this.Text = "Transacción";
			this.Load += new System.EventHandler(this.FrmTransaccion_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtNro_doc;
		private System.Windows.Forms.TextBox txtID_transc;
		private System.Windows.Forms.Label labelNro_doc;
		private System.Windows.Forms.Label label_ID_doc2;
		private System.Windows.Forms.Label labelTipoMov;
		private System.Windows.Forms.Label label_ID_transc;
		private System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label labelMonto;
		private System.Windows.Forms.Label label_ID_cliente2;
		private System.Windows.Forms.Label labelFecha;
		private System.Windows.Forms.Button SaveTransc;
		private System.Windows.Forms.Button SalirTransc;
		private System.Windows.Forms.ComboBox cbxTipoMov;
		private System.Windows.Forms.DateTimePicker DTP_fecha_transc;
		private System.Windows.Forms.ComboBox cbxIDCliente;
		private System.Windows.Forms.ComboBox cbxIDTipo;
	}
}