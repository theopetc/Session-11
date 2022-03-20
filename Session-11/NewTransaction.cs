using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Services;

namespace Session_11
{
    public partial class NewTransaction : DevExpress.XtraEditors.XtraForm
    {
        State _state;
        Transaction _transaction;
        Transaction _transactionBackup;
        BindingSource _bindingSource;
        ServiceCenter serviceCenter;
        bool pressedNew = false;


        public readonly StorageService storageService = new StorageService();
        public NewTransaction()
        {
            InitializeComponent();
        }
        public NewTransaction(ServiceCenter transaction)
        { 
            serviceCenter = transaction;
            InitializeComponent();
        }
        public NewTransaction(ServiceCenter listOfTransactions, Transaction transaction)
        {
            _transaction = transaction;
            serviceCenter = listOfTransactions;
            InitializeComponent();
        }


        private void NewTransanction_Load(object sender, EventArgs e)
        {
            if (_transaction != null)
            {
                _transactionBackup = new Transaction
                {
                    
                    Date = _transaction.Date,
                    ID = _transaction.ID, 
                    CustomerID = _transaction.CustomerID,
                    CarID = _transaction.CarID,
                    ManagerID = _transaction.ManagerID,
                    TotalPrice = _transaction.TotalPrice,
                    TransactionLines = _transaction.TransactionLines
                };
            }
            Populate();

            SetDataBindings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            storageService.SaveServiceCenter(serviceCenter);
            DialogResult = DialogResult.OK;
        }

        private void Populate()
        {
            
            SetCtrlManager();
            SetCtrlCustomer();
            SetCtrlCar();
            if (_transaction == null)
            {
                pressedNew = true;
                _transaction = new Transaction();
                serviceCenter.Transactions.Add(_transaction);
                bsTransactions.DataSource = _transaction;
            }
            bsTransactions.DataSource = _transaction;
        }
        private void SetCtrlManager()
        {
            ctrlManager.Properties.DataSource = serviceCenter.Managers;
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlManager.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlManager.Properties.DisplayMember = "Surname";
            ctrlManager.Properties.ValueMember = "ID";
        }
        private void SetCtrlCustomer()
        {
            ctrlCustomer.Properties.DataSource = serviceCenter.Customers;
            ctrlCustomer.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlCustomer.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlCustomer.Properties.DisplayMember = "Surname";
            ctrlCustomer.Properties.ValueMember = "ID";
        }
        private void SetCtrlCar()
        {
            ctrlCar.Properties.DataSource = serviceCenter.Cars;
            ctrlCar.Properties.Columns.Add(new LookUpColumnInfo("Brand", "Brand"));
            ctrlCar.Properties.Columns.Add(new LookUpColumnInfo("Model", "Model"));
            ctrlCar.Properties.DisplayMember = "Brand";
            ctrlCar.Properties.ValueMember = "ID";
        }
        

        private void SetDataBindings()
        {
            ctrlCustomer.DataBindings.Add(new Binding("EditValue", bsTransactions, "CustomerID", true));
            ctrlCar.DataBindings.Add(new Binding("EditValue", bsTransactions, "CarID", true));
            ctrlManager.DataBindings.Add(new Binding("EditValue", bsTransactions, "ManagerID", true));
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (pressedNew)
            {
                serviceCenter.Transactions.Remove(_transaction);
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                int index = serviceCenter.Transactions.IndexOf(_transaction);

                serviceCenter.Transactions.RemoveAt(index);
                serviceCenter.Transactions.Insert(index, _transactionBackup);

                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}