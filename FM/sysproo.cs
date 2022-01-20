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
    public partial class sysproo : Form
    {
        //Single Instance
        private static sysproo FM;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FM = null;
        }

        public static sysproo getMainForm
        {
            get
            {
                if (FM == null)
                {
                    FM = new sysproo();
                    FM.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return FM;
            }
        }
        public sysproo()
        {
            InitializeComponent();
            if (FM == null)
                FM = this;
            this.ادخالالبياناتToolStripMenuItem.Enabled = true;
            this.اضافة1ToolStripMenuItem.Enabled = true;
            this.اضافة2ToolStripMenuItem.Enabled = true;
            this.اضافةToolStripMenuItem.Enabled = true;
            this.اضافةمستخدمToolStripMenuItem.Enabled = false;
            this.التقاريرToolStripMenuItem.Enabled = false;
            this.بياناتاساسيةToolStripMenuItem.Enabled = false;
            this.تعديلمستخدمToolStripMenuItem.Enabled = false;
            this.قائمةالرحلاتToolStripMenuItem.Enabled = false;
           
        }

        private void فتحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.ShowDialog();
        }

        private void sysproo_Load(object sender, EventArgs e)
        {

        }

        private void اغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void راكبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_passenger frm = new add_passenger();
            frm.ShowDialog();
        }
    }
}
