using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3
{
    public partial class Bai1 : Form
    {
        float n;

        public Bai1()
        {
            InitializeComponent();
        }

        private void ClearResult()
        {
            rd_btn_Cong.Checked = false;
            rd_btn_Tru.Checked = false;
            rd_btn_Nhan.Checked = false;
            rd_btn_Chia.Checked = false;
            txt_input_result.Clear();
        }

        private void txt_input_1_TextChanged(object sender, EventArgs e)
        {
            ClearResult();

            if (!MainClass.IsNotNumNullOrEmpty(txt_input_1.Text))
            {
                errorProvider1.SetError(txt_input_1, "Đây không là số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_input_2_TextChanged(object sender, EventArgs e)
        {
            if (!MainClass.IsNotNumNullOrEmpty(txt_input_1.Text))
            {
                errorProvider1.SetError(txt_input_1, "Đây không là số!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void rd_btn_Cong_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_Cong.Checked)
            {
                txt_input_result.Text = MainClass.Calculate(float.Parse(txt_input_1.Text), float.Parse(txt_input_2.Text), "Cong").ToString();               
            }
        }

        private void rd_btn_Tru_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_Tru.Checked)
            {
                txt_input_result.Text = MainClass.Calculate(float.Parse(txt_input_1.Text), float.Parse(txt_input_2.Text), "Tru").ToString();
            }
        }

        private void rd_btn_Nhan_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_Nhan.Checked)
            {
                txt_input_result.Text = MainClass.Calculate(float.Parse(txt_input_1.Text), float.Parse(txt_input_2.Text), "Nhan").ToString();
            }
        }

        private void rd_btn_Chia_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_btn_Chia.Checked)
            {
                txt_input_result.Text = MainClass.Calculate(float.Parse(txt_input_1.Text), float.Parse(txt_input_2.Text), "Chia").ToString();
            }
        }
    }
}
