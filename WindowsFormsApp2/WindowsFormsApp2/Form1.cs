using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int _randomNum = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetRandomNum();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetRandomNum()
        {
            _randomNum = new Random().Next(0, 100);
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            int input = -1;
            if (int.TryParse(txtinput.Text, out input))
            {
                //可以比數字
                if (input == _randomNum)
                {
                    DialogResult result = MessageBox.Show("恭喜你答對了\n 按是 重新開局 按否 結束", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        SetRandomNum();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("再來一次", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
