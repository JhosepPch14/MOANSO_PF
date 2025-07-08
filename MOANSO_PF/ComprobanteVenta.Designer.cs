namespace MOANSO_PF
{
    partial class ComprobanteVenta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvComprobantes = new System.Windows.Forms.DataGridView();
            this.txtIDComprobante = new System.Windows.Forms.TextBox();
            this.chbCompVenta = new System.Windows.Forms.CheckBox();
            this.btnRegistrarComprobante = new System.Windows.Forms.Button();
            this.btnAnularComprobante = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTComprobante = new System.Windows.Forms.TextBox();
            this.cbIDVenta = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.btnNCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Comprobante:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de Comprobante:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(405, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fecha de Emision:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(31, 543);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(76, 33);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(494, 543);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(669, 543);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 33);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // dgvComprobantes
            // 
            this.dgvComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobantes.Location = new System.Drawing.Point(31, 227);
            this.dgvComprobantes.Name = "dgvComprobantes";
            this.dgvComprobantes.ReadOnly = true;
            this.dgvComprobantes.Size = new System.Drawing.Size(713, 271);
            this.dgvComprobantes.TabIndex = 12;
            this.dgvComprobantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobantes_CellContentClick);
            // 
            // txtIDComprobante
            // 
            this.txtIDComprobante.Location = new System.Drawing.Point(128, 35);
            this.txtIDComprobante.Name = "txtIDComprobante";
            this.txtIDComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtIDComprobante.TabIndex = 14;
            // 
            // chbCompVenta
            // 
            this.chbCompVenta.AutoSize = true;
            this.chbCompVenta.Location = new System.Drawing.Point(500, 66);
            this.chbCompVenta.Name = "chbCompVenta";
            this.chbCompVenta.Size = new System.Drawing.Size(140, 17);
            this.chbCompVenta.TabIndex = 19;
            this.chbCompVenta.Text = "Estado de Comprobante";
            this.chbCompVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarComprobante
            // 
            this.btnRegistrarComprobante.Location = new System.Drawing.Point(750, 452);
            this.btnRegistrarComprobante.Name = "btnRegistrarComprobante";
            this.btnRegistrarComprobante.Size = new System.Drawing.Size(86, 46);
            this.btnRegistrarComprobante.TabIndex = 22;
            this.btnRegistrarComprobante.Text = "Registrar";
            this.btnRegistrarComprobante.UseVisualStyleBackColor = true;
            this.btnRegistrarComprobante.Click += new System.EventHandler(this.btnRegistrarComprobante_Click);
            // 
            // btnAnularComprobante
            // 
            this.btnAnularComprobante.Location = new System.Drawing.Point(750, 227);
            this.btnAnularComprobante.Name = "btnAnularComprobante";
            this.btnAnularComprobante.Size = new System.Drawing.Size(86, 41);
            this.btnAnularComprobante.TabIndex = 23;
            this.btnAnularComprobante.Text = "Anular";
            this.btnAnularComprobante.UseVisualStyleBackColor = true;
            this.btnAnularComprobante.Click += new System.EventHandler(this.btnAnularComprobante_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(346, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Comprobante de Venta";
            // 
            // txtTComprobante
            // 
            this.txtTComprobante.Location = new System.Drawing.Point(368, 35);
            this.txtTComprobante.Name = "txtTComprobante";
            this.txtTComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtTComprobante.TabIndex = 28;
            // 
            // cbIDVenta
            // 
            this.cbIDVenta.FormattingEnabled = true;
            this.cbIDVenta.Location = new System.Drawing.Point(94, 64);
            this.cbIDVenta.Name = "cbIDVenta";
            this.cbIDVenta.Size = new System.Drawing.Size(121, 21);
            this.cbIDVenta.TabIndex = 29;
            this.cbIDVenta.SelectedIndexChanged += new System.EventHandler(this.cbIDVenta_SelectedIndexChanged);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(319, 65);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "DNI Cliente:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Location = new System.Drawing.Point(505, 70);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEmision.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbCompVenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbIDVenta);
            this.groupBox1.Controls.Add(this.txtIDComprobante);
            this.groupBox1.Controls.Add(this.txtTComprobante);
            this.groupBox1.Location = new System.Drawing.Point(31, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 106);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Comprobante:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(750, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Monto Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(750, 411);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 35;
            // 
            // btnNCliente
            // 
            this.btnNCliente.Location = new System.Drawing.Point(750, 290);
            this.btnNCliente.Name = "btnNCliente";
            this.btnNCliente.Size = new System.Drawing.Size(86, 42);
            this.btnNCliente.TabIndex = 36;
            this.btnNCliente.Text = "Nuevo Cliente";
            this.btnNCliente.UseVisualStyleBackColor = true;
            this.btnNCliente.Click += new System.EventHandler(this.btnNCliente_Click);
            // 
            // ComprobanteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 590);
            this.Controls.Add(this.btnNCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAnularComprobante);
            this.Controls.Add(this.btnRegistrarComprobante);
            this.Controls.Add(this.dgvComprobantes);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label9);
            this.Name = "ComprobanteVenta";
            this.Text = "ComprobanteVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvComprobantes;
        private System.Windows.Forms.TextBox txtIDComprobante;
        private System.Windows.Forms.CheckBox chbCompVenta;
        private System.Windows.Forms.Button btnRegistrarComprobante;
        private System.Windows.Forms.Button btnAnularComprobante;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTComprobante;
        private System.Windows.Forms.ComboBox cbIDVenta;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Button btnNCliente;
    }
}