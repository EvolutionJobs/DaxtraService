namespace Evolution.Daxtra.Models
{using System;
using System.Collections.Generic;
using System.Linq;
    using System.Net;
    using System.Threading.Tasks;

    public class DaxtraException: Exception
    {
        public DaxtraException(string message, int code, HttpStatusCode httpStatus, string body) :
            base(message) {
            this.Data.Add("json-response", body);
            this.Code = code;
            this.HttpStatus = httpStatus;
        }

        public DaxtraException(string message) :
            base(message)
        {
            this.Code = 0;
            this.HttpStatus = HttpStatusCode.OK;
        }

        public HttpStatusCode HttpStatus { get; set; }

        public int Code { get; set; }
    }
}