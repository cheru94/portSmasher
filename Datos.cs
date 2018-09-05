using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace portSmasher
{
    class Datos
    {

        private List<int> ports;
        private string host;



        public Datos()
        {
            ports = new List<int>();             
            //ports.Add();
            host = "HOST OF KNOCK";

        }


        public Datos(List<int> ports, string host)
        {

            this.ports = ports;
            this.host = host;


        }



        public List<int> pnPorts
        {
            get { return ports; }
            set { ports = value; }
        }


        public string pnHost
        {
            get { return host; }
            set { host = value; }
        }



    }
}
