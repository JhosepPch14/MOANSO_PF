namespace MOANSO_PF
{
    partial class MantenedorIngredientes
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
            this.gbDatosIngredientes = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbTPlatillo = new System.Windows.Forms.ComboBox();
            this.lblPlatillo = new System.Windows.Forms.Label();
            this.chbEstadoIngrediente = new System.Windows.Forms.CheckBox();
            this.cbPlatilloPedido = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.gbDatosIngredientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatosIngredientes
            // 
            this.gbDatosIngredientes.Controls.Add(this.lblNombre);
            this.gbDatosIngredientes.Controls.Add(this.txtCantidad);
            this.gbDatosIngredientes.Controls.Add(this.lblCantidad);
            this.gbDatosIngredientes.Controls.Add(this.cbTPlatillo);
            this.gbDatosIngredientes.Controls.Add(this.lblPlatillo);
            this.gbDatosIngredientes.Controls.Add(this.chbEstadoIngrediente);
            this.gbDatosIngredientes.Controls.Add(this.cbPlatilloPedido);
            this.gbDatosIngredientes.Location = new System.Drawing.Point(44, 30);
            this.gbDatosIngredientes.Name = "gbDatosIngredientes";
            this.gbDatosIngredientes.Size = new System.Drawing.Size(262, 268);
            this.gbDatosIngredientes.TabIndex = 40;
            this.gbDatosIngredientes.TabStop = false;
            this.gbDatosIngredientes.Text = "Datos de Ingredientes";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(34, 42);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Tipo Platillo:";
            // 
            // cbTPlatillo
            // 
            this.cbTPlatillo.FormattingEnabled = true;
            this.cbTPlatillo.Location = new System.Drawing.Point(104, 34);
            this.cbTPlatillo.Name = "cbTPlatillo";
            this.cbTPlatillo.Size = new System.Drawing.Size(121, 21);
            this.cbTPlatillo.TabIndex = 38;
            // 
            // lblPlatillo
            // 
            this.lblPlatillo.AutoSize = true;
            this.lblPlatillo.Location = new System.Drawing.Point(34, 87);
            this.lblPlatillo.Name = "lblPlatillo";
            this.lblPlatillo.Size = new System.Drawing.Size(40, 13);
            this.lblPlatillo.TabIndex = 2;
            this.lblPlatillo.Text = "Platillo:";
            // 
            // chbEstadoIngrediente
            // 
            this.chbEstadoIngrediente.AutoSize = true;
            this.chbEstadoIngrediente.Location = new System.Drawing.Point(104, 240);
            this.chbEstadoIngrediente.Name = "chbEstadoIngrediente";
            this.chbEstadoIngrediente.Size = new System.Drawing.Size(59, 17);
            this.chbEstadoIngrediente.TabIndex = 10;
            this.chbEstadoIngrediente.Text = "Estado";
            this.chbEstadoIngrediente.UseVisualStyleBackColor = true;
            // 
            // cbPlatilloPedido
            // 
            this.cbPlatilloPedido.FormattingEnabled = true;
            this.cbPlatilloPedido.Location = new System.Drawing.Point(80, 79);
            this.cbPlatilloPedido.Name = "cbPlatilloPedido";
            this.cbPlatilloPedido.Size = new System.Drawing.Size(121, 21);
            this.cbPlatilloPedido.TabIndex = 29;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(88, 124);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 40;
            // 
            // MantenedorIngredientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbDatosIngredientes);
            this.Name = "MantenedorIngredientes";
            this.Text = "MantenedorIngredientes";
            this.gbDatosIngredientes.ResumeLayout(false);
            this.gbDatosIngredientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosIngredientes;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbTPlatillo;
        private System.Windows.Forms.Label lblPlatillo;
        private System.Windows.Forms.CheckBox chbEstadoIngrediente;
        private System.Windows.Forms.ComboBox cbPlatilloPedido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}