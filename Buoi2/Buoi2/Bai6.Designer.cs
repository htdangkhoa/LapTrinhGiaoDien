namespace Buoi2
{
    partial class Bai6
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
            this.txt_input_A = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUSCLN = new System.Windows.Forms.Button();
            this.btnBSCNN = new System.Windows.Forms.Button();
            this.txt_input_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_input_A
            // 
            this.txt_input_A.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_input_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_A.Location = new System.Drawing.Point(126, 115);
            this.txt_input_A.Name = "txt_input_A";
            this.txt_input_A.Size = new System.Drawing.Size(199, 98);
            this.txt_input_A.TabIndex = 1;
            this.txt_input_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_input_A.TextChanged += new System.EventHandler(this.txt_input_A_TextChanged);
            // 
            // txt_result
            // 
            this.txt_result.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_result.Enabled = false;
            this.txt_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(126, 323);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(404, 98);
            this.txt_result.TabIndex = 2;
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "TÍNH USCLN VÀ BSCLN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUSCLN
            // 
            this.btnUSCLN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUSCLN.Enabled = false;
            this.btnUSCLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUSCLN.Location = new System.Drawing.Point(126, 219);
            this.btnUSCLN.Name = "btnUSCLN";
            this.btnUSCLN.Size = new System.Drawing.Size(404, 46);
            this.btnUSCLN.TabIndex = 6;
            this.btnUSCLN.Text = "USCLN";
            this.btnUSCLN.UseVisualStyleBackColor = true;
            this.btnUSCLN.Click += new System.EventHandler(this.btnUSCLN_Click);
            // 
            // btnBSCNN
            // 
            this.btnBSCNN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBSCNN.Enabled = false;
            this.btnBSCNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBSCNN.Location = new System.Drawing.Point(126, 271);
            this.btnBSCNN.Name = "btnBSCNN";
            this.btnBSCNN.Size = new System.Drawing.Size(404, 46);
            this.btnBSCNN.TabIndex = 7;
            this.btnBSCNN.Text = "BSCNN";
            this.btnBSCNN.UseVisualStyleBackColor = true;
            this.btnBSCNN.Click += new System.EventHandler(this.btnBSCNN_Click);
            // 
            // txt_input_B
            // 
            this.txt_input_B.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_input_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_B.Location = new System.Drawing.Point(331, 115);
            this.txt_input_B.Name = "txt_input_B";
            this.txt_input_B.Size = new System.Drawing.Size(199, 98);
            this.txt_input_B.TabIndex = 8;
            this.txt_input_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_input_B.TextChanged += new System.EventHandler(this.txt_input_B_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số nguyên A";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số nguyên B";
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_input_B);
            this.Controls.Add(this.btnBSCNN);
            this.Controls.Add(this.btnUSCLN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_input_A);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 480);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_input_A;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUSCLN;
        private System.Windows.Forms.Button btnBSCNN;
        private System.Windows.Forms.TextBox txt_input_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}