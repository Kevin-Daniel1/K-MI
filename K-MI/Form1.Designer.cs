
namespace K_MI
{
    partial class kmi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verLibros = new System.Windows.Forms.Button();
            this.buscarLibros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verLibros
            // 
            this.verLibros.Location = new System.Drawing.Point(60, 193);
            this.verLibros.Name = "verLibros";
            this.verLibros.Size = new System.Drawing.Size(146, 52);
            this.verLibros.TabIndex = 0;
            this.verLibros.Text = "Ver libros guardados";
            this.verLibros.UseVisualStyleBackColor = true;
            // 
            // buscarLibros
            // 
            this.buscarLibros.Location = new System.Drawing.Point(289, 193);
            this.buscarLibros.Name = "buscarLibros";
            this.buscarLibros.Size = new System.Drawing.Size(174, 52);
            this.buscarLibros.TabIndex = 1;
            this.buscarLibros.Text = "Buscar libros";
            this.buscarLibros.UseVisualStyleBackColor = true;
            this.buscarLibros.Click += new System.EventHandler(this.buscarLibros_Click);
            // 
            // kmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 339);
            this.Controls.Add(this.buscarLibros);
            this.Controls.Add(this.verLibros);
            this.Name = "kmi";
            this.Text = "K-MI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button verLibros;
        private System.Windows.Forms.Button buscarLibros;
    }
}

