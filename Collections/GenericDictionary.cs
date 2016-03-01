using System.Collections.Generic;

namespace CommonLibraries.Collections
{
    public sealed class GenericDictionary<TKey> : IGenericDictionary<TKey>
    {
        private readonly Dictionary<TKey, object> dictionary = new Dictionary<TKey, object>();

        public IEnumerable<TKey> Keys
        {
            get { return dictionary.Keys; }
        }

        public T Get<T>(TKey key)
        {
            object value;
            if (dictionary.TryGetValue(key, out value))
            {
                ValueWrapper<T> wrapper = value as ValueWrapper<T>;
                if (wrapper != null)
                {
                    return wrapper.Value;
                }
            }

            return default(T);
        }

        public void Set<T>(TKey key, T value)
        {
            if (dictionary.ContainsKey(key))
            {
                ((ValueWrapper<T>) dictionary[key]).Value = value;
                return;
            }

            dictionary.Add(key, new ValueWrapper<T>
            {
                Value = value
            });
        }

        public void Clear()
        {
            dictionary.Clear();
        }

        public bool Remove(TKey key)
        {
            return dictionary.Remove(key);
        }
    }
}
