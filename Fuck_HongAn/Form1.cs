using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuck_HongAn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 文件内外发管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //调用系统默认的浏览器  
            System.Diagnostics.Process.Start("http://10.1.58.209:8080/dlp/clientLogin.jsp?loginName=%E6%9C%B1%E5%8B%87%E6%99%BA&clientId={5668B0C1-89F6-4A2E-8C98-7C5A4C67DE2B}&menuId=178");  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Hide();
            this.ShowInTaskbar = false;

        }
        
    }
}
