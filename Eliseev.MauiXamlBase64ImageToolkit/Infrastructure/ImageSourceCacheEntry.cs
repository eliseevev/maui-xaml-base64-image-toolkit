using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eliseev.MauiXamlBase64ImageToolkit.Infrastructure
{
    internal class Base64ImageSourceCacheEnty
    {
        public Base64ImageSourceCacheEnty(ImageSource imageSource)
        {
            ImageSource = imageSource;
        }

        public ImageSource ImageSource { get; private set; }

        private int count;
        
        public void IncrementReferenceCount()
        {
            Interlocked.Increment(ref count);
        }

        public void DecrementReferencesCount()
        {
            Interlocked.Decrement(ref count);
        }

        public bool HasNoReferences()
        {
            return count <= 0;
        }
    }
}
