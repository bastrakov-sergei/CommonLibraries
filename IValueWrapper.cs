namespace CommonLibraries
{
    public interface IValueWrapper<T>
    {
        T Value { get; set; }
        bool HasValue { get; set; }
    }
}