namespace Examen_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtnip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnacep = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblagre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblagre);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnacep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // txtnip
            // 
            this.txtnip.Location = new System.Drawing.Point(301, 80);
            this.txtnip.Name = "txtnip";
            this.txtnip.Size = new System.Drawing.Size(100, 22);
            this.txtnip.TabIndex = 0;
            this.txtnip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnip_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIP";
            // 
            // btnacep
            // 
            this.btnacep.Location = new System.Drawing.Point(178, 274);
            this.btnacep.Name = "btnacep";
            this.btnacep.Size = new System.Drawing.Size(75, 23);
            this.btnacep.TabIndex = 2;
            this.btnacep.Text = "Aceptar";
            this.btnacep.UseVisualStyleBackColor = true;
            this.btnacep.Click += new System.EventHandler(this.btnacep_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(447, 273);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblagre
            // 
            this.lblagre.AutoSize = true;
            this.lblagre.Location = new System.Drawing.Point(301, 197);
            this.lblagre.Name = "lblagre";
            this.lblagre.Size = new System.Drawing.Size(56, 16);
            this.lblagre.TabIndex = 4;
            this.lblagre.Text = "Agregar";
            this.lblagre.Click += new System.EventHandler(this.lblagre_Click);
            this.lblagre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblagre_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnacep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnip;
        private System.Windows.Forms.Label lblagre;
    }
}

