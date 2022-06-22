
namespace K_MI
{
    partial class Busqueda
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
            this.barraBusqueda = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barraBusqueda
            // 
            this.barraBusqueda.Location = new System.Drawing.Point(94, 173);
            this.barraBusqueda.Name = "barraBusqueda";
            this.barraBusqueda.Size = new System.Drawing.Size(587, 23);
            this.barraBusqueda.TabIndex = 0;
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(336, 233);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(108, 44);
            this.buscar.TabIndex = 1;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.barraBusqueda);
            this.Name = "Busqueda";
            this.Text = "Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barraBusqueda;
        private System.Windows.Forms.Button buscar;
    }
}