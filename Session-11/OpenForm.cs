using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using CarServiceCenterLibrary;

namespace Session_11
{
    public class OpenForm
    {

        public OpenForm()
        {

        }
        public void Open<T>() where T : Form, new()
        {
            var form = new T();
            form.Show();
        }
        public T GetForm<T>(params object[] prms) where T : Form
        {
             return (T)Activator.CreateInstance(typeof(T),prms);
        }

        public void SetDataBindingsCustomers(TextEdit name, TextEdit surname, TextEdit phone, TextEdit tin, BindingSource customer)
        {

            name.DataBindings.Add(new Binding("EditValue", customer, "Name", true));
            surname.DataBindings.Add(new Binding("EditValue", customer, "Surname", true));
            phone.DataBindings.Add(new Binding("EditValue", customer, "Phone", true));
            tin.DataBindings.Add(new Binding("EditValue", customer, "TIN", true));

        }
    }
}
