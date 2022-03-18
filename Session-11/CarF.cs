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
    public partial class CarF : DevExpress.XtraEditors.XtraForm
    {
        public const string FILE_NAME = "storage.json";
        public ServiceCenter _serviceCenter;
        private Car _car;
        public CarF()
        {
            InitializeComponent();
        }

        public CarF(ServiceCenter serviceCenter)
        {
            InitializeComponent();
            _serviceCenter = serviceCenter;
        }

        public CarF(ServiceCenter serviceCenter, Car car):this(serviceCenter)
        {
            _car = car;
            if (_car == null)
            {
                _car = new Car() { Brand = Brands.Reanult };
                _serviceCenter.Cars.Add(_car);
                bsCar.DataSource = _car;

            }
            bsCar.DataSource = _car;
            populateControls();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }


        private void CarF_Load(object sender, EventArgs e)
        {
            if (_car == null)
            {
                _car = new Car() { Brand = Brands.Reanult };
                _serviceCenter.Cars.Add(_car);
                bsCar.DataSource = _car;

            }
            bsCar.DataSource = _car;
            populateControls();
            SetDataBindings();
        }
        private void populateControls()
        {
            comboBrand.Properties.Items.Add(Brands.Audi);
            comboBrand.Properties.Items.Add(Brands.Reanult);
            comboBrand.Properties.Items.Add(Brands.Honda);
            comboBrand.Properties.Items.Add(Brands.Mercedes);
            comboBrand.Properties.Items.Add(Brands.Reanult);
            comboBrand.Properties.Items.Add(Brands.Citroen);
            comboBrand.Properties.Items.Add(Brands.Volvo);

        }
        private void SetDataBindings()
        {
            ctrlRegNum.DataBindings.Add(new Binding("EditValue", bsCar, "RegistrationNumber", true));
            ctrlModel.DataBindings.Add(new Binding("EditValue", bsCar, "Model", true));
            comboBrand.DataBindings.Add(new Binding("EditValue", bsCar, "Brand", true));
        }
        private void Save()
        {
            string json = JsonSerializer.Serialize(_serviceCenter);
            File.WriteAllText(FILE_NAME, json);
            this.Close(); 
        }
    }



}
