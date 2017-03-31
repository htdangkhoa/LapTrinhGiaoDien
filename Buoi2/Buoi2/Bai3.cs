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
    public partial class Bai3 : Form
    {
        int n;

        public Bai3()
        {
            InitializeComponent();
        }

        private void txtInputA_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInputA.Text, out n) || string.IsNullOrEmpty(txtInputA.Text) || int.Parse(txtInputA.Text) == 0)
            {
                errorProvider1.SetError(txtInputA, "This is not a number!!!");
                btnTinh.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if ((int.TryParse(txtInputA.Text, out n) && !string.IsNullOrEmpty(txtInputA.Text)) && int.TryParse(txtInputB.Text, out n) && !string.IsNullOrEmpty(txtInputB.Text))
            {
                btnTinh.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void txtInputB_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtInputB.Text, out n) || string.IsNullOrEmpty(txtInputB.Text))
            {
                errorProvider2.SetError(txtInputB, "This is not a number!!!");
                btnTinh.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
            }

            if ((int.TryParse(txtInputA.Text, out n) && !string.IsNullOrEmpty(txtInputA.Text)) && int.TryParse(txtInputB.Text, out n) && !string.IsNullOrEmpty(txtInputB.Text))
            {
                btnTinh.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            txtResult.Text = ((-int.Parse(txtInputB.Text)) / int.Parse(txtInputA.Text)).ToString();
            btnTinh.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnTinh.Enabled = true;
            txtInputA.Clear();
            txtInputB.Clear();
            txtResult.Clear();

            txtInputA.Focus();

            errorProvider1.Clear();
            errorProvider2.Clear();
        }
    }
}
