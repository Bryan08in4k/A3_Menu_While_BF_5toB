
namespace A3_Menu_While_BF_5toB
{
    partial class Par_Impar
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
            this.btnPares = new System.Windows.Forms.Button();
            this.btnimpares = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(25, 34);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(226, 53);
            this.btnPares.TabIndex = 0;
            this.btnPares.Text = "Números Pares";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // btnimpares
            // 
            this.btnimpares.Location = new System.Drawing.Point(25, 108);
            this.btnimpares.Name = "btnimpares";
            this.btnimpares.Size = new System.Drawing.Size(226, 60);
            this.btnimpares.TabIndex = 1;
            this.btnimpares.Text = "Números impares";
            this.btnimpares.UseVisualStyleBackColor = true;
            this.btnimpares.Click += new System.EventHandler(this.btnimpares_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(25, 186);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(226, 279);
            this.listBox1.TabIndex = 2;
            // 
            // Par_Impar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 478);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnimpares);
            this.Controls.Add(this.btnPares);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Par_Impar";
            this.Text = "Par_impar";
            this.Load += new System.EventHandler(this.Repetir_textp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.Button btnimpares;
        private System.Windows.Forms.ListBox listBox1;
    }
}