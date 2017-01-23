////-----------------------------------------------------------------------
//// <copyright file="StringExtensions.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace StringExtensions
{
    using System.Text;

    /// <summary>
    /// Provides extended functionality for strings.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Reverses a string.
        /// </summary>
        /// <param name="str">A string value.</param>
        /// <returns>The string in reversed order (backwards).</returns>
        public static string ReverseString(string str)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                builder.Insert(0, str[i]);
            }

            return builder.ToString();
        }
    }
}
