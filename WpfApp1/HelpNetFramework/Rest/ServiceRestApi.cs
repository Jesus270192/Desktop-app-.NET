using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpNetFramework.Rest {
  public abstract class ServiceRestApi {
        public enum Methods {
            POST,
            GET,
            PUT,
            DELETE
        }

        public enum Protocol {
            HTTP,
            HTTPS
        }

        private Dictionary<string, string> headers;

        private string server;
        private string port;
        private string endpoint;
        private string request;
        private Uri uri;
        

        public ServiceRestApi(string server, string port, string endpoint, string request) {
            
        }

        public virtual void SetHeaders(Dictionary<string,string> headers) {
            this.headers = headers;
        }

        public virtual void TestConnection() {

        }

        public T GetResult<T>() {
            return JsonConvert.DeserializeObject<T>("{nombre:\"JESUS\"}");
        }

    }
}
