namespace Examen_2
{
    partial class Deposito
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
            this.txtdeposito = new System.Windows.Forms.TextBox();
            this.btnacep = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // txtdeposito
            // 
            this.txtdeposito.Location = new System.Drawing.Point(259, 134);
            this.txtdeposito.Name = "txtdeposito";
            this.txtdeposito.Size = new System.Drawing.Size(100, 22);
            this.txtdeposito.TabIndex = 1;
            this.txtdeposito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeposito_KeyPress);
            // 
            // btnacep
            // 
            this.btnacep.Location = new System.Drawing.Point(189, 226);
            this.btnacep.Name = "btnacep";
            this.btnacep.Size = new System.Drawing.Size(75, 23);
            this.btnacep.TabIndex = 2;
            this.btnacep.Text = "Aceptar";
            this.btnacep.UseVisualStyleBackColor = true;
            this.btnacep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(418, 226);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnacep);
            this.Controls.Add(this.txtdeposito);
            this.Controls.Add(this.label1);
            this.Name = "Deposito";
            this.Text = "Deposito";
            this.Load += new System.EventHandler(this.Deposito_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdeposito;
        private System.Windows.Forms.Button btnacep;
        private System.Windows.Forms.Button btnsalir;
    }
}