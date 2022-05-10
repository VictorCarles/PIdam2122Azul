
using System;

namespace Localmarket_App
{
    partial class FrmLogin
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
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.pnlDatosUsuario = new System.Windows.Forms.Panel();
            this.btnIniciarSesion2 = new System.Windows.Forms.Button();
            this.lblOlvidarContraseña = new System.Windows.Forms.LinkLabel();
            this.chkRecuerdame = new System.Windows.Forms.CheckBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblDatosUsuario = new System.Windows.Forms.Label();
            this.picNombre = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlDatosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.Orange;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(526, 446);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(276, 47);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRegistrarse.BackColor = System.Drawing.Color.Orange;
            this.btnRegistrarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistrarse.Font = new System.Drawing.Font("Leelawadee", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(556, 533);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(225, 47);
            this.btnRegistrarse.TabIndex = 2;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // pnlDatosUsuario
            // 
            this.pnlDatosUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDatosUsuario.BackColor = System.Drawing.Color.White;
            this.pnlDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosUsuario.Controls.Add(this.btnIniciarSesion2);
            this.pnlDatosUsuario.Controls.Add(this.lblOlvidarContraseña);
            this.pnlDatosUsuario.Controls.Add(this.chkRecuerdame);
            this.pnlDatosUsuario.Controls.Add(this.txtContraseña);
            this.pnlDatosUsuario.Controls.Add(this.txtUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblContraseña);
            this.pnlDatosUsuario.Controls.Add(this.lblUsuario);
            this.pnlDatosUsuario.Controls.Add(this.lblDatosUsuario);
            this.pnlDatosUsuario.Location = new System.Drawing.Point(420, 269);
            this.pnlDatosUsuario.Name = "pnlDatosUsuario";
            this.pnlDatosUsuario.Size = new System.Drawing.Size(468, 247);
            this.pnlDatosUsuario.TabIndex = 4;
            // 
            // btnIniciarSesion2
            // 
            this.btnIniciarSesion2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnIniciarSesion2.BackColor = System.Drawing.Color.Orange;
            this.btnIniciarSesion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion2.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion2.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion2.Location = new System.Drawing.Point(276, 202);
            this.btnIniciarSesion2.Name = "btnIniciarSesion2";
            this.btnIniciarSesion2.Size = new System.Drawing.Size(181, 33);
            this.btnIniciarSesion2.TabIndex = 5;
            this.btnIniciarSesion2.Text = "Iniciar Sesión";
            this.btnIniciarSesion2.UseVisualStyleBackColor = false;
            // 
            // lblOlvidarContraseña
            // 
            this.lblOlvidarContraseña.AutoSize = true;
            this.lblOlvidarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblOlvidarContraseña.Location = new System.Drawing.Point(240, 141);
            this.lblOlvidarContraseña.Name = "lblOlvidarContraseña";
            this.lblOlvidarContraseña.Size = new System.Drawing.Size(141, 17);
            this.lblOlvidarContraseña.TabIndex = 6;
            this.lblOlvidarContraseña.TabStop = true;
            this.lblOlvidarContraseña.Text = "Olvidé mi contraseña";
            // 
            // chkRecuerdame
            // 
            this.chkRecuerdame.AutoSize = true;
            this.chkRecuerdame.BackColor = System.Drawing.Color.Transparent;
            this.chkRecuerdame.Font = new System.Drawing.Font("Leelawadee", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecuerdame.Location = new System.Drawing.Point(158, 168);
            this.chkRecuerdame.Name = "chkRecuerdame";
            this.chkRecuerdame.Size = new System.Drawing.Size(117, 22);
            this.chkRecuerdame.TabIndex = 5;
            this.chkRecuerdame.Text = "Recuérdame";
            this.chkRecuerdame.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(158, 116);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(223, 22);
            this.txtContraseña.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(158, 72);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 22);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(42, 115);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(116, 23);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Leelawadee", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(73, 72);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(85, 23);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblDatosUsuario
            // 
            this.lblDatosUsuario.AutoSize = true;
            this.lblDatosUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblDatosUsuario.Font = new System.Drawing.Font("Leelawadee", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosUsuario.Location = new System.Drawing.Point(125, 17);
            this.lblDatosUsuario.Name = "lblDatosUsuario";
            this.lblDatosUsuario.Size = new System.Drawing.Size(256, 36);
            this.lblDatosUsuario.TabIndex = 0;
            this.lblDatosUsuario.Text = "Datos de Usuario";
            // 
            // picNombre
            // 
            this.picNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picNombre.BackColor = System.Drawing.Color.Transparent;
            this.picNombre.Image = global::Localmarket_App.Properties.Resources.Nombre_App;
            this.picNombre.InitialImage = null;
            this.picNombre.Location = new System.Drawing.Point(324, 305);
            this.picNombre.Name = "picNombre";
            this.picNombre.Size = new System.Drawing.Size(669, 101);
            this.picNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNombre.TabIndex = 3;
            this.picNombre.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::Localmarket_App.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(546, 61);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(214, 202);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Localmarket_App.Properties.Resources.panaderia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.pnlDatosUsuario);
            this.Controls.Add(this.picNombre);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.picLogo);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.pnlDatosUsuario.ResumeLayout(false);
            this.pnlDatosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.PictureBox picNombre;
        private System.Windows.Forms.Panel pnlDatosUsuario;
        private System.Windows.Forms.Button btnIniciarSesion2;
        private System.Windows.Forms.LinkLabel lblOlvidarContraseña;
        private System.Windows.Forms.CheckBox chkRecuerdame;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblDatosUsuario;
    }
}