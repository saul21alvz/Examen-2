namespace Examen_2
{
    partial class Retiro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtretiro = new System.Windows.Forms.TextBox();
            this.btnacep = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnacep);
            this.panel1.Controls.Add(this.txtretiro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Retirar";
            // 
            // txtretiro
            // 
            this.txtretiro.Location = new System.Drawing.Point(291, 122);
            this.txtretiro.Name = "txtretiro";
            this.txtretiro.Size = new System.Drawing.Size(100, 22);
            this.txtretiro.TabIndex = 1;
            this.txtretiro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtretiro_KeyPress);
            // 
            // btnacep
            // 
            this.btnacep.Location = new System.Drawing.Point(211, 254);
            this.btnacep.Name = "btnacep";
            this.btnacep.Size = new System.Drawing.Size(75, 23);
            this.btnacep.TabIndex = 2;
            this.btnacep.Text = "Aceptar";
            this.btnacep.UseVisualStyleBackColor = true;
            this.btnacep.Click += new System.EventHandler(this.btnacep_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(478, 254);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Retiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Retiro";
            this.Text = "Retiro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnacep;
        private System.Windows.Forms.TextBox txtretiro;
        private System.Windows.Forms.Label label1;
    }
}