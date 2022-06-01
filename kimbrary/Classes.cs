namespace Kimbrary
{
    namespace Classes
    {
        public static class Classes
        {
            public class ValueHolder<T>
            {
                public T? Value { get; set; }
                public List<T?> ValuePool { get; } = new();

                public ValueHolder()
                {

                }

                public ValueHolder(T value)
                {
                    Value = value;
                }
            }
        }
    }
}