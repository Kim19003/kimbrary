using System.Linq;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Kimbrary
{
    namespace Methods
    {
        public static class Methods
        {
            public static async Task<string> ReadAsStringAsync(this IFormFile file)
            {
                StringBuilder result = new();

                using (StreamReader streamReader = new(file.OpenReadStream()))
                {
                    while (streamReader.Peek() >= 0)
                    {
                        result.AppendLine(await streamReader.ReadLineAsync());
                    }
                }

                return result.ToString();
            }

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

            public static bool IsNullAny<T>(params T?[] items)
            {
                foreach (var item in items)
                {
                    if (item == null)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}