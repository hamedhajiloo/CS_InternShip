using System;
using System.Collections.Generic;
using System.Text;

namespace P7.WeakReference
{
    public class WeakCache<TKey, TValue> where TValue : class
    {
        private Dictionary<TKey, WeakReference<TValue>> _cache =
        new Dictionary<TKey, WeakReference<TValue>>();
        public void Add(TKey key, TValue value)
        {
            _cache.Add(key, new WeakReference<TValue>(value));
        }
        public bool TryGetValue(TKey key, out TValue cachedItem)
        {
            WeakReference<TValue> entry;
            if (_cache.TryGetValue(key, out entry))
            {
                bool isAlive = entry.TryGetTarget(out cachedItem);//this will be a strong reference.
                if (!isAlive)
                {
                    _cache.Remove(key);
                }
                return isAlive;
            }
            else
            {
                cachedItem = null;
                return false;
            }
        }
    }
}
