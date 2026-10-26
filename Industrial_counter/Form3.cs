using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Industrial_counter
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form3_FormClosing);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("정말 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // 종료 취소
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                this.Close();
                Login_From login_From = new Login_From();
                login_From.ShowDialog();
            }
        }
    }
}
