namespace Dp
{
    public abstract class CloseableResource
    {
        public void Close()
        {
            //some closing actions
        }

        //some code
    }
    class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");
                    Close();
                }
                Console.WriteLine("Disposing by GC");
                Close();
                _disposed = true;
            }
        }
        ~DisposePatternImplementer()
        {
            Dispose(false);
        }
    }
}
