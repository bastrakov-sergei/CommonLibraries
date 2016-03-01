namespace CommonLibraries
{
    public class ValueWrapper<T> : IValueWrapper<T>
    {
        public T Value { get; set; }
        T IValueWrapper<T>.Value
        {
            get { return Value; }
            set { Value = (T)value; }
        }
        public bool HasValue { get; set; }

        public ValueWrapper()
        {
            HasValue = false;
        }

        public ValueWrapper(T value)
        {
            Value = value;
            HasValue = value != null;
        }
    }
}