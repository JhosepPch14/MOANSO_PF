namespace MOANSO_PF
{
    partial class Core
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
            this.btnFormOrdPedido = new System.Windows.Forms.Button();
            this.btnCompVenta = new System.Windows.Forms.Button();
            this.btnReqInsumos = new System.Windows.Forms.Button();
            this.btnCompraReq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFormOrdPedido
            // 
            this.btnFormOrdPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormOrdPedido.Location = new System.Drawing.Point(128, 193);
            this.btnFormOrdPedido.Name = "btnFormOrdPedido";
            this.btnFormOrdPedido.Size = new System.Drawing.Size(131, 54);
            this.btnFormOrdPedido.TabIndex = 0;
            this.btnFormOrdPedido.Text = "Ordenar Pedido";
            this.btnFormOrdPedido.UseVisualStyleBackColor = true;
            this.btnFormOrdPedido.Click += new System.EventHandler(this.btnFormOrdPedido_Click);
            // 
            // btnCompVenta
            // 
            this.btnCompVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompVenta.Location = new System.Drawing.Point(517, 193);
            this.btnCompVenta.Name = "btnCompVenta";
            this.btnCompVenta.Size = new System.Drawing.Size(147, 54);
            this.btnCompVenta.TabIndex = 1;
            this.btnCompVenta.Text = "Comprobante de Venta";
            this.btnCompVenta.UseVisualStyleBackColor = true;
            this.btnCompVenta.Click += new System.EventHandler(this.btnCompVenta_Click);
            // 
            // btnReqInsumos
            // 
            this.btnReqInsumos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqInsumos.Location = new System.Drawing.Point(128, 294);
            this.btnReqInsumos.Name = "btnReqInsumos";
            this.btnReqInsumos.Size = new System.Drawing.Size(131, 60);
            this.btnReqInsumos.TabIndex = 2;
            this.btnReqInsumos.Text = "Requerimiento de Insumos";
            this.btnReqInsumos.UseVisualStyleBackColor = true;
            this.btnReqInsumos.Click += new System.EventHandler(this.btnReqInsumos_Click);
            // 
            // btnCompraReq
            // 
            this.btnCompraReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompraReq.Location = new System.Drawing.Point(517, 294);
            this.btnCompraReq.Name = "btnCompraReq";
            this.btnCompraReq.Size = new System.Drawing.Size(147, 60);
            this.btnCompraReq.TabIndex = 3;
            this.btnCompraReq.Text = "Compra de Insumos";
            this.btnCompraReq.UseVisualStyleBackColor = true;
            this.btnCompraReq.Click += new System.EventHandler(this.btnCompraReq_Click);
            // 
            // Core
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.btnCompraReq);
            this.Controls.Add(this.btnReqInsumos);
            this.Controls.Add(this.btnCompVenta);
            this.Controls.Add(this.btnFormOrdPedido);
            this.Name = "Core";
            this.Text = "Core";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormOrdPedido;
        private System.Windows.Forms.Button btnCompVenta;
        private System.Windows.Forms.Button btnReqInsumos;
        private System.Windows.Forms.Button btnCompraReq;
    }
}