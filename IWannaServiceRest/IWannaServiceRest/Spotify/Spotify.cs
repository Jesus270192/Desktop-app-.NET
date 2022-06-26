using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWannaServiceRest.Spotify
{
   public class Spotify : BodyRest
    {
        public Spotify(PROTOCOL protocol, string server, string port, string uri, string param, METHOD method) 
            : base( protocol,  server,  port,  uri,  param,  method)
        {
        
        }

    }
}
