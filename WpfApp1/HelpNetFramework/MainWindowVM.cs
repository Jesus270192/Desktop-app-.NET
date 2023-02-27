using HelpNetFramework.Commons;
using HelpNetFramework.DataGrid.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelpNetFramework {
    public class MainWindowVM : IVM {
        public event PropertyChangedEventHandler PropertyChanged;
        private const string Message = "These are examples with  diferent control using MVVM";

        public string Title { get; set; }

        public IControls Controls { get; set; }
        
        public MainWindowVM() {
            Title = Message;
            GenerateControls();
        }

        private void GenerateControls() {
            
            Controls = new DataGridExample();
        }

        void IVM.NotifyPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
