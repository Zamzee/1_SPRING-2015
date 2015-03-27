namespace Lab_11_RCA_V1._0
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
            this.txtSide1 = new System.Windows.Forms.TextBox();
            this.txtSide2 = new System.Windows.Forms.TextBox();
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calc_Hypotenuse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSide1
            // 
            this.txtSide1.Location = new System.Drawing.Point(110, 64);
            this.txtSide1.Name = "txtSide1";
            this.txtSide1.Size = new System.Drawing.Size(100, 20);
            this.txtSide1.TabIndex = 0;
            this.txtSide1.TextChanged += new System.EventHandler(this.txtSide1_TextChanged);
            // 
            // txtSide2
            // 
            this.txtSide2.Location = new System.Drawing.Point(110, 108);
            this.txtSide2.Name = "txtSide2";
            this.txtSide2.Size = new System.Drawing.Size(100, 20);
            this.txtSide2.TabIndex = 1;
            this.txtSide2.TextChanged += new System.EventHandler(this.txtSide2_TextChanged);
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(110, 177);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.Size = new System.Drawing.Size(100, 20);
            this.txtHypotenuse.TabIndex = 2;
            this.txtHypotenuse.TextChanged += new System.EventHandler(this.txtHypotenuse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Side 1  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hypotenuse :";
            // 
            // btn_Calc_Hypotenuse
            // 
            this.btn_Calc_Hypotenuse.Location = new System.Drawing.Point(122, 134);
            this.btn_Calc_Hypotenuse.Name = "btn_Calc_Hypotenuse";
            this.btn_Calc_Hypotenuse.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc_Hypotenuse.TabIndex = 6;
            this.btn_Calc_Hypotenuse.Text = "Calculate";
            this.btn_Calc_Hypotenuse.UseVisualStyleBackColor = true;
            this.btn_Calc_Hypotenuse.Click += new System.EventHandler(this.btn_Calc_Hypotenuse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Calc_Hypotenuse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.txtSide2);
            this.Controls.Add(this.txtSide1);
            this.Name = "Form1";
            this.Text = "Hypotenuse Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSide1;
        private System.Windows.Forms.TextBox txtSide2;
        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calc_Hypotenuse;

    }
}

