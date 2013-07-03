﻿namespace rm.Extensions
{
    /// <summary>
    /// String extensions.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Returns true if string is null or empty.
        /// </summary>
        public static bool IsNullOrEmpty(this string s)
        {
            return string.IsNullOrEmpty(s);
        }
        /// <summary>
        /// Returns true if string is null, empty or only whitespaces.
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
        /// <summary>
        /// Returns specified value if string is null/empty/whitespace else same string.
        /// </summary>
        public static string Or(this string s, string or)
        {
            if (!s.IsNullOrWhiteSpace())
            {
                return s;
            }
            return or;
        }
        /// <summary>
        /// Returns empty if string is null/empty/whitespace else same string.
        /// </summary>
        public static string OrEmpty(this string s)
        {
            return s.Or("");
        }
    }
}
