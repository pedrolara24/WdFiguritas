
namespace WdFiguritas
{
    partial class Cuadrado
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
            this.btnDibujarCdr = new System.Windows.Forms.Button();
            this.btnCalcularCdr = new System.Windows.Forms.Button();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtAreaCdr = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDibujarCdr
            // 
            this.btnDibujarCdr.Location = new System.Drawing.Point(225, 188);
            this.btnDibujarCdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarCdr.Name = "btnDibujarCdr";
            this.btnDibujarCdr.Size = new System.Drawing.Size(100, 28);
            this.btnDibujarCdr.TabIndex = 0;
            this.btnDibujarCdr.Text = "Dibujar";
            this.btnDibujarCdr.UseVisualStyleBackColor = true;
            this.btnDibujarCdr.Click += new System.EventHandler(this.btnDibujarCdr_Click);
            // 
            // btnCalcularCdr
            // 
            this.btnCalcularCdr.Location = new System.Drawing.Point(404, 188);
            this.btnCalcularCdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularCdr.Name = "btnCalcularCdr";
            this.btnCalcularCdr.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularCdr.TabIndex = 1;
            this.btnCalcularCdr.Text = "Calcular";
            this.btnCalcularCdr.UseVisualStyleBackColor = true;
            this.btnCalcularCdr.Click += new System.EventHandler(this.btnCalcularCdr_Click);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(351, 92);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(40, 17);
            this.lblLado.TabIndex = 2;
            this.lblLado.Text = "Lado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(301, 137);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(132, 22);
            this.txtLado.TabIndex = 3;
            // 
            // txtAreaCdr
            // 
            this.txtAreaCdr.Location = new System.Drawing.Point(355, 314);
            this.txtAreaCdr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaCdr.Name = "txtAreaCdr";
            this.txtAreaCdr.Size = new System.Drawing.Size(132, 22);
            this.txtAreaCdr.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(259, 318);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "Area";
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtAreaCdr);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.btnCalcularCdr);
            this.Controls.Add(this.btnDibujarCdr);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Cuadrado";
            this.Text = "Cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDibujarCdr;
        private System.Windows.Forms.Button btnCalcularCdr;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtAreaCdr;
        private System.Windows.Forms.Label lblArea;
    }
}