
namespace WdFiguritas
{
    partial class Circulo
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
            this.btnCalcularCrl = new System.Windows.Forms.Button();
            this.btnDibujarCrl = new System.Windows.Forms.Button();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtAreaCrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcularCrl
            // 
            this.btnCalcularCrl.Location = new System.Drawing.Point(167, 183);
            this.btnCalcularCrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalcularCrl.Name = "btnCalcularCrl";
            this.btnCalcularCrl.Size = new System.Drawing.Size(100, 28);
            this.btnCalcularCrl.TabIndex = 0;
            this.btnCalcularCrl.Text = "Calcular";
            this.btnCalcularCrl.UseVisualStyleBackColor = true;
            this.btnCalcularCrl.Click += new System.EventHandler(this.btnCalcularCrl_Click);
            // 
            // btnDibujarCrl
            // 
            this.btnDibujarCrl.Location = new System.Drawing.Point(343, 183);
            this.btnDibujarCrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDibujarCrl.Name = "btnDibujarCrl";
            this.btnDibujarCrl.Size = new System.Drawing.Size(100, 28);
            this.btnDibujarCrl.TabIndex = 1;
            this.btnDibujarCrl.Text = "Dibujar";
            this.btnDibujarCrl.UseVisualStyleBackColor = true;
            this.btnDibujarCrl.Click += new System.EventHandler(this.btnDibujarCrl_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(232, 114);
            this.txtRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(132, 22);
            this.txtRadio.TabIndex = 2;
            this.txtRadio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(275, 79);
            this.lblRadio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(45, 17);
            this.lblRadio.TabIndex = 3;
            this.lblRadio.Text = "Radio";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(163, 272);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 17);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            this.lblArea.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAreaCrl
            // 
            this.txtAreaCrl.Location = new System.Drawing.Point(267, 273);
            this.txtAreaCrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAreaCrl.Name = "txtAreaCrl";
            this.txtAreaCrl.Size = new System.Drawing.Size(132, 22);
            this.txtAreaCrl.TabIndex = 5;
            this.txtAreaCrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtAreaCrl);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblRadio);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.btnDibujarCrl);
            this.Controls.Add(this.btnCalcularCrl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Circulo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularCrl;
        private System.Windows.Forms.Button btnDibujarCrl;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtAreaCrl;
    }
}