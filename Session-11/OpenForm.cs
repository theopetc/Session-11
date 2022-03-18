using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using DevExpress.XtraGrid;

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

        public void PopulateServices(string file_name, BindingSource service_Center, BindingSource binding, GridControl grid, string item)
        {
            string s = File.ReadAllText(file_name);
            var serviceCenter = (ServiceCenter)JsonSerializer.Deserialize(s, typeof(ServiceCenter));

            service_Center.DataSource = serviceCenter;

            binding.DataSource = service_Center;
            binding.DataMember = item;

            grid.DataSource = service_Center;
        }

    }
}
