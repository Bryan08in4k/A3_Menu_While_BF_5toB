
namespace A3_Menu_While_BF_5toB
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOP1 = new System.Windows.Forms.Button();
            this.btnOP2 = new System.Windows.Forms.Button();
            this.btnOP3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una opción";
            // 
            // btnOP1
            // 
            this.btnOP1.Location = new System.Drawing.Point(30, 137);
            this.btnOP1.Name = "btnOP1";
            this.btnOP1.Size = new System.Drawing.Size(181, 58);
            this.btnOP1.TabIndex = 1;
            this.btnOP1.Text = "Pares e impares";
            this.btnOP1.UseVisualStyleBackColor = true;
            this.btnOP1.Click += new System.EventHandler(this.btnOP1_Click);
            // 
            // btnOP2
            // 
            this.btnOP2.Location = new System.Drawing.Point(30, 62);
            this.btnOP2.Name = "btnOP2";
            this.btnOP2.Size = new System.Drawing.Size(181, 60);
            this.btnOP2.TabIndex = 2;
            this.btnOP2.Text = "repetir texto";
            this.btnOP2.UseVisualStyleBackColor = true;
            this.btnOP2.Click += new System.EventHandler(this.btnOP2_Click);
            // 
            // btnOP3
            // 
            this.btnOP3.Location = new System.Drawing.Point(30, 215);
            this.btnOP3.Name = "btnOP3";
            this.btnOP3.Size = new System.Drawing.Size(181, 53);
            this.btnOP3.TabIndex = 3;
            this.btnOP3.Text = "Sumatoria";
            this.btnOP3.UseVisualStyleBackColor = true;
            this.btnOP3.Click += new System.EventHandler(this.btnOP3_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 328);
            this.Controls.Add(this.btnOP3);
            this.Controls.Add(this.btnOP2);
            this.Controls.Add(this.btnOP1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOP1;
        private System.Windows.Forms.Button btnOP2;
        private System.Windows.Forms.Button btnOP3;
    }
}

