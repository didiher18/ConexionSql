﻿
namespace Empadronamiento
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptb_salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_salir)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hello Christmas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(112, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empadronamiento";
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.Thistle;
            this.btn_registro.Font = new System.Drawing.Font("Christmas Tree", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.Location = new System.Drawing.Point(184, 150);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(100, 42);
            this.btn_registro.TabIndex = 1;
            this.btn_registro.Text = "Registrarse";
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.BackColor = System.Drawing.Color.Thistle;
            this.btn_consulta.Font = new System.Drawing.Font("Christmas Tree", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(184, 225);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(100, 42);
            this.btn_consulta.TabIndex = 2;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = false;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ptb_salir
            // 
            this.ptb_salir.Image = ((System.Drawing.Image)(resources.GetObject("ptb_salir.Image")));
            this.ptb_salir.Location = new System.Drawing.Point(451, -1);
            this.ptb_salir.Name = "ptb_salir";
            this.ptb_salir.Size = new System.Drawing.Size(30, 30);
            this.ptb_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_salir.TabIndex = 4;
            this.ptb_salir.TabStop = false;
            this.ptb_salir.Click += new System.EventHandler(this.ptb_salir_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(481, 301);
            this.ControlBox = false;
            this.Controls.Add(this.ptb_salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_salir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptb_salir;
    }
}

