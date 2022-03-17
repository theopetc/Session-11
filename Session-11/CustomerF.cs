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
using System.IO;
using System.Text.Json;

namespace Session_11
{
    public partial class CustomerF : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        private Customer _customer;
        private ServiceCenter _serviceCenter;
        public CustomerF()
        {
            InitializeComponent();
            
        }
        public CustomerF(ServiceCenter serviceCenter)
        {
            InitializeComponent();
            _serviceCenter = serviceCenter;
        }
        public CustomerF(ServiceCenter serviceCenter, Customer customer) : this(serviceCenter)
        {
            _customer = customer;
        }

        private void CustomerF_Load(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                _customer = new Customer();
                _serviceCenter.Customers.Add(_customer);
                bsCustomers.DataSource = _customer;
            }

            bsCustomers.DataSource = _customer;

            //TODO Customer multiple task services

            //bsCourses.DataSource = bsStudents;
            //bsCourses.DataMember = "Courses";
            //grdCourses.DataSource = bsCourses;

            SetDataBindings();
            //ClearDataBindings();
            
        }
        private void SetDataBindings()
        {
            
            ctrlName.DataBindings.Add(new Binding("EditValue", bsCustomers, "Name", true));
            ctrlSurname.DataBindings.Add(new Binding("EditValue", bsCustomers, "Surname", true));
            ctrlPhone.DataBindings.Add(new Binding("EditValue", bsCustomers, "Phone", true));
            ctrlTIN.DataBindings.Add(new Binding("EditValue", bsCustomers, "TIN", true));
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(_serviceCenter);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        
    }
}