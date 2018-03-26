namespace Evolution.Daxtra
{
    using System;
    using System.Net;

    /// <summary>Exception thrown for issues with the Daxtra service</summary>
    public class DaxtraException : Exception
    {
        public DaxtraException(string message, int code, HttpStatusCode httpStatus, string body) :
            base(message)
        {
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

        /// <summary>Get or set the HTTP status code of the error.</summary>
        public HttpStatusCode HttpStatus { get; set; }

        /// <summary>Get or set the error code recieved from Daxtra.</summary>
        public int Code { get; set; }
    }
}