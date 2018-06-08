using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITS.Data.Infrastructure
{
    public class Disposable : IDisposable
    {
        // Flag: Has Dispose already been called?
        bool disposed;

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
           

            if (!disposed && disposing)
            {
                DisposeCore();
            }

        
            disposed = true;
        }

        // Overide this to dispose custom objects
        protected virtual void DisposeCore()
        {
           
        }
    }
}
