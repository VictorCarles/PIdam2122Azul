
namespace Localmarket_App
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picComercio1 = new System.Windows.Forms.PictureBox();
            this.lblNomComercio = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.lblDescComercio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picComercio1)).BeginInit();
            this.SuspendLayout();
            // 
            // picComercio1
            // 
            this.picComercio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picComercio1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picComercio1.Location = new System.Drawing.Point(0, 0);
            this.picComercio1.Name = "picComercio1";
            this.picComercio1.Size = new System.Drawing.Size(138, 145);
            this.picComercio1.TabIndex = 1;
            this.picComercio1.TabStop = false;
            // 
            // lblNomComercio
            // 
            this.lblNomComercio.AutoSize = true;
            this.lblNomComercio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomComercio.Font = new System.Drawing.Font("Leelawadee", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomComercio.Location = new System.Drawing.Point(144, 0);
            this.lblNomComercio.Name = "lblNomComercio";
            this.lblNomComercio.Size = new System.Drawing.Size(312, 41);
            this.lblNomComercio.TabIndex = 2;
            this.lblNomComercio.Text = "Nombre Comercio";
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Font = new System.Drawing.Font("Leelawadee", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.Location = new System.Drawing.Point(462, 16);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(94, 20);
            this.lblValoracion.TabIndex = 3;
            this.lblValoracion.Text = "Valoración:";
            // 
            // lblDescComercio
            // 
            this.lblDescComercio.AutoSize = true;
            this.lblDescComercio.Location = new System.Drawing.Point(148, 64);
            this.lblDescComercio.Name = "lblDescComercio";
            this.lblDescComercio.Size = new System.Drawing.Size(476, 34);
            this.lblDescComercio.TabIndex = 4;
            this.lblDescComercio.Text = "Descripcion Descripcion Descripcion Descripcion Descripcion Descripcion \r\nDescrip" +
    "cion Descripcion Descripcion Descripcion Descripcion Descripcion \r\n";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescComercio);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblNomComercio);
            this.Controls.Add(this.picComercio1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(716, 145);
            ((System.ComponentModel.ISupportInitialize)(this.picComercio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picComercio1;
        private System.Windows.Forms.Label lblNomComercio;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.Label lblDescComercio;
    }
}
