namespace diccionario
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
            this.txtcons = new System.Windows.Forms.TextBox();
            this.btntrad = new System.Windows.Forms.Button();
            this.txtpal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcons
            // 
            this.txtcons.Location = new System.Drawing.Point(32, 57);
            this.txtcons.Name = "txtcons";
            this.txtcons.Size = new System.Drawing.Size(186, 20);
            this.txtcons.TabIndex = 0;
            // 
            // btntrad
            // 
            this.btntrad.Location = new System.Drawing.Point(289, 54);
            this.btntrad.Name = "btntrad";
            this.btntrad.Size = new System.Drawing.Size(75, 23);
            this.btntrad.TabIndex = 1;
            this.btntrad.Text = "Traducir";
            this.btntrad.UseVisualStyleBackColor = true;
            this.btntrad.Click += new System.EventHandler(this.btntrad_Click);
            // 
            // txtpal
            // 
            this.txtpal.Location = new System.Drawing.Point(32, 99);
            this.txtpal.Name = "txtpal";
            this.txtpal.ReadOnly = true;
            this.txtpal.Size = new System.Drawing.Size(693, 20);
            this.txtpal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "las palabras validas son: fish, planet, computer, cake";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpal);
            this.Controls.Add(this.btntrad);
            this.Controls.Add(this.txtcons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcons;
        private System.Windows.Forms.Button btntrad;
        private System.Windows.Forms.TextBox txtpal;
        private System.Windows.Forms.Label label1;
    }
}

