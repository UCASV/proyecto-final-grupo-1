using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_POO.Tools
{
    class Response
    {
        public string Msg { get; set; }
        public bool Ok { get; set; }
        
        public Response(string msg, bool ok)
        {
            Msg = msg;
            Ok = ok;
        }
    }
}
