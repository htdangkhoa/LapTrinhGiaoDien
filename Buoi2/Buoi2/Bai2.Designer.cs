namespace Buoi2
{
    partial class Bai2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEV = new System.Windows.Forms.Button();
            this.btnUV = new System.Windows.Forms.Button();
            this.btnVE = new System.Windows.Forms.Button();
            this.btnVU = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi tiền";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEV
            // 
            this.btnEV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEV.Enabled = false;
            this.btnEV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEV.Location = new System.Drawing.Point(437, 106);
            this.btnEV.Name = "btnEV";
            this.btnEV.Size = new System.Drawing.Size(119, 29);
            this.btnEV.TabIndex = 7;
            this.btnEV.Text = "EURtoVND";
            this.btnEV.UseVisualStyleBackColor = true;
            this.btnEV.Click += new System.EventHandler(this.btnEV_Click);
            // 
            // btnUV
            // 
            this.btnUV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUV.Enabled = false;
            this.btnUV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUV.Location = new System.Drawing.Point(312, 106);
            this.btnUV.Name = "btnUV";
            this.btnUV.Size = new System.Drawing.Size(119, 29);
            this.btnUV.TabIndex = 6;
            this.btnUV.Text = "USDtoVND";
            this.btnUV.UseVisualStyleBackColor = true;
            this.btnUV.Click += new System.EventHandler(this.btnUV_Click);
            // 
            // btnVE
            // 
            this.btnVE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVE.Enabled = false;
            this.btnVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVE.Location = new System.Drawing.Point(187, 106);
            this.btnVE.Name = "btnVE";
            this.btnVE.Size = new System.Drawing.Size(119, 29);
            this.btnVE.TabIndex = 5;
            this.btnVE.Text = "VNDtoEUR";
            this.btnVE.UseVisualStyleBackColor = true;
            this.btnVE.Click += new System.EventHandler(this.btnVE_Click);
            // 
            // btnVU
            // 
            this.btnVU.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVU.Enabled = false;
            this.btnVU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVU.Location = new System.Drawing.Point(62, 106);
            this.btnVU.Name = "btnVU";
            this.btnVU.Size = new System.Drawing.Size(119, 29);
            this.btnVU.TabIndex = 4;
            this.btnVU.Text = "VNDtoUSD";
            this.btnVU.UseVisualStyleBackColor = true;
            this.btnVU.Click += new System.EventHandler(this.btnVU_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tiền qui đổi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết qủa:";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(111, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(479, 26);
            this.txtInput.TabIndex = 10;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(111, 156);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(496, 26);
            this.txtResult.TabIndex = 11;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 221);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEV);
            this.Controls.Add(this.btnUV);
            this.Controls.Add(this.btnVE);
            this.Controls.Add(this.btnVU);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(635, 260);
            this.Name = "Bai2";
            this.Text = "Bai 2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEV;
        private System.Windows.Forms.Button btnUV;
        private System.Windows.Forms.Button btnVE;
        private System.Windows.Forms.Button btnVU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

