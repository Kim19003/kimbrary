namespace Kimbrary
{
    namespace Extensions
    {
        public static class Extensions
        {
            public static int IndexOfAny(this string value, params string[] items)
            {
                foreach (var item in items)
                {
                    if (value.Contains(item))
                    {
                        return value.IndexOf(item);
                    }
                }

                return -1;
            }

            public static T[] GetLatestElements<T>(this T[] array, int maxLimitOfElements)
            {
                List<T> latestLines = new();

                if (maxLimitOfElements >= 0)
                {
                    for (int i = (array.Length > maxLimitOfElements ? array.Length - maxLimitOfElements : 0); i < array.Length; i++)
                    {
                        latestLines.Add(array[i]);
                    }
                }

                return latestLines.ToArray();
            }

            public static List<T> GetLatestElements<T>(this List<T>array, int maxLimitOfElements)
            {
                List<T> latestLines = new();

                if (maxLimitOfElements >= 0)
                {
                    for (int i = (array.Count > maxLimitOfElements ? array.Count - maxLimitOfElements : 0); i < array.Count; i++)
                    {
                        latestLines.Add(array[i]);
                    }
                }

                return latestLines;
            }

			public static string? GetPart(this string value, string item)
			{
				try
				{
					return value.Substring(value.IndexOf(item), item.Length);
				}
				catch
				{
					return null;
				}
			}
			
            public static bool ContainsAny(this string value, params string[] items)
            {
                foreach (string item in items)
                {
                    if (value.Contains(item))
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool ContainsAll(this string value, params string[] items)
            {
                if (items.Length > 0)
                {
                    int equalItems = 0;

                    foreach (string item in items)
                    {
                        if (value.Contains(item))
                        {
                            equalItems++;
                        }
                    }

                    if (equalItems == items.Length)
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool ContainsAny(this int value, params int[] items)
            {
                foreach (int item in items)
                {
                    if (value.ToString().Contains(item.ToString()))
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool ContainsAll(this int value, params int[] items)
            {
                if (items.Length > 0)
                {
                    int equalItems = 0;

                    foreach (int item in items)
                    {
                        if (value.ToString().Contains(item.ToString()))
                        {
                            equalItems++;
                        }
                    }

                    if (equalItems == items.Length)
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool EqualsAny<T>(this T value, params T[] items)
            {
                foreach (T item in items)
                {
                    if (value.Equals(item))
                    {
                        return true;
                    }
                }

                return false;
            }

            public static bool EqualsAny<T>(this T[] array, params T[] items)
            {
                foreach (T element in array)
                {
                    foreach (T item in items)
                    {
                        if (element.Equals(item))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            public static bool EqualsAll<T>(this T[] array, params T[] items)
            {
                if (items.Length > 0)
                {
                    int equalItems = 0;

                    foreach (T element in array)
                    {
                        foreach (T item in items)
                        {
                            if (element.Equals(item))
                            {
                                equalItems++;
                            }
                        }
                    }

                    if (equalItems == items.Length)
                    {
                        return true;
                    }
                }

                return false;
            }
        }
    }
}