
namespace Week7Day3.WinsForm
{
    partial class EquationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valueA = new System.Windows.Forms.TextBox();
            this.X2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valueB = new System.Windows.Forms.TextBox();
            this.valueC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRisolvi = new System.Windows.Forms.Button();
            this.risultato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // valueA
            // 
            this.valueA.Location = new System.Drawing.Point(41, 37);
            this.valueA.Name = "valueA";
            this.valueA.Size = new System.Drawing.Size(36, 27);
            this.valueA.TabIndex = 0;
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(78, 44);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(48, 20);
            this.X2.TabIndex = 1;
            this.X2.Text = "x^2 +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "x +";
            // 
            // valueB
            // 
            this.valueB.Location = new System.Drawing.Point(122, 37);
            this.valueB.Name = "valueB";
            this.valueB.Size = new System.Drawing.Size(36, 27);
            this.valueB.TabIndex = 2;
            // 
            // valueC
            // 
            this.valueC.Location = new System.Drawing.Point(186, 37);
            this.valueC.Name = "valueC";
            this.valueC.Size = new System.Drawing.Size(36, 27);
            this.valueC.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = " = 0";
            // 
            // buttonRisolvi
            // 
            this.buttonRisolvi.Location = new System.Drawing.Point(85, 79);
            this.buttonRisolvi.Name = "buttonRisolvi";
            this.buttonRisolvi.Size = new System.Drawing.Size(116, 40);
            this.buttonRisolvi.TabIndex = 6;
            this.buttonRisolvi.Text = "Risolvi";
            this.buttonRisolvi.UseVisualStyleBackColor = true;
            this.buttonRisolvi.Click += new System.EventHandler(this.buttonRisolvi_Click);
            // 
            // risultato
            // 
            this.risultato.Location = new System.Drawing.Point(28, 133);
            this.risultato.Name = "risultato";
            this.risultato.ReadOnly = true;
            this.risultato.Size = new System.Drawing.Size(251, 27);
            this.risultato.TabIndex = 7;
            // 
            // EquationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 222);
            this.Controls.Add(this.risultato);
            this.Controls.Add(this.buttonRisolvi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueB);
            this.Controls.Add(this.X2);
            this.Controls.Add(this.valueA);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "EquationForm";
            this.Text = "EquationSolver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valueA;
        private System.Windows.Forms.Label X2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueB;
        private System.Windows.Forms.TextBox valueC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRisolvi;
        private System.Windows.Forms.TextBox risultato;
    }
}

