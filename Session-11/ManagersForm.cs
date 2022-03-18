using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class ManagersForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        List<Manager> managers;
        public readonly ManagerService managerService = new ManagerService();
        public ManagersForm()
        {
            InitializeComponent();

        }
        private void ManagersForm_Load(object sender, EventArgs e)
        {

            managers = managerService.GetManagers();
            bsManagers.DataSource = managers;


        }

        private void gridControlManagers_Click(object sender, EventArgs e)
        {


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var manager = new Manager();
            var editForm = openF.GetForm<ManagerEditForm>(State.New, manager, bsManagers);

            editForm.ShowDialog();
            grvManagers.RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var manager = GetSelectedManager();
            if (manager != null)
            {
                var editForm = openF.GetForm<ManagerEditForm>(State.Edit, manager, bsManagers);
                editForm.ShowDialog();
                grvManagers.RefreshData();

            }

        }


        private Manager? GetSelectedManager()
        {

            var selectedIndexes = grvManagers.GetSelectedRows();
            if (selectedIndexes is not null)
            {
                return grvManagers.GetRow(selectedIndexes[0]) as Manager;
            }
            else
            {
                return null;
            }
        }


        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            managerService.SaveManagers(bsManagers.DataSource as List<Manager>);
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure that you want to delete this Manager?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedManager = GetSelectedManager();
                ((List<Manager>)bsManagers.DataSource).Remove(selectedManager);
                grvManagers.RefreshData();
            }
            
        }
    }
}