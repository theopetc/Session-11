using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Session_11
{

    public partial class CarServiceCenterForm : DevExpress.XtraEditors.XtraForm 
    {
        OpenForm openF = new OpenForm();
        public CarServiceCenterForm()
        {
            InitializeComponent();
        }

        private void CarServiceCenterForm_Load(object sender, EventArgs e)
        {

        }

        private void editCustomer_Click(object sender, EventArgs e)
        {   
            openF.Open<CustomerForm>();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void editServiceTask_Click(object sender, EventArgs e)
        {
            openF.Open<ServiceTaskForm>();
        }
    }

}