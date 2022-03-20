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
using Services;

namespace Session_11
{
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm
    {
        OpenForm openF = new OpenForm();
        ServiceCenter serviceCenter;
        public readonly StorageService storageService = new StorageService();
        public Transaction transaction;
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewData();

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            serviceCenter = storageService.GetSeviceCenter();
            bsTransactions.DataSource = serviceCenter.Transactions;
            PopulateControls();
        }
        private void NewData()
        {
            var transaction = new Transaction();
            var editForm = openF.GetForm<NewTransaction>(State.New, transaction, bsTransactions);
            serviceCenter.Transactions = bsTransactions.DataSource as List<Transaction>;
            storageService.SaveServiceCenter(serviceCenter);
            editForm.ShowDialog();
            grvTransactions.RefreshData();
        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            serviceCenter.Transactions = bsTransactions.DataSource as List<Transaction>;
            storageService.SaveServiceCenter(serviceCenter);
            this.Close();
        }
        private void PopulateControls()
        {
            var open = new OpenForm();
            open.PopulateCustomer(repCustomer);
            open.PopulateCar(repCar);
            open.PopulateManager(repManager);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            EditData();
        }
        private void EditData()
        {
            var transaction = GetSelectedTransaction();
            if (transaction != null)
            {
                var editForm = openF.GetForm<NewTransaction>(State.Edit, transaction, bsTransactions);
                editForm.ShowDialog();
                grvTransactions.RefreshData();

            }
        }
        private Transaction? GetSelectedTransaction()
        {

            var selectedIndexes = grvTransactions.GetSelectedRows();
            if (selectedIndexes is not null)
            {
                return grvTransactions.GetRow(selectedIndexes[0]) as Transaction;
            }
            else
            {
                return null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void DeleteData()
        {
            var result = MessageBox.Show("Are you sure that you want to delete this Transaction?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedTransaction = GetSelectedTransaction();
                ((List<Transaction>)bsTransactions.DataSource).Remove(selectedTransaction);
                grvTransactions.RefreshData();
            }
        }
    }
}