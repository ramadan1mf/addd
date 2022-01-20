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
    public partial class add_passenger : Form
    {
       CL.CL_passenger addnatio = new CL.CL_passenger();
        public add_passenger()
        {
            InitializeComponent();
            cob_natio.DataSource = addnatio.T_natio();
            cob_natio.DisplayMember = "natioA";
            cob_natio.ValueMember = "natioID";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
