
namespace WdFiguritas
{
    partial class Triangulo
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
            this.btnCalcularTrg = new System.Windows.Forms.Button();
            this.btnDibujarTrg = new System.Windows.Forms.Button();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblCalcular = new System.Windows.Forms.Label();
            this.txtBaseTrg = new System.Windows.Forms.TextBox();
            this.txtAreaTrg = new System.Windows.Forms.TextBox();
            this.txtAlturaTrg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularTrg
            // 
            this.btnCalcularTrg.Location = new System.Drawing.Point(149, 217);
            this.btnCalcularTrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularTrg.Name = "btnCalcularTrg";
            this.btnCalcularTrg.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularTrg.TabIndex = 0;
            this.btnCalcularTrg.Text = "Calcular";
            this.btnCalcularTrg.UseVisualStyleBackColor = true;
            this.btnCalcularTrg.Click += new System.EventHandler(this.btnCalcularTrg_Click);
            // 
            // btnDibujarTrg
            // 
            this.btnDibujarTrg.Location = new System.Drawing.Point(333, 228);
            this.btnDibujarTrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarTrg.Name = "btnDibujarTrg";
            this.btnDibujarTrg.Size = new System.Drawing.Size(100, 28);
            this.btnDibujarTrg.TabIndex = 1;
            this.btnDibujarTrg.Text = "Dibujar";
            this.btnDibujarTrg.UseVisualStyleBackColor = true;
            this.btnDibujarTrg.Click += new System.EventHandler(this.btnDibujarTrg_Click);
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(157, 71);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 2;
            this.lblBase.Text = "Base";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(333, 71);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 3;
            this.lblAltura.Text = "Altura";
            // 
            // lblCalcular
            // 
            this.lblCalcular.AutoSize = true;
            this.lblCalcular.Location = new System.Drawing.Point(189, 322);
            this.lblCalcular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalcular.Name = "lblCalcular";
            this.lblCalcular.Size = new System.Drawing.Size(59, 17);
            this.lblCalcular.TabIndex = 4;
            this.lblCalcular.Text = "Calcular";
            // 
            // txtBaseTrg
            // 
            this.txtBaseTrg.Location = new System.Drawing.Point(160, 134);
            this.txtBaseTrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBaseTrg.Name = "txtBaseTrg";
            this.txtBaseTrg.Size = new System.Drawing.Size(132, 22);
            this.txtBaseTrg.TabIndex = 5;
            // 
            // txtAreaTrg
            // 
            this.txtAreaTrg.Location = new System.Drawing.Point(345, 322);
            this.txtAreaTrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaTrg.Name = "txtAreaTrg";
            this.txtAreaTrg.Size = new System.Drawing.Size(132, 22);
            this.txtAreaTrg.TabIndex = 7;
            // 
            // txtAlturaTrg
            // 
            this.txtAlturaTrg.Location = new System.Drawing.Point(345, 134);
            this.txtAlturaTrg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlturaTrg.Name = "txtAlturaTrg";
            this.txtAlturaTrg.Size = new System.Drawing.Size(132, 22);
            this.txtAlturaTrg.TabIndex = 8;
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAlturaTrg);
            this.Controls.Add(this.txtAreaTrg);
            this.Controls.Add(this.txtBaseTrg);
            this.Controls.Add(this.lblCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.btnDibujarTrg);
            this.Controls.Add(this.btnCalcularTrg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularTrg;
        private System.Windows.Forms.Button btnDibujarTrg;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblCalcular;
        private System.Windows.Forms.TextBox txtBaseTrg;
        private System.Windows.Forms.TextBox txtAreaTrg;
        private System.Windows.Forms.TextBox txtAlturaTrg;
    }
}