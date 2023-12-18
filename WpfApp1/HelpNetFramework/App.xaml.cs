using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace HelpNetFramework {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        List<pv_parametros> pv_Parametros;

        public App() {
            completeList();
            string b = getValue<string>("A",1);
        }

        private void completeList() {
            pv_Parametros = new List<pv_parametros>();
            pv_Parametros.Add(new pv_parametros() { gpo = "A", tipo = "String", valor = "Hola" , fuente = Fuente.CODIGO });
            pv_Parametros.Add(new pv_parametros() { gpo = "B", tipo = "Integer", valor = "1" , fuente = Fuente.SQL });
        }

        public class pv_parametros {
            public string gpo { get; set; }
            public string valor { get; set; }
            public string tipo { get; set; }
            public Fuente fuente { get; set; }
        }

        public enum Fuente  {
             CODIGO,
             SQL
        }

        public T getValue<T>(string value,int numero) {
             pv_parametros pv =  pv_Parametros.FirstOrDefault(s => s.gpo == value);
            return (T)Convert.ChangeType(pv.valor, typeof(T));
        }
    }
}
