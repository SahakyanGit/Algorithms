﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Strings.StringBuilderExtensions
{
    /// <summary>
    /// Extenstion methods for StringBuilder
    /// </summary>
    static class StringBuilderExtensions
    {
        /// <summary>Retrieves a substring from this instance. The substring starts at a specified character position.</summary>
        /// <returns>A StringBuilder instance.</returns>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
        public static StringBuilder Substring(this StringBuilder builder, int startIndex)
        {
            StringBuilder subBuilder = new StringBuilder();

            int subIndex = 0;
            for (int i = startIndex; i < builder.Length; i++)
            {
                subBuilder.Append(builder[startIndex]);
            }
            return subBuilder;
        }

        /// <summary>Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.</summary>
        /// <returns>A StringBuilder instance.</returns>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance. </param>
        /// <param name="length">The number of characters in the substring.</param>
        public static StringBuilder Substring(this StringBuilder builder, int startIndex, int length)
        {
            StringBuilder subBuilder = new StringBuilder();
            int index = 0;
            while (index < length)
            {
                subBuilder.Append(builder[startIndex++]);
                index++;
            }
            return subBuilder;
        }
    }
}
