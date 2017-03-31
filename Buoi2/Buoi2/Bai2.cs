using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2
{
    public partial class Bai2 : Form
    {
        const int USD = 17861;
        const int EUR = 27043;
        int n;

        public Bai2()
        {
            InitializeComponent();
        }

        private void btnVU_Click(object sender, EventArgs e)
        {
            txtResult.Text = MainClass.calculateMoney("VU", float.Parse(txtInput.Text), USD).ToString("0.##");
        }

        private void btnVE_Click(object sender, EventArgs e)
        {
            txtResult.Text = MainClass.calculateMoney("VE", float.Parse(txtInput.Text), EUR).ToString("0.##");
        }

        private void btnUV_Click(object sender, EventArgs e)
        {
            txtResult.Text = MainClass.calculateMoney("UV", float.Parse(txtInput.Text), USD).ToString("0.##");
        }

        private void btnEV_Click(object sender, EventArgs e)
        {
            txtResult.Text = MainClass.calculateMoney("EV", float.Parse(txtInput.Text), EUR).ToString("0.##");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out n) || string.IsNullOrEmpty(txtInput.Text))
            {
                errorProvider1.SetError(txtInput, "This is not a number!!!");
                btnVU.Enabled = false;
                btnUV.Enabled = false;
                btnVE.Enabled = false;
                btnEV.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                btnVU.Enabled = true;
                btnUV.Enabled = true;
                btnVE.Enabled = true;
                btnEV.Enabled = true;
            }
        }
    }
}
