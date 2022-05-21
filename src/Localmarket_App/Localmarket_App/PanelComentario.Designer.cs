
namespace Localmarket_App
{
    partial class PanelComentario
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
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnUtil = new System.Windows.Forms.Button();
            this.picValoracion = new System.Windows.Forms.PictureBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(82, 32);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(106, 13);
            this.lblComentario.TabIndex = 1;
            this.lblComentario.Text = "Comentariocomntario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(82, 7);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(71, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnUtil
            // 
            this.btnUtil.BackColor = System.Drawing.Color.Lime;
            this.btnUtil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtil.Location = new System.Drawing.Point(406, 32);
            this.btnUtil.Margin = new System.Windows.Forms.Padding(2);
            this.btnUtil.Name = "btnUtil";
            this.btnUtil.Size = new System.Drawing.Size(74, 28);
            this.btnUtil.TabIndex = 4;
            this.btnUtil.Text = "👍Útil";
            this.btnUtil.UseVisualStyleBackColor = false;
            // 
            // picValoracion
            // 
            this.picValoracion.Image = global::Localmarket_App.Properties.Resources._2estr;
            this.picValoracion.Location = new System.Drawing.Point(406, 7);
            this.picValoracion.Margin = new System.Windows.Forms.Padding(2);
            this.picValoracion.Name = "picValoracion";
            this.picValoracion.Size = new System.Drawing.Size(74, 16);
            this.picValoracion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picValoracion.TabIndex = 3;
            this.picValoracion.TabStop = false;
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(8, 5);
            this.picFoto.Margin = new System.Windows.Forms.Padding(2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(62, 60);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // PanelComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnUtil);
            this.Controls.Add(this.picValoracion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.picFoto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PanelComentario";
            this.Size = new System.Drawing.Size(495, 69);
            this.Load += new System.EventHandler(this.PanelComentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picValoracion;
        private System.Windows.Forms.Button btnUtil;
    }
}
