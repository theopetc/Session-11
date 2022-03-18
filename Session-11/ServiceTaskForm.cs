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
using DevExpress.XtraGrid;


namespace Session_11
{
    public partial class ServiceTaskForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm open = new OpenForm();
        private const string FILE_NAME = "storage.json";
        private string item = "customers";
        public ServiceTaskForm()
        {
            InitializeComponent();
        }
        #region UI
        private void ServiceTaskForm_Load(object sender, EventArgs e)
        {
            open.PopulateServices(FILE_NAME, bsServiceCenter, bsServiceTasks, grdServiceTasks, item);
        }

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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        private void NewData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;

            ServiceTaskF serviceTaskForm = new ServiceTaskF(serviceCenter);
            serviceTaskForm.ShowDialog();
            grvServiceTasks.RefreshData();
        }
        private void DeleteData()
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Student?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var serviceTask = bsServiceTasks.Current as ServiceTask;
            bsServiceTasks.Remove(serviceTask);
            SaveData<ServiceTaskF>();
        }
        private void SaveData<T>() where T : Form, new()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            string json = JsonSerializer.Serialize(serviceCenter);
            File.WriteAllText(FILE_NAME, json);
        }

        private void EditData()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;

            var serviceTask = bsServiceTasks.Current as ServiceTask;

            ServiceTaskF serviceTaskForm = new ServiceTaskF(serviceCenter, serviceTask);
            serviceTaskForm.ShowDialog();
            grvServiceTasks.RefreshData();
        }
        //private void PopulateServices()
        //{
        //    string s = File.ReadAllText(FILE_NAME);
        //    var serviceCenter = (ServiceCenter)JsonSerializer.Deserialize(s, typeof(ServiceCenter));

        //    bsServiceCenter.DataSource = serviceCenter;

        //    bsServiceTasks.DataSource = bsServiceCenter;
        //    //bsServiceTasks.DataMember = "ServiceTasks";

        //    grdServiceTasks.DataSource = bsServiceTasks;
        //}


    }
}