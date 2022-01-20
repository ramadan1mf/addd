using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysproo.FM
{
    public partial class login : Form
    {
        CL.CL_login log = new CL.CL_login();
        public login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            DataTable DT = log.login(txtname.Text, txtpass.Text);

            if (DT.Rows.Count > 0)
            {
                sysproo.getMainForm.اتصالبقاعدةالبياناتToolStripMenuItem.Enabled = true;
                sysproo.getMainForm.القائمةالرئيسيةToolStripMenuItem.Enabled = true;
                sysproo.getMainForm.بياناتاساسيةToolStripMenuItem.Enabled = true;
                sysproo.getMainForm.قائمةالرحلاتToolStripMenuItem.Enabled = true;
                sysproo.getMainForm.بياناتالمستخدمينToolStripMenuItem.Enabled = true;
                sysproo.getMainForm.التقاريرToolStripMenuItem.Enabled = true;
                this.Close();
            }

            else
            {
                MessageBox.Show(" اسم المستخدم او كلمة المرور خطأ !");
            }
        }
          

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
