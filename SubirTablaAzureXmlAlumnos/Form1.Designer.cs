namespace SubirTablaAzureXmlAlumnos
{
    partial class Form1
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
            this.btnsubirtabla = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubirtabla
            // 
            this.btnsubirtabla.Location = new System.Drawing.Point(244, 181);
            this.btnsubirtabla.Name = "btnsubirtabla";
            this.btnsubirtabla.Size = new System.Drawing.Size(186, 89);
            this.btnsubirtabla.TabIndex = 0;
            this.btnsubirtabla.Text = "Subir Tabla Azure";
            this.btnsubirtabla.UseVisualStyleBackColor = true;
            this.btnsubirtabla.Click += new System.EventHandler(this.btnsubirtabla_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(241, 324);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(64, 18);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "Mensaje";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 496);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnsubirtabla);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsubirtabla;
        private System.Windows.Forms.Label lblmensaje;
    }
}

