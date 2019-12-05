using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int randomNum = 45;//來亂的
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int input = -1;
            if(int.TryParse(txtinput.Text,out input))
            {
                if (input==randomNum)
                {
                    DialogResult result = MessageBox.Show("過了!!!\n 按是 重新開局 按否 結束", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                    MessageBox.Show("再接再厲", "回頭是岸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetRandomNum();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void SetRandomNum()
        {
            randomNum = new Random().Next(0, 100);
        }
    }
}
