using HelpNetFramework.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelpNetFramework.DataGrid.ViewModel {
    public class DataGridVM : IVM {
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            throw new NotImplementedException();
        }
    }
}
