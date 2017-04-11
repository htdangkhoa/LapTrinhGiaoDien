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
    public partial class Bai4 : Form
    {
        bool isSinhVien;
        List<Button> listBtn;
        List<CheckBox> listCheckBox;

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            getText(sender);
        }

        private void getText(CheckBox c)
        {
            Console.WriteLine(c.Text);
        }

        public Bai4()
        {
            InitializeComponent();

            isSinhVien = false;
            listBtn = new List<Button>();
            foreach (Control c in panel2.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    listBtn.Add(b);
                }
            }
            foreach (Control c in panel2.Controls)
            {
                if (c.GetType() == typeof(CheckBox))
                {
                    CheckBox cb = (CheckBox)c;
                    //listCheckBox.Add(cb);
                    cb.CheckedChanged += new System.EventHandler(cb_CheckedChanged); 
                }

            }
        }

        public void enableButton()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c.GetType() == typeof(Button))
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                }
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_name.Text))
            {
                enableButton();
            }
        }

        private void ckb_sinhvien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_sinhvien.Checked)
            {
                isSinhVien = true;
            }
        }
    }
}
