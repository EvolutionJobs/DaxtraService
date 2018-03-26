namespace Evolution
{
    using System;
    using System.Net.Http;

    /// <summary>Base class for services that need an HTTP client.
    /// <para>Anything using this should be a singleton service.</para></summary>
    abstract class HttpService: 
        IDisposable
    {
        HttpClient client;

        /// <summary>Create an HTTP service.</summary>
        /// <param name="clt">HTTP client for this service, which will be disposed when this service is.</param>
        public HttpService(HttpClient clt) {
            this.client = clt;
        }

        /// <summary>Get the HTTP client for accessing remote services.</summary>
        protected HttpClient Client => this.client;

        /// <summary>Override to dispose additional elements.</summary>
        /// <param name="disposed">True  if already disposed.</param>
        protected virtual void Dispose(bool disposed) { }

        void IDisposable.Dispose()
        {
            if (this.client != null)
            {
                this.client.Dispose();
                this.client = null;
                this.Dispose(false);
            }
            else this.Dispose(true);
        }
    }
}