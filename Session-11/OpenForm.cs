using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            form.ShowDialog();
        }
        public T GetForm<T>(params object[] prms) where T : Form
        {
             return (T)Activator.CreateInstance(typeof(T),prms);
        }
        
    }
}
