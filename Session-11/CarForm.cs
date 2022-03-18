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
    public partial class CarForm : DevExpress.XtraEditors.XtraForm
    {
        public const string FILE_NAME = "storage.json";
        public CarForm()
        {
            InitializeComponent();      
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;

            CarF carF = new CarF(serviceCenter);
            carF.ShowDialog();
            grvCars.RefreshData();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Car?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var car = bsCar.Current as Car;
            bsCar.Remove(car);
            //SaveData<CarF>();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            var car = bsCar.Current as Car;
            
            CarF carForm = new CarF();
            carForm.ShowDialog();
            grvCars.RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void SaveData<T>() where T : Form, new()
        {
            var serviceCenter = bsServiceCenter.Current as ServiceCenter;
            string json = JsonSerializer.Serialize(serviceCenter);
            File.WriteAllText(FILE_NAME, json);
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
        //private void PopulateCustomers()
        //{
        //    string s = File.ReadAllText(FILE_NAME);
        //    var serviceCenter = (ServiceCenter)JsonSerializer.Deserialize(s, typeof(ServiceCenter));

        //    bsServiceCenter.DataSource = serviceCenter;

        //    bsCar.DataSource = bsServiceCenter;
        //    bsCar.DataMember = "Car";

        //    //grvCars.DataSource = bsCar;
        //}
    }
}