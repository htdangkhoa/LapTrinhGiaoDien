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
    public partial class Bai6 : Form
    {
        int n;

        public Bai6()
        {
            InitializeComponent();
        }

        private void txt_input_A_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_input_A.Text, out n) || String.IsNullOrEmpty(txt_input_A.Text)) {
                btnUSCLN.Enabled = false;
                btnBSCNN.Enabled = false;
            }

            if ((int.TryParse(txt_input_A.Text, out n) && !String.IsNullOrEmpty(txt_input_A.Text)) && (int.TryParse(txt_input_B.Text, out n) && !String.IsNullOrEmpty(txt_input_B.Text)))
            {
                btnUSCLN.Enabled = true;
                btnBSCNN.Enabled = true;
            }
        }

        private void txt_input_B_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_input_B.Text, out n) || String.IsNullOrEmpty(txt_input_B.Text))
            {
                btnUSCLN.Enabled = false;
                btnBSCNN.Enabled = false;
            }

            if ((int.TryParse(txt_input_A.Text, out n) && !String.IsNullOrEmpty(txt_input_A.Text)) && (int.TryParse(txt_input_B.Text, out n) && !String.IsNullOrEmpty(txt_input_B.Text)))
            {
                btnUSCLN.Enabled = true;
                btnBSCNN.Enabled = true;
            }
        }

        private void btnUSCLN_Click(object sender, EventArgs e)
        {
            txt_result.Text = MainClass.USCLN(int.Parse(txt_input_A.Text), int.Parse(txt_input_B.Text)).ToString();
        }

        private void btnBSCNN_Click(object sender, EventArgs e)
        {
            txt_result.Text = MainClass.BSCNN(int.Parse(txt_input_A.Text), int.Parse(txt_input_B.Text)).ToString();
        }
    }
}
