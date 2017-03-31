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
    public partial class Bai4 : Form
    {
        int n, first, last;
        String _first, _last;

        public Bai4()
        {
            InitializeComponent();
        }

        private void txt_input_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_input.Text, out n) || String.IsNullOrEmpty(txt_input.Text))
            {
                btn_calc.Enabled = false;
                errorProvider1.SetError(txt_input, "This is not a number!!!");
            } else
            {
                btn_calc.Enabled = true;
                errorProvider1.Clear();
            }
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            first = int.Parse(txt_input.Text) % 10;
            last = int.Parse(txt_input.Text) % 12;

            txt_result.Text = MainClass.calculateYear(first, last);
        }
    }
}
