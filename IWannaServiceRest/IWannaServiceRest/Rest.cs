using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IWannaServiceRest
{
   public abstract class Rest
    {

        private string port;
        private string uri;
        private PROTOCOL protocol;
        private string server;
        private string param;
        private METHOD method;

        public enum PROTOCOL
        {
            Http,
            Https
        }

        public enum METHOD
        {
            POST,
            GET
        }

        private string UrlGet
        {
            get
            {
                return  protocol.ToString() + "://" + server + port + uri + param; 
            }
        }

        private string UrlPost
        {
            get
            {
                return protocol.ToString() + "://" + server + port + uri;
            }
        }

        public Rest(PROTOCOL protocol, string server, string port, string uri, string param, METHOD method)
        {
            this.protocol = protocol;
            this.uri = uri;
            this.server = server;
            this.port = port;
            this.param = param;
            this.method = method;

        }

        public Rest(PROTOCOL protocol, string uri, string server, string port, METHOD method)
        {
            this.protocol = protocol;
            this.uri = uri;
            this.server = server;
            this.port = String.IsNullOrEmpty(port) ? "443" : port;
            this.method = method;
        }

        public virtual bool testConnection()
        {
            return true;
        }

        public void doRequest()
        {
            switch (method)
            {
                case METHOD.POST:
                    doRequestPost();
                    break;
                case METHOD.GET:
                    doRequestGet();
                    break;
                default:
                    break;
            }
        }

        private  void doRequestPost()
        {
            
            
        }

        private  void doRequestGet()
        {
            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(UrlGet);

            using (var response = webrequest.GetResponse())
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
            }

        }

    }
}
