
namespace WdFiguritas
{
    partial class Rectangulo
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
            this.txtAlturaRtg = new System.Windows.Forms.TextBox();
            this.btnCalcularRtg = new System.Windows.Forms.Button();
            this.btnDibujarRtg = new System.Windows.Forms.Button();
            this.txtBaseRtg = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtAreaRtg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAlturaRtg
            // 
            this.txtAlturaRtg.Location = new System.Drawing.Point(324, 124);
            this.txtAlturaRtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlturaRtg.Name = "txtAlturaRtg";
            this.txtAlturaRtg.Size = new System.Drawing.Size(132, 22);
            this.txtAlturaRtg.TabIndex = 0;
            // 
            // btnCalcularRtg
            // 
            this.btnCalcularRtg.Location = new System.Drawing.Point(144, 196);
            this.btnCalcularRtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularRtg.Name = "btnCalcularRtg";
            this.btnCalcularRtg.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularRtg.TabIndex = 1;
            this.btnCalcularRtg.Text = "Calcular";
            this.btnCalcularRtg.UseVisualStyleBackColor = true;
            this.btnCalcularRtg.Click += new System.EventHandler(this.btnCalcularRtg_Click);
            // 
            // btnDibujarRtg
            // 
            this.btnDibujarRtg.Location = new System.Drawing.Point(345, 201);
            this.btnDibujarRtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarRtg.Name = "btnDibujarRtg";
            this.btnDibujarRtg.Size = new System.Drawing.Size(100, 28);
            this.btnDibujarRtg.TabIndex = 2;
            this.btnDibujarRtg.Text = "Dibujar";
            this.btnDibujarRtg.UseVisualStyleBackColor = true;
            this.btnDibujarRtg.Click += new System.EventHandler(this.btnDibujarRtg_Click);
            // 
            // txtBaseRtg
            // 
            this.txtBaseRtg.Location = new System.Drawing.Point(140, 123);
            this.txtBaseRtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBaseRtg.Name = "txtBaseRtg";
            this.txtBaseRtg.Size = new System.Drawing.Size(132, 22);
            this.txtBaseRtg.TabIndex = 3;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(168, 87);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(40, 17);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base";
            this.lblBase.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(357, 82);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(45, 17);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(189, 302);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 6;
            this.lblArea.Text = "Area";
            // 
            // txtAreaRtg
            // 
            this.txtAreaRtg.Location = new System.Drawing.Point(305, 299);
            this.txtAreaRtg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaRtg.Name = "txtAreaRtg";
            this.txtAreaRtg.Size = new System.Drawing.Size(132, 22);
            this.txtAreaRtg.TabIndex = 7;
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAreaRtg);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtBaseRtg);
            this.Controls.Add(this.btnDibujarRtg);
            this.Controls.Add(this.btnCalcularRtg);
            this.Controls.Add(this.txtAlturaRtg);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlturaRtg;
        private System.Windows.Forms.Button btnCalcularRtg;
        private System.Windows.Forms.Button btnDibujarRtg;
        private System.Windows.Forms.TextBox txtBaseRtg;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAreaRtg;
    }
}