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
using System.Text.Json;
using System.IO;
using CarServiceCenterLibrary;


namespace Session_11
{
    public partial class ServiceTaskF : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "storage.json";
        private ServiceTask _serviceTask;
        private ServiceCenter _serviceCenter;
        public ServiceTaskF()
        {
            InitializeComponent();
        }
        public ServiceTaskF(ServiceCenter serviceCenter)
        {
            InitializeComponent();
            _serviceCenter = serviceCenter;
        }
        public ServiceTaskF(ServiceCenter serviceCenter, ServiceTask serviceTask): this (serviceCenter)
        {
            _serviceTask = serviceTask;
        }

        private void ServiceTaskF_Load(object sender, EventArgs e)
        {
            if (_serviceTask == null)
            {
                _serviceTask = new ServiceTask();
                _serviceCenter.ServiceTasks.Add(_serviceTask);
                bsServiceTasks.DataSource = _serviceTask;
            }

            bsServiceTasks.DataSource = _serviceTask;
            SetDataBindings();
        }
        private void SetDataBindings() {
            ctrlCode.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Code", true));
            ctrlDescription.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Description", true));
            ctrlHours.DataBindings.Add(new Binding("EditValue", bsServiceTasks, "Hours", true));
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