namespace CuentasPorCobrar
{
	partial class FrmBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBalance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxIDcliente = new System.Windows.Forms.ComboBox();
            this.DTP_balance = new System.Windows.Forms.DateTimePicker();
            this.txtMontoBal = new System.Windows.Forms.TextBox();
            this.labelMonto = new System.Windows.Forms.Label();
            this.labelFechaCorte = new System.Windows.Forms.Label();
            this.label_ID_cliente3 = new System.Windows.Forms.Label();
            this.SaveBalance = new System.Windows.Forms.Button();
            this.DeleteBalance = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxIDcliente);
            this.panel1.Controls.Add(this.DTP_balance);
            this.panel1.Controls.Add(this.txtMontoBal);
            this.panel1.Controls.Add(this.labelMonto);
            this.panel1.Controls.Add(this.labelFechaCorte);
            this.panel1.Controls.Add(this.label_ID_cliente3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 245);
            this.panel1.TabIndex = 0;
            // 
            // cbxIDcliente
            // 
            this.cbxIDcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIDcliente.FormattingEnabled = true;
            this.cbxIDcliente.Location = new System.Drawing.Point(252, 11);
            this.cbxIDcliente.Name = "cbxIDcliente";
            this.cbxIDcliente.Size = new System.Drawing.Size(126, 21);
            this.cbxIDcliente.TabIndex = 9;
            // 
            // DTP_balance
            // 
            this.DTP_balance.Location = new System.Drawing.Point(210, 184);
            this.DTP_balance.Name = "DTP_balance";
            this.DTP_balance.Size = new System.Drawing.Size(200, 20);
            this.DTP_balance.TabIndex = 8;
            // 
            // txtMontoBal
            // 
            this.txtMontoBal.Location = new System.Drawing.Point(252, 97);
            this.txtMontoBal.Name = "txtMontoBal";
            this.txtMontoBal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoBal.TabIndex = 7;
            this.txtMontoBal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoBal_KeyPress);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(15, 104);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(37, 13);
            this.labelMonto.TabIndex = 3;
            this.labelMonto.Text = "Monto";
            // 
            // labelFechaCorte
            // 
            this.labelFechaCorte.AutoSize = true;
            this.labelFechaCorte.Location = new System.Drawing.Point(15, 184);
            this.labelFechaCorte.Name = "labelFechaCorte";
            this.labelFechaCorte.Size = new System.Drawing.Size(79, 13);
            this.labelFechaCorte.TabIndex = 1;
            this.labelFechaCorte.Text = "Fecha de corte";
            // 
            // label_ID_cliente3
            // 
            this.label_ID_cliente3.AutoSize = true;
            this.label_ID_cliente3.Location = new System.Drawing.Point(15, 20);
            this.label_ID_cliente3.Name = "label_ID_cliente3";
            this.label_ID_cliente3.Size = new System.Drawing.Size(39, 13);
            this.label_ID_cliente3.TabIndex = 0;
            this.label_ID_cliente3.Text = "Cliente";
            // 
            // SaveBalance
            // 
            this.SaveBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBalance.BackgroundImage")));
            this.SaveBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveBalance.Location = new System.Drawing.Point(12, 295);
            this.SaveBalance.Name = "SaveBalance";
            this.SaveBalance.Size = new System.Drawing.Size(74, 57);
            this.SaveBalance.TabIndex = 1;
            this.SaveBalance.UseVisualStyleBackColor = true;
            this.SaveBalance.Click += new System.EventHandler(this.SaveBalance_Click);
            // 
            // DeleteBalance
            // 
            this.DeleteBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBalance.BackgroundImage")));
            this.DeleteBalance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteBalance.Location = new System.Drawing.Point(93, 295);
            this.DeleteBalance.Name = "DeleteBalance";
            this.DeleteBalance.Size = new System.Drawing.Size(74, 57);
            this.DeleteBalance.TabIndex = 13;
            this.DeleteBalance.UseVisualStyleBackColor = true;
            this.DeleteBalance.Click += new System.EventHandler(this.DeleteBalance_Click);
            // 
            // FrmBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 364);
            this.Controls.Add(this.DeleteBalance);
            this.Controls.Add(this.SaveBalance);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBalance";
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.FrmBalance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMontoBal;
		private System.Windows.Forms.Label labelMonto;
		private System.Windows.Forms.Label labelFechaCorte;
		private System.Windows.Forms.Label label_ID_cliente3;
		private System.Windows.Forms.Button SaveBalance;
		private System.Windows.Forms.Button DeleteBalance;
		private System.Windows.Forms.DateTimePicker DTP_balance;
		private System.Windows.Forms.ComboBox cbxIDcliente;
	}
}