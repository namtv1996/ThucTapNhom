using QuanLyNhanSu.UC;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Add(new Personnel());
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
