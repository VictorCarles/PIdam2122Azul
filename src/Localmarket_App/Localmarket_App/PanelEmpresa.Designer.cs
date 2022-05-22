
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
            this.lblNomComercio.Location = new System.Drawing.Point(108, 0);
            this.lblNomComercio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomComercio.MaximumSize = new System.Drawing.Size(265, 0);
            this.lblNomComercio.Name = "lblNomComercio";
            this.lblNomComercio.Size = new System.Drawing.Size(248, 31);
            this.lblNomComercio.TabIndex = 2;
            this.lblNomComercio.Text = "Nombre Comercio";
            this.lblNomComercio.Click += new System.EventHandler(this.lblNomComercio_Click);
            // 
            // lblValoracion
            // 
            this.lblValoracion.AutoSize = true;
            this.lblValoracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoracion.Location = new System.Drawing.Point(377, 11);
            this.lblValoracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValoracion.Name = "lblValoracion";
            this.lblValoracion.Size = new System.Drawing.Size(79, 17);
            this.lblValoracion.TabIndex = 3;
            this.lblValoracion.Text = "Valoración:";
            // 
            // lblDescComercio
            // 
            this.lblDescComercio.AutoSize = true;
            this.lblDescComercio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescComercio.Location = new System.Drawing.Point(108, 67);
            this.lblDescComercio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescComercio.MaximumSize = new System.Drawing.Size(457, 0);
            this.lblDescComercio.Name = "lblDescComercio";
            this.lblDescComercio.Size = new System.Drawing.Size(457, 32);
            this.lblDescComercio.TabIndex = 4;
            this.lblDescComercio.Text = "Descripcion Descripcion Descripcion Descripcion Descripcion Descripcion \r\nDescrip" +
    "cion Descripcion Descripcion Descripcion Descripcion Descripcion \r\n";
            // 
            // picValoracion
            // 
            this.picValoracion.Image = global::Localmarket_App.Properties.Resources._5estr;
            this.picValoracion.Location = new System.Drawing.Point(449, 9);
            this.picValoracion.Margin = new System.Windows.Forms.Padding(2);
            this.picValoracion.Name = "picValoracion";
            this.picValoracion.Size = new System.Drawing.Size(94, 20);
            this.picValoracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picValoracion.TabIndex = 5;
            this.picValoracion.TabStop = false;
            // 
            // picComercio1
            // 
            this.picComercio1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picComercio1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picComercio1.Location = new System.Drawing.Point(0, 0);
            this.picComercio1.Margin = new System.Windows.Forms.Padding(2);
            this.picComercio1.Name = "picComercio1";
            this.picComercio1.Size = new System.Drawing.Size(104, 110);
            this.picComercio1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComercio1.TabIndex = 1;
            this.picComercio1.TabStop = false;
            // 
            // PanelEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picValoracion);
            this.Controls.Add(this.lblDescComercio);
            this.Controls.Add(this.lblValoracion);
            this.Controls.Add(this.lblNomComercio);
            this.Controls.Add(this.picComercio1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelEmpresa";
            this.Size = new System.Drawing.Size(567, 110);
            this.Load += new System.EventHandler(this.PanelEmpresa_Load);
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
