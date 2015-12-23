using System;

namespace CultureInfoEditor.Interfaces
{
    class TextInfoInterface
    {
        /// <summary>
        ///Gets the American National Standards Institute(ANSI) code page used by the writing system represented by the current TextInfo.
        /// </summary>
        public Int32 ANSICodePage { get; set; }
        /// <summary>
        ///Gets the name of the culture associated with the current TextInfo object.
        /// </summary>
        public string CultureName { get; set; }
        /// <summary>
        ///Gets the Extended Binary Coded Decimal Interchange Code (EBCDIC) code page used by the writing system represented by the current TextInfo.
        /// </summary>
        public Int32 EBCDICCodePage { get; set; }
        /// <summary>
        ///Gets a value indicating whether the current TextInfo object is read-only.
        /// </summary>
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the current TextInfo object represents a writing system where text flows from right to left.
        /// </summary>
        public bool IsRightToLeft { get; set; }
        /// <summary>
        ///Gets the culture identifier for the culture associated with the current TextInfo object.
        /// </summary>
        public Int32 LCID { get; set; }
        /// <summary>
        ///Gets or sets the string that separates items in a list.
        /// </summary>
        public string ListSeparator { get; set; }
        /// <summary>
        ///Gets the Macintosh code page used by the writing system represented by the current TextInfo.
        /// </summary>
        public Int32 MacCodePage { get; set; }
        /// <summary>
        ///Gets the original equipment manufacturer (OEM) code page used by the writing system represented by the current TextInfo.
        /// </summary>
        public Int32 OEMCodePage { get; set; }
    }
}
