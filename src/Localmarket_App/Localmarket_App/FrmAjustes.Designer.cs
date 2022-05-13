
namespace Localmarket_App
{
    partial class FrmAjustes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjustes));
            this.pnlNaranja = new System.Windows.Forms.Panel();
            this.lblAjustes = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pboxTienda = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlNaranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNaranja
            // 
            this.pnlNaranja.BackColor = System.Drawing.Color.Orange;
            this.pnlNaranja.Controls.Add(this.pboxTienda);
            this.pnlNaranja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNaranja.Location = new System.Drawing.Point(0, 0);
            this.pnlNaranja.Name = "pnlNaranja";
            this.pnlNaranja.Size = new System.Drawing.Size(1332, 100);
            this.pnlNaranja.TabIndex = 1;
            // 
            // lblAjustes
            // 
            this.lblAjustes.AutoSize = true;
            this.lblAjustes.Font = new System.Drawing.Font("Leelawadee", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustes.Location = new System.Drawing.Point(125, 136);
            this.lblAjustes.Name = "lblAjustes";
            this.lblAjustes.Size = new System.Drawing.Size(139, 40);
            this.lblAjustes.TabIndex = 2;
            this.lblAjustes.Text = "Ajustes:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(1024, 608);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 41);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Guardar Cambios";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(841, 608);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(113, 41);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pboxTienda
            // 
            this.pboxTienda.Image = ((System.Drawing.Image)(resources.GetObject("pboxTienda.Image")));
            this.pboxTienda.InitialImage = null;
            this.pboxTienda.Location = new System.Drawing.Point(31, 12);
            this.pboxTienda.Name = "pboxTienda";
            this.pboxTienda.Size = new System.Drawing.Size(75, 68);
            this.pboxTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxTienda.TabIndex = 0;
            this.pboxTienda.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Español",
            "Inglés"});
            this.comboBox1.Location = new System.Drawing.Point(376, 249);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 32);
            this.comboBox1.TabIndex = 18;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(269, 252);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(101, 29);
            this.lblIdioma.TabIndex = 19;
            this.lblIdioma.Text = "Idioma:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Modo oscuro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(376, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "OFF";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 703);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAjustes);
            this.Controls.Add(this.pnlNaranja);
            this.Font = new System.Drawing.Font("Leelawadee", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmAjustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.pnlNaranja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNaranja;
        private System.Windows.Forms.PictureBox pboxTienda;
        private System.Windows.Forms.Label lblAjustes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}