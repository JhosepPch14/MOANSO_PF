namespace MOANSO_PF
{
    partial class Restaurante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCore = new System.Windows.Forms.Button();
            this.btnMantenedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Restaurante \"El Rincon Del Jugador";
            // 
            // btnCore
            // 
            this.btnCore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCore.Location = new System.Drawing.Point(165, 240);
            this.btnCore.Name = "btnCore";
            this.btnCore.Size = new System.Drawing.Size(128, 66);
            this.btnCore.TabIndex = 2;
            this.btnCore.Text = "CORE\'S";
            this.btnCore.UseVisualStyleBackColor = true;
            this.btnCore.Click += new System.EventHandler(this.btnCore_Click);
            // 
            // btnMantenedor
            // 
            this.btnMantenedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenedor.Location = new System.Drawing.Point(484, 240);
            this.btnMantenedor.Name = "btnMantenedor";
            this.btnMantenedor.Size = new System.Drawing.Size(135, 66);
            this.btnMantenedor.TabIndex = 3;
            this.btnMantenedor.Text = "MANTENEDORES";
            this.btnMantenedor.UseVisualStyleBackColor = true;
            this.btnMantenedor.Click += new System.EventHandler(this.btnMantenedor_Click);
            // 
            // Restaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMantenedor);
            this.Controls.Add(this.btnCore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Restaurante";
            this.Text = "Restaurante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCore;
        private System.Windows.Forms.Button btnMantenedor;
    }
}