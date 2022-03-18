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
        private const string FILE_NAME = "storage.json";
        
        
        public CustomerForm()
        {
            InitializeComponent();
            
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            PopulateCustomers();
        }
        #region UI Controls
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void SaveData<T>() where T : Form, new()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            string json = JsonSerializer.Serialize(serviceCenter);
            File.WriteAllText(FILE_NAME, json);
        }

        private void PopulateCustomers()
        {
            string s = File.ReadAllText(FILE_NAME);
            var serviceCenter = (ServiceCenter)JsonSerializer.Deserialize(s, typeof(ServiceCenter));

            bsServiceCenter.DataSource = serviceCenter;

            bsCustomers.DataSource = bsServiceCenter;
            bsCustomers.DataMember = "Customers";

            grdCustomers.DataSource = bsCustomers;
        }
        private void EditData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;

            var customer = bsCustomers.Current as Customer;

            CustomerF customerForm = new CustomerF(serviceCenter, customer);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }
        private void DeleteData()
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Student?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var customer = bsCustomers.Current as Customer;
            bsCustomers.Remove(customer);
            SaveData<CustomerF>();
        }
        private void NewData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;

            CustomerF customerForm = new CustomerF(serviceCenter);
            customerForm.ShowDialog();
            grvCustomers.RefreshData();
        }
    }

}