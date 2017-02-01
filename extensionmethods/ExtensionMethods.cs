using System;

namespace extensionmethods
{
    public static class ExtensionMethods
    {
        public static DateTime Tomorrow(this DateTime date)
        {
            return date.AddDays(1);
        }
    }
}
