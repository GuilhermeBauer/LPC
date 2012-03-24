namespace Diasvividos
{
    partial class Form1
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
            this.lblidade = new System.Windows.Forms.Label();
            this.txtidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblhoras = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblidade
            // 
            this.lblidade.AutoSize = true;
            this.lblidade.Location = new System.Drawing.Point(25, 55);
            this.lblidade.Name = "lblidade";
            this.lblidade.Size = new System.Drawing.Size(58, 13);
            this.lblidade.TabIndex = 0;
            this.lblidade.Text = "Sua idade:";
            // 
            // txtidade
            // 
            this.txtidade.Location = new System.Drawing.Point(89, 48);
            this.txtidade.Name = "txtidade";
            this.txtidade.Size = new System.Drawing.Size(91, 20);
            this.txtidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dias ja vivido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Horas ja vividas:";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(104, 113);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(0, 13);
            this.lbldia.TabIndex = 4;
            // 
            // lblhoras
            // 
            this.lblhoras.AutoSize = true;
            this.lblhoras.Location = new System.Drawing.Point(119, 150);
            this.lblhoras.Name = "lblhoras";
            this.lblhoras.Size = new System.Drawing.Size(0, 13);
            this.lblhoras.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(172, 179);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblhoras);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtidade);
            this.Controls.Add(this.lblidade);
            this.Name = "Form1";
            this.Text = "Dias que voce ja viveu:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidade;
        private System.Windows.Forms.TextBox txtidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblhoras;
        private System.Windows.Forms.Button btnCalcular;
    }
}

