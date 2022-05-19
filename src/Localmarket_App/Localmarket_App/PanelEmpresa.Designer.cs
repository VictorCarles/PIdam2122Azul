
namespace Localmarket_App
{
    partial class PanelEmpresa
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
            this.lblNomComercio = new System.Windows.Forms.Label();
            this.lblValoracion = new System.Windows.Forms.Label();
            this.lblDescComercio = new System.Windows.Forms.Label();
            this.picValoracion = new System.Windows.Forms.PictureBox();
            this.picComercio1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComercio1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomComercio
            // 
            this.lblNomComercio.AutoSize = true;
            this.lblNomComercio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNomComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomComercio.Location = new System.Drawing.Point(144, 0);
            this.lblNomComercio.Name = "lblNomComercio";
            this.lblNomComercio.Size = new System.Drawing.Size(297, 38);
            this.lblNomComercio.TabIndex = 2;
            this.lblNomComercio.Text = "Nombre Comercio";
            this.lblNomComercio.Click += new System.EventHandler(this.lblNomComercio_Click);
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.Location = new System.Drawing.Point(480, 14);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(93, 20);
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
            // picValoracion
            // 
            this.picValoracion.Image = global::Localmarket_App.Properties.Resources._5estr;
            this.picValoracion.Location = new System.Drawing.Point(576, 11);
            this.picValoracion.Name = "picValoracion";
            this.picValoracion.Size = new System.Drawing.Size(125, 24);
            this.picValoracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picValoracion.TabIndex = 5;
            this.picValoracion.TabStop = false;
            // 
            // picComercio1
            // 
            this.picComercio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picComercio1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picComercio1.Location = new System.Drawing.Point(0, 0);
            this.picComercio1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picComercio1.Name = "picComercio1";
            this.picComercio1.Size = new System.Drawing.Size(138, 138);
            this.picComercio1.TabIndex = 1;
            this.picComercio1.TabStop = false;
            // 
            // PanelEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picValoracion);
            this.Controls.Add(this.lblDescComercio);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblNomComercio);
            this.Controls.Add(this.picComercio1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PanelEmpresa";
            this.Size = new System.Drawing.Size(716, 138);
            ((System.ComponentModel.ISupportInitialize)(this.picValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComercio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picComercio1;
        private System.Windows.Forms.Label lblNomComercio;
        private System.Windows.Forms.Label lblValoracion;
        private System.Windows.Forms.Label lblDescComercio;
        private System.Windows.Forms.PictureBox picValoracion;
    }
}
