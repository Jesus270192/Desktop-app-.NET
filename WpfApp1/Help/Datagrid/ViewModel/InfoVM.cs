using Help.Datagrid.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help.Datagrid.ViewModel
{
    public class InfoVM
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public Person Person { get; set; }

        public InfoVM()
        {
            Person = new Person()
            {
                Name = "Jesus"
            };
        }

    }
}
