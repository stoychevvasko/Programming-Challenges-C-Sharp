////-----------------------------------------------------------------------
//// <copyright file="Startup.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace StringExtensions
{
    /// <summary>
    /// Program entry.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            string[] strings = { "abracadabra", "abcdefghijklmnopqrstuvwxyz", "0123456789" };
            foreach (var item in strings)
            {
                System.Console.WriteLine("{0} - reversed: {1}", item, StringExtensions.ReverseString(item));
            }
        }
    }
}
