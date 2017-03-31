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

            txt_result.Text = calcFirst(first) + " " + calcLast(last);
        }

        String calcFirst(int first)
        {
            switch (first)
            {
                case 0:
                    {
                        _first = "Canh";
                        break;
                    }
                case 1:
                    {
                        _first = "Tân";
                        break;
                    }
                case 2:
                    {
                        _first = "Nhâm";
                        break;
                    }
                case 3:
                    {
                        _first = "Quý";
                        break;
                    }
                case 4:
                    {
                        _first = "Giáp";
                        break;
                    }
                case 5:
                    {
                        _first = "Ất";
                        break;
                    }
                case 6:
                    {
                        _first = "Bính";
                        break;
                    }
                case 7:
                    {
                        _first = "Đinh";
                        break;
                    }
                case 8:
                    {
                        _first = "Mậu";
                        break;
                    }
                case 9:
                    {
                        _first = "Tỵ";
                        break;
                    }
            }
            return _first;
        }

        String calcLast(int last)
        {
            switch (last)
            {
                case 0:
                    {
                        _last = "Thân";
                        break;
                    }
                case 1:
                    {
                        _last = "Dậu";
                        break;
                    }
                case 2:
                    {
                        _last = "Tuất";
                        break;
                    }
                case 3:
                    {
                        _last = "Hợi";
                        break;
                    }
                case 4:
                    {
                        _last = "Tý";
                        break;
                    }
                case 5:
                    {
                        _last = "Sửu";
                        break;
                    }
                case 6:
                    {
                        _last = "Dần";
                        break;
                    }
                case 7:
                    {
                        _last = "Mẹo";
                        break;
                    }
                case 8:
                    {
                        _last = "Thìn";
                        break;
                    }
                case 9:
                    {
                        _last = "Tỵ";
                        break;
                    }
                case 10:
                    {
                        _last = "Ngọ";
                        break;
                    }
                case 11:
                    {
                        _last = "Mùi";
                        break;
                    }
            }
            return _last;
        }
    }
}
