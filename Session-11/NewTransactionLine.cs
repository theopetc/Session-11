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
using DevExpress.XtraEditors.Controls;
using CarServiceCenterLibrary;

namespace Session_11
{
    public partial class NewTransactionLine : DevExpress.XtraEditors.XtraForm
    {
        TransactionLine _transactionLine;
        TransactionLine _transactionLineBackup;
        Transaction _transaction;
        ServiceCenter _serviceCenter;
        bool pressedNew = false;
        State _state;


        //public NewTransactionLine()
        //{
        //    InitializeComponent();
        //}
        public NewTransactionLine(Transaction transaction,ServiceCenter serviceCenter)
        {
            _serviceCenter = serviceCenter;
            _transaction=transaction;
            InitializeComponent();
        }


        private void NewTransactionLine_Load(object sender, EventArgs e)
        {
            Populate();
            SetDataBindings();
        }
        private void Populate()
        {
            SetCtrlServiceTask();
            SetCtrlEngineer();
            if (_transactionLine == null)
            {
                pressedNew = true;
                _transactionLine = new TransactionLine();
                _transaction.TransactionLines.Add(_transactionLine);
                bsTransactionLines.DataSource = _transactionLine;
            }
            bsTransactionLines.DataSource = _transactionLine;
        }
        private void SetCtrlServiceTask()
        {
            ctrlServiceTask.Properties.DataSource = _serviceCenter.ServiceTasks;
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Description", "Description"));
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Code", "Code"));
            ctrlServiceTask.Properties.Columns.Add(new LookUpColumnInfo("Hours", "Hours"));
            ctrlServiceTask.Properties.DisplayMember = "Description";
            ctrlServiceTask.Properties.ValueMember = "ID";
        }
        private void SetCtrlEngineer()
        {
            ctrlEngineer.Properties.DataSource = _serviceCenter.Engineers;
            ctrlEngineer.Properties.Columns.Add(new LookUpColumnInfo("Name", "Name"));
            ctrlEngineer.Properties.Columns.Add(new LookUpColumnInfo("Surname", "Surname"));
            ctrlEngineer.Properties.DisplayMember = "Surname";
            ctrlEngineer.Properties.ValueMember = "ID";
        }
        private void SetDataBindings()
        {
            ctrlServiceTask.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "ServiceTaskID", true));
            ctrlEngineer.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "EngineerID", true));
            txtPricePerHour.DataBindings.Add(new Binding("EditValue", bsTransactionLines, "PRICE_PER_HOUR", true)); 
        }
        

        private void txtHours_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _transaction.TransactionLines.Add(_transactionLine);
            this.Close();
        }
    }
}