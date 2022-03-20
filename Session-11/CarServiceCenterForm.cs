﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Session_11
{

    public partial class CarServiceCenterForm : DevExpress.XtraEditors.XtraForm 
    {
        OpenForm openF = new OpenForm();
        public CarServiceCenterForm()
        {
            InitializeComponent();
        }

        private void CarServiceCenterForm_Load(object sender, EventArgs e)
        {

        }

        private void editCustomer_Click(object sender, EventArgs e)
        {   
            openF.Open<CustomerForm>();
        }

        private void editCar_Click(object sender, EventArgs e)
        {
            openF.Open<CarForm>();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            openF.Open<ManagersForm>();
        }

        private void editServiceTask_Click(object sender, EventArgs e)
        {
            openF.Open<ServiceTaskForm>();
        }
        private void editEngineer_Click(object sender, EventArgs e)
        {
            openF.Open<EngineerForm>();
        }

        

        private void newTrasaction_Click(object sender, EventArgs e)
        {
            openF.Open<TransactionForm>();
        }

    }

}