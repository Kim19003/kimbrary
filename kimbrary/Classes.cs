namespace Kimbrary
{
    namespace Classes
    {
        public static class Classes
        {
            public class ValueHolder<T>
            {
                public T? Value { get; set; }

                public ValueHolder()
                {

                }

                public ValueHolder(T value)
                {
                    Value = value;
                }

                public void SetValue(T value)
                {
                    Value = value;
                }

                public T? GetValue()
                {
                    return Value;
                }
            }
        }
    }
}