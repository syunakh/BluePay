using System.Net.Http;

namespace BluePayPayments.Http
{
    internal class CustomHttpClient : HttpClient
    {
        private volatile bool _isDisposed = false;

        public bool IsDisposed => _isDisposed;

        protected override void Dispose(bool disposing)
        {
            _isDisposed = true;
            base.Dispose(disposing);
        }
    }
}
