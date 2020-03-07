using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace API
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
          
    }
        [DllImport("User32.dll")]
        public static extern int MessageBoxA(int h, string m, string c, int type);
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);
        [DllImport("User32.dll")]
        public static extern int GetDoubleClickTime();

        // public static extern int SendMessageA(int h, int m, int c, int type);

        private void button1_Click(object sender, EventArgs e)
        {
             MessageBoxA(0, "API Message Box", "API Demo", 0);
             MessageBox(0, "API Message Box", "API Demo", 0);
            MessageBox(0,GetDoubleClickTime().ToString(), "API Demo", 0);
            System.Windows.Forms.MessageBox.Show("111");

            // SendMessageA(0, 11, 22, 0);
        }
    }
}
