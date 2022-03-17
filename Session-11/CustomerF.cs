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
using CarServiceCenterLibrary;

namespace Session_11
{
    public partial class CustomerF : DevExpress.XtraEditors.XtraForm
    {
        private Customer _customer;
        public CustomerF()
        {
            InitializeComponent();
        }
        public CustomerF(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void CustomerF_Load(object sender, EventArgs e)
        {

        }
    }
}