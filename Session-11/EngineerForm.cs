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
    public partial class EngineerForm : DevExpress.XtraEditors.XtraForm
    {
        ServiceCenter ListOfEngineers = new ServiceCenter();
        private const string FILE_NAME = "engineers.json";
        public EngineerForm()
        {
            InitializeComponent();
        }
        private void EngineerForm_Load(object sender, EventArgs e)
        {
            LoadData();
            PopulateControls();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK;            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var listOfEngineers = bsListOfEngineers.Current as ServiceCenter;
            EngineerEditForm editForm = new EngineerEditForm(listOfEngineers);            
            editForm.ShowDialog();
            grvEngineers.RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(this, "Are you sure you want to delete the selected Engineer?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
                return;
            var engineer = bsEngineers.Current as Engineer;
            bsEngineers.Remove(engineer);
            
            SaveData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var listOfEngineers = bsListOfEngineers.Current as ServiceCenter;

            var engineer = bsEngineers.Current as Engineer;

            EngineerEditForm editForm = new EngineerEditForm(listOfEngineers, engineer);            
            editForm.ShowDialog();

            grvEngineers.RefreshData();
        }
        
        private void PopulateControls()
        {


            //Engineer engineer = new Engineer();
            //engineer.Name = "Panos";
            //engineer.Surname = "Papadopoulos";
            //engineer.SallaryPerMonth = 600;
            //ListOfEngineers.Engineers.Add(engineer);
            //SaveData();

            bsListOfEngineers.DataSource = ListOfEngineers;            
            bsEngineers.DataSource = bsListOfEngineers;
            bsEngineers.DataMember = "Engineers";

            grdEngineers.DataSource = bsEngineers;


            grvEngineers.RefreshData();
        }

        private void LoadData()
        {
            if (!File.Exists(FILE_NAME))
            {                
                MessageBox.Show(FILE_NAME + " doesnt exist");
            }                            

            string s = File.ReadAllText(FILE_NAME);

            ListOfEngineers = (ServiceCenter)JsonSerializer.Deserialize(s, typeof(ServiceCenter));

        }
        private void SaveData()
        {
            string json = JsonSerializer.Serialize(ListOfEngineers);
            File.WriteAllText(FILE_NAME, json);
        }
    }
}