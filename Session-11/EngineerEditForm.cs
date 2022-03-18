using CarServiceCenterLibrary;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11
{
    public partial class EngineerEditForm : DevExpress.XtraEditors.XtraForm
    {
        private const string FILE_NAME = "engineers.json";
        public ServiceCenter ListOfEngineers;
        private Engineer _engineer;
        public EngineerEditForm()
        {
            InitializeComponent();
        }

        public EngineerEditForm(ServiceCenter listOfEngineers)
        {            
            ListOfEngineers = listOfEngineers;
            InitializeComponent();
        }


        public EngineerEditForm(ServiceCenter listOfEngineers, Engineer engineer)
        {
            _engineer = engineer;
            ListOfEngineers = listOfEngineers;
            InitializeComponent();
        }

        private void EngineerEditForm_Load(object sender, EventArgs e)
        {

            PopulateEngineers();
            
            SetDataBindings();
            
        }

        private void PopulateEngineers()
        {
            if (_engineer == null)
            {
                _engineer = new Engineer();
                ListOfEngineers.Engineers.Add(_engineer);
                bsEngineers.DataSource = _engineer;
            }
            bsEngineers.DataSource = _engineer;                     
        }


        private void SetDataBindings()
        {
            ctrlName.DataBindings.Add(new Binding("EditValue", bsEngineers, "Name", true));
            ctrlSurname.DataBindings.Add(new Binding("EditValue", bsEngineers, "Surname", true));
            //ctrlManager.DataBindings.Add(new Binding("EditValue", bsEngineers, "ManagerID", true));
            ctrlSallary.DataBindings.Add(new Binding("EditValue", bsEngineers, "SallaryPerMonth", true));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            string json = JsonSerializer.Serialize(ListOfEngineers);
            File.WriteAllText(FILE_NAME, json);
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}