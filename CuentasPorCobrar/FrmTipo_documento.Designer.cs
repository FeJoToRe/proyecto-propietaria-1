namespace CuentasPorCobrar
{
	partial class FrmTipo_documento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipo_documento));
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtDescrip = new System.Windows.Forms.TextBox();
			this.chbxActivo = new System.Windows.Forms.CheckBox();
			this.txtID_doc = new System.Windows.Forms.TextBox();
			this.label_descrip = new System.Windows.Forms.Label();
			this.label_ID_doc = new System.Windows.Forms.Label();
			this.SaveDoc = new System.Windows.Forms.Button();
			this.SalirDoc = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtDescrip);
			this.panel1.Controls.Add(this.chbxActivo);
			this.panel1.Controls.Add(this.txtID_doc);
			this.panel1.Controls.Add(this.label_descrip);
			this.panel1.Controls.Add(this.label_ID_doc);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(344, 190);
			this.panel1.TabIndex = 0;
			// 
			// txtDescrip
			// 
			this.txtDescrip.Location = new System.Drawing.Point(193, 89);
			this.txtDescrip.Multiline = true;
			this.txtDescrip.Name = "txtDescrip";
			this.txtDescrip.Size = new System.Drawing.Size(128, 54);
			this.txtDescrip.TabIndex = 10;
			// 
			// chbxActivo
			// 
			this.chbxActivo.AutoSize = true;
			this.chbxActivo.Location = new System.Drawing.Point(138, 149);
			this.chbxActivo.Name = "chbxActivo";
			this.chbxActivo.Size = new System.Drawing.Size(56, 17);
			this.chbxActivo.TabIndex = 9;
			this.chbxActivo.Text = "Activo";
			this.chbxActivo.UseVisualStyleBackColor = true;
			// 
			// txtID_doc
			// 
			this.txtID_doc.Location = new System.Drawing.Point(212, 33);
			this.txtID_doc.Name = "txtID_doc";
			this.txtID_doc.ReadOnly = true;
			this.txtID_doc.Size = new System.Drawing.Size(100, 20);
			this.txtID_doc.TabIndex = 4;
			// 
			// label_descrip
			// 
			this.label_descrip.AutoSize = true;
			this.label_descrip.Location = new System.Drawing.Point(21, 89);
			this.label_descrip.Name = "label_descrip";
			this.label_descrip.Size = new System.Drawing.Size(63, 13);
			this.label_descrip.TabIndex = 1;
			this.label_descrip.Text = "Descripción";
			// 
			// label_ID_doc
			// 
			this.label_ID_doc.AutoSize = true;
			this.label_ID_doc.Location = new System.Drawing.Point(21, 33);
			this.label_ID_doc.Name = "label_ID_doc";
			this.label_ID_doc.Size = new System.Drawing.Size(74, 13);
			this.label_ID_doc.TabIndex = 0;
			this.label_ID_doc.Text = "ID documento";
			// 
			// SaveDoc
			// 
			this.SaveDoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.SaveDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveDoc.BackgroundImage")));
			this.SaveDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SaveDoc.Location = new System.Drawing.Point(12, 325);
			this.SaveDoc.Name = "SaveDoc";
			this.SaveDoc.Size = new System.Drawing.Size(84, 53);
			this.SaveDoc.TabIndex = 1;
			this.SaveDoc.UseVisualStyleBackColor = false;
			this.SaveDoc.Click += new System.EventHandler(this.SaveDoc_Click);
			// 
			// SalirDoc
			// 
			this.SalirDoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirDoc.BackgroundImage")));
			this.SalirDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SalirDoc.Location = new System.Drawing.Point(284, 325);
			this.SalirDoc.Name = "SalirDoc";
			this.SalirDoc.Size = new System.Drawing.Size(72, 53);
			this.SalirDoc.TabIndex = 13;
			this.SalirDoc.UseVisualStyleBackColor = true;
			this.SalirDoc.Click += new System.EventHandler(this.SalirDoc_Click);
			// 
			// FrmTipo_documento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(382, 390);
			this.Controls.Add(this.SalirDoc);
			this.Controls.Add(this.SaveDoc);
			this.Controls.Add(this.panel1);
			this.Name = "FrmTipo_documento";
			this.Text = "Tipo de Documento";
			this.Load += new System.EventHandler(this.FrmTipo_documento_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtID_doc;
		private System.Windows.Forms.Label label_descrip;
		private System.Windows.Forms.Label label_ID_doc;
		private System.Windows.Forms.Button SaveDoc;
		private System.Windows.Forms.Button SalirDoc;
		private System.Windows.Forms.CheckBox chbxActivo;
		private System.Windows.Forms.TextBox txtDescrip;
	}
}