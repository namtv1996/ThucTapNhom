using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form3 : Form
    {
        private string user = "ttnhom";
        private string password = "1234";

        public Form3()
        {
            InitializeComponent();
            Load += Form3_Load;
            btnLogin.Click += BtnLogin_Click;
            btnExit.Click += BtnExit_Click;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text==user && txtPassword.Text == password)
            {
                Form1 form1 = new Form1();
                Visible = false;
                form1.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid user name or password!");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
