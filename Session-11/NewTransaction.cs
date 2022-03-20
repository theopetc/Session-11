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
using Services;

namespace Session_11
{
    public partial class NewTransaction : DevExpress.XtraEditors.XtraForm
    {
        State _state;
        Transaction _transaction;
        BindingSource _bindingSource;
        ServiceCenter serviceCenter;
        
        public readonly StorageService storageService = new StorageService();

        public NewTransaction(State state, Transaction transaction, BindingSource bindingSource)
        {
            _state = state;
            _bindingSource = bindingSource;
            _transaction = new Transaction()
            {
                ID = transaction.ID,
                Date = transaction.Date,
                CustomerID = transaction.ID,
                CarID = transaction.CarID,
                ManagerID = transaction.ManagerID,
                TotalPrice = transaction.TotalPrice,
                TransactionLines = transaction.TransactionLines
            };
            InitializeComponent();
        }

        private void NewTransanction_Load(object sender, EventArgs e)
        {
            serviceCenter = storageService.GetSeviceCenter();
            bsCustomers.DataSource = serviceCenter.Customers;
            bsCars.DataSource = serviceCenter.Cars;
            bsManagers.DataSource = serviceCenter.Managers;

            SetDataBindings();
        }
        private void SetDataBindings()
        {
            ctrlCar.DataBindings.Add(new Binding("EditValue", bsCars, "Brand", true));
            ctrlCustomer.DataBindings.Add(new Binding("EditValue", bsCustomers, "Surname", true));
            ctrlManager.DataBindings.Add(new Binding("EditValue", bsManagers, "Name", true));           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            serviceCenter.Transactions = _bindingSource.DataSource as List<Transaction>;
            storageService.SaveServiceCenter(serviceCenter);
            SaveTransaction();
            this.Close();
        }
        private void SaveTransaction()
        {
            if (_state == State.New)
            {                
                ((List<Transaction>)_bindingSource.DataSource).Add(_transaction);
            }
            else
            {
                var editedItemIndex = ((List<Transaction>)_bindingSource.DataSource).FindIndex(x => x.ID == _transaction.ID);
                ((List<Transaction>)_bindingSource.DataSource)[editedItemIndex] = _transaction;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}