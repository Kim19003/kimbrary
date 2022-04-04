using System.Linq;

namespace Kimbrary
{
    namespace Expressions
    {
        public class Expressions
        {
            public static bool IsTrueAny(params bool?[] items)
            {
                return items.Contains(true);
            }

            public static bool IsFalseAny(params bool?[] items)
            {
                return items.Contains(false);
            }

            public static bool IsNullOrTrueAny(params bool?[] items)
            {
                return items.Contains(null) || items.Contains(true);
            }

            public static bool IsNullOrFalseAny(params bool?[] items)
            {
                return items.Contains(null) || items.Contains(false);
            }
        }
    }
}