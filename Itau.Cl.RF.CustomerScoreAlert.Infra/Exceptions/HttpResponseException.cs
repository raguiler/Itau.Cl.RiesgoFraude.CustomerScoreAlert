using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itau.Cl.Rf.CustomerScoreAlert.Infra.Exceptions
{
    [Serializable]
    public class HttpResponseException : Exception
    {
        public int Status { get; set; }

        public string Value { get; set; }

        public HttpResponseException(string message , int eventId) : base(message)
        {
            Status = eventId;
            
        }
    }

}
