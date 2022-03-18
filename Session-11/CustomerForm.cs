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
using System.Text.Json;
using System.IO;

namespace Session_11
{
    public partial class CustomerForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "customers.json";
        public CustomerForm()
        {
            InitializeComponent();
        }
        #region UI Controls
        private void btnNew_Click(object sender, EventArgs e)
        {
            var customer = bsCustomer.Current as Customer;

            CustomerF customerForm = new CustomerF(customer);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Student?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var customer = bsCustomer.Current as Customer;
            bsCustomer.Remove(customer);
            SaveData<CustomerF>();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var customer = bsCustomer.Current as Customer;

            CustomerF customerForm = new CustomerF(customer);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        #endregion
        private void SaveData<T>() where T : Form, new()
        {
            var customer = bsCustomer.Current as Customer;
            string json = JsonSerializer.Serialize(customer);
            File.WriteAllText(FILE_NAME, json);
        }


    }
}