using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NPC npc = new NPC();
            npc.Name = "啊~~";
            npc.Hp = 500;
            npc.Lv = 30;

            string json = JsonConvert.SerializeObject(npc);





            Console.WriteLine(json);
        }
    }
}
