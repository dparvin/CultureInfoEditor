﻿using System;

namespace CultureInfoEditor.Attributes
{
    /// <summary>
    /// apply text to an Enum for use in a property page
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public sealed class EnumTextAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnumTextAttribute"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public EnumTextAttribute(string text)
        {
            EnumText = text;
        }

        /// <summary>
        /// Gets the Enum text.
        /// </summary>
        /// <value>
        /// The Enum text.
        /// </value>
        public string EnumText { get; private set; }
    }
}