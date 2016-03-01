namespace CommonLibraries.Collections
{
    public interface IGenericDictionary<TKey>
    {
        T Get<T>(TKey key);
        void Set<T>(TKey key, T value);

        void Clear();

        bool Remove(TKey key);
    }
}