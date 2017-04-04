namespace Buoi3
{
    partial class Bai1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_input_1 = new System.Windows.Forms.TextBox();
            this.txt_input_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_input_result = new System.Windows.Forms.TextBox();
            this.rd_btn_Cong = new System.Windows.Forms.RadioButton();
            this.rd_btn_Tru = new System.Windows.Forms.RadioButton();
            this.rd_btn_Nhan = new System.Windows.Forms.RadioButton();
            this.rd_btn_Chia = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // txt_input_1
            // 
            this.txt_input_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_1.Location = new System.Drawing.Point(86, 12);
            this.txt_input_1.Name = "txt_input_1";
            this.txt_input_1.Size = new System.Drawing.Size(368, 26);
            this.txt_input_1.TabIndex = 2;
            this.txt_input_1.TextChanged += new System.EventHandler(this.txt_input_1_TextChanged);
            // 
            // txt_input_2
            // 
            this.txt_input_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_2.Location = new System.Drawing.Point(86, 44);
            this.txt_input_2.Name = "txt_input_2";
            this.txt_input_2.Size = new System.Drawing.Size(368, 26);
            this.txt_input_2.TabIndex = 3;
            this.txt_input_2.TextChanged += new System.EventHandler(this.txt_input_2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kết quả:";
            // 
            // txt_input_result
            // 
            this.txt_input_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_input_result.Enabled = false;
            this.txt_input_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_result.Location = new System.Drawing.Point(86, 126);
            this.txt_input_result.Name = "txt_input_result";
            this.txt_input_result.Size = new System.Drawing.Size(368, 26);
            this.txt_input_result.TabIndex = 5;
            // 
            // rd_btn_Cong
            // 
            this.rd_btn_Cong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_btn_Cong.AutoSize = true;
            this.rd_btn_Cong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Cong.Location = new System.Drawing.Point(76, 86);
            this.rd_btn_Cong.Name = "rd_btn_Cong";
            this.rd_btn_Cong.Size = new System.Drawing.Size(65, 24);
            this.rd_btn_Cong.TabIndex = 6;
            this.rd_btn_Cong.TabStop = true;
            this.rd_btn_Cong.Text = "Cộng";
            this.rd_btn_Cong.UseVisualStyleBackColor = true;
            this.rd_btn_Cong.CheckedChanged += new System.EventHandler(this.rd_btn_Cong_CheckedChanged);
            // 
            // rd_btn_Tru
            // 
            this.rd_btn_Tru.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_btn_Tru.AutoSize = true;
            this.rd_btn_Tru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Tru.Location = new System.Drawing.Point(167, 86);
            this.rd_btn_Tru.Name = "rd_btn_Tru";
            this.rd_btn_Tru.Size = new System.Drawing.Size(50, 24);
            this.rd_btn_Tru.TabIndex = 7;
            this.rd_btn_Tru.TabStop = true;
            this.rd_btn_Tru.Text = "Trừ";
            this.rd_btn_Tru.UseVisualStyleBackColor = true;
            this.rd_btn_Tru.CheckedChanged += new System.EventHandler(this.rd_btn_Tru_CheckedChanged);
            // 
            // rd_btn_Nhan
            // 
            this.rd_btn_Nhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_btn_Nhan.AutoSize = true;
            this.rd_btn_Nhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Nhan.Location = new System.Drawing.Point(243, 86);
            this.rd_btn_Nhan.Name = "rd_btn_Nhan";
            this.rd_btn_Nhan.Size = new System.Drawing.Size(65, 24);
            this.rd_btn_Nhan.TabIndex = 8;
            this.rd_btn_Nhan.TabStop = true;
            this.rd_btn_Nhan.Text = "Nhân";
            this.rd_btn_Nhan.UseVisualStyleBackColor = true;
            this.rd_btn_Nhan.CheckedChanged += new System.EventHandler(this.rd_btn_Nhan_CheckedChanged);
            // 
            // rd_btn_Chia
            // 
            this.rd_btn_Chia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rd_btn_Chia.AutoSize = true;
            this.rd_btn_Chia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_Chia.Location = new System.Drawing.Point(334, 86);
            this.rd_btn_Chia.Name = "rd_btn_Chia";
            this.rd_btn_Chia.Size = new System.Drawing.Size(59, 24);
            this.rd_btn_Chia.TabIndex = 9;
            this.rd_btn_Chia.TabStop = true;
            this.rd_btn_Chia.Text = "Chia";
            this.rd_btn_Chia.UseVisualStyleBackColor = true;
            this.rd_btn_Chia.CheckedChanged += new System.EventHandler(this.rd_btn_Chia_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 166);
            this.Controls.Add(this.rd_btn_Chia);
            this.Controls.Add(this.rd_btn_Nhan);
            this.Controls.Add(this.rd_btn_Tru);
            this.Controls.Add(this.rd_btn_Cong);
            this.Controls.Add(this.txt_input_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_input_2);
            this.Controls.Add(this.txt_input_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "PHÉP TÍNH";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_input_1;
        private System.Windows.Forms.TextBox txt_input_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_input_result;
        private System.Windows.Forms.RadioButton rd_btn_Cong;
        private System.Windows.Forms.RadioButton rd_btn_Tru;
        private System.Windows.Forms.RadioButton rd_btn_Nhan;
        private System.Windows.Forms.RadioButton rd_btn_Chia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

