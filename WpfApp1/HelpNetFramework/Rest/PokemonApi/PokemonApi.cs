using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpNetFramework.Rest.PokemonApi {
   public class PokemonApi : ServiceRestApi {

       public PokemonApi(string server, string port, string endpoint, string request) : 
            base(server,port,endpoint,request) {

        }

    }
}
