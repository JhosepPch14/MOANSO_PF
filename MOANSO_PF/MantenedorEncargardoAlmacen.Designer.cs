namespace MOANSO_PF
{
    partial class MantenedorEncargardoAlmacen
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDatos = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.chbEstadoEnAlmacen = new System.Windows.Forms.CheckBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroEnAlmacen = new System.Windows.Forms.TextBox();
            this.txtNombreEnAlmacen = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtDNIEnAlmacen = new System.Windows.Forms.TextBox();
            this.txtIDEnAlmacen = new System.Windows.Forms.TextBox();
            this.dgvEnAlmacen = new System.Windows.Forms.DataGridView();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(357, 346);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 33;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDatos
            // 
            this.btnDatos.Location = new System.Drawing.Point(505, 346);
            this.btnDatos.Name = "btnDatos";
            this.btnDatos.Size = new System.Drawing.Size(75, 23);
            this.btnDatos.TabIndex = 32;
            this.btnDatos.Text = "Editar Datos";
            this.btnDatos.UseVisualStyleBackColor = true;
            this.btnDatos.Click += new System.EventHandler(this.btnDatos_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblIdCliente);
            this.gbDatos.Controls.Add(this.chbEstadoEnAlmacen);
            this.gbDatos.Controls.Add(this.lblDNICliente);
            this.gbDatos.Controls.Add(this.dtpFechaRegistro);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Controls.Add(this.lblNumero);
            this.gbDatos.Controls.Add(this.txtNumeroEnAlmacen);
            this.gbDatos.Controls.Add(this.txtNombreEnAlmacen);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Controls.Add(this.txtDNIEnAlmacen);
            this.gbDatos.Controls.Add(this.txtIDEnAlmacen);
            this.gbDatos.Location = new System.Drawing.Point(31, 26);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(308, 255);
            this.gbDatos.TabIndex = 31;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Encargado Almacen:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(47, 35);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(21, 13);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "ID:";
            // 
            // chbEstadoEnAlmacen
            // 
            this.chbEstadoEnAlmacen.AutoSize = true;
            this.chbEstadoEnAlmacen.Location = new System.Drawing.Point(124, 232);
            this.chbEstadoEnAlmacen.Name = "chbEstadoEnAlmacen";
            this.chbEstadoEnAlmacen.Size = new System.Drawing.Size(59, 17);
            this.chbEstadoEnAlmacen.TabIndex = 20;
            this.chbEstadoEnAlmacen.Text = "Estado";
            this.chbEstadoEnAlmacen.UseVisualStyleBackColor = true;
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Location = new System.Drawing.Point(48, 75);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(29, 13);
            this.lblDNICliente.TabIndex = 2;
            this.lblDNICliente.Text = "DNI:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(93, 190);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 117);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(47, 156);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Numero:";
            // 
            // txtNumeroEnAlmacen
            // 
            this.txtNumeroEnAlmacen.Location = new System.Drawing.Point(100, 149);
            this.txtNumeroEnAlmacen.Name = "txtNumeroEnAlmacen";
            this.txtNumeroEnAlmacen.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroEnAlmacen.TabIndex = 17;
            // 
            // txtNombreEnAlmacen
            // 
            this.txtNombreEnAlmacen.Location = new System.Drawing.Point(100, 110);
            this.txtNombreEnAlmacen.Name = "txtNombreEnAlmacen";
            this.txtNombreEnAlmacen.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEnAlmacen.TabIndex = 16;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(47, 197);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtDNIEnAlmacen
            // 
            this.txtDNIEnAlmacen.Location = new System.Drawing.Point(83, 68);
            this.txtDNIEnAlmacen.Name = "txtDNIEnAlmacen";
            this.txtDNIEnAlmacen.Size = new System.Drawing.Size(100, 20);
            this.txtDNIEnAlmacen.TabIndex = 15;
            // 
            // txtIDEnAlmacen
            // 
            this.txtIDEnAlmacen.Location = new System.Drawing.Point(74, 28);
            this.txtIDEnAlmacen.Name = "txtIDEnAlmacen";
            this.txtIDEnAlmacen.Size = new System.Drawing.Size(100, 20);
            this.txtIDEnAlmacen.TabIndex = 14;
            // 
            // dgvEnAlmacen
            // 
            this.dgvEnAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnAlmacen.Location = new System.Drawing.Point(357, 26);
            this.dgvEnAlmacen.Name = "dgvEnAlmacen";
            this.dgvEnAlmacen.ReadOnly = true;
            this.dgvEnAlmacen.Size = new System.Drawing.Size(750, 296);
            this.dgvEnAlmacen.TabIndex = 30;
            this.dgvEnAlmacen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnAlmacen_CellContentClick);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(155, 346);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnInhabilitar.TabIndex = 29;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(33, 299);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(264, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(1020, 426);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(798, 426);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 426);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 24;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // MantenedorEncargardoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 461);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDatos);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvEnAlmacen);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegresar);
            this.Name = "MantenedorEncargardoAlmacen";
            this.Text = "MantenedorEncargardoAlmacen";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDatos;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.CheckBox chbEstadoEnAlmacen;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroEnAlmacen;
        private System.Windows.Forms.TextBox txtNombreEnAlmacen;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtDNIEnAlmacen;
        private System.Windows.Forms.TextBox txtIDEnAlmacen;
        private System.Windows.Forms.DataGridView dgvEnAlmacen;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegresar;
    }
}