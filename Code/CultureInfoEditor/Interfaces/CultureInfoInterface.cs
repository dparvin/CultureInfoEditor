using CultureInfoEditor.Converters;
using CultureInfoEditor.UIEditors;
using System;
using System.ComponentModel;
using System.Globalization;

namespace CultureInfoEditor.Interfaces
{
    /// <summary>
    /// CultureInfo Interface class
    /// </summary>
    class CultureInfoInterface
    {
        ///// <summary>
        ///// Gets or sets an array of calendars that are supported by this
        ///// CultureAndRegionInfoBuilder object.
        ///// </summary>
        //public Calendar[] AvailableCalendars { get; set; }
        ///// <summary>
        ///// Gets or sets the CompareInfo object that defines how to compare
        ///// strings for the culture.
        ///// </summary>
        //public CompareInfo CompareInfo { get; set; }
        ///// <summary>
        ///// Gets or sets an alternate user interface culture suitable for
        ///// console applications when the default graphic user interface
        ///// culture is inappropriate.
        ///// </summary>
        //public CultureInfo ConsoleFallbackUICulture { get; set; }
        /// <summary>
        /// Gets the CultureTypes value that describes the culture represented
        /// by the current CultureAndRegionInfoBuilder object.
        /// </summary>
        [Editor(typeof(FlagEnumUIEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public Enums.CultureTypes CultureTypes { get; set; }
        /// <summary>
        /// Gets or sets a DateTimeFormatInfo that defines the culturally
        /// appropriate format of displaying dates and times.
        /// </summary>
        public DateTimeFormatInfo DateTimeFormat { get; set; }
        /// <summary>
        /// Gets or sets the full localized culture name.
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the culture name in English.
        /// </summary>
        public string EnglishName { get; set; }
        /// <summary>
        /// Gets or sets a culture name formatted according to the RFC 4646
        /// standard, "Tags for the Identification of Languages."
        /// </summary>
        public string IetfLanguageTag { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the current CultureInfo
        /// represents a neutral culture.
        /// </summary>
        public bool IsNeutralCulture { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the current CultureInfo
        /// is read-only.
        /// </summary>
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Gets or sets the active input locale identifier.
        /// </summary>
        [Description("Gets or sets the active input locale identifier.")]
        public Int32 KeyboardLayoutId { get; set; }
        /// <summary>
        /// Gets the culture identifier for the current CultureAndRegionInfoBuilder object.
        /// </summary>
        [Description("Gets the culture identifier for the current CultureAndRegionInfoBuilder object.")]
        public Int32 LCID { get; set; }
        /// <summary>
        /// Gets the name of the culture being created.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the culture name in the format and language that the
        /// culture is set to display.
        /// </summary>
        public string NativeName { get; set; }
        /// <summary>
        /// Gets or sets a NumberFormatInfo object that defines the culturally
        /// appropriate format of displaying numbers, currency, and percentage.
        /// </summary>
        [TypeConverter(typeof(TypeConverter<NumberFormatInfoInterface>))]
        [Description("Gets or sets a NumberFormatInfo object that defines the culturally appropriate format of displaying numbers, currency, and percentage.")]
        public NumberFormatInfoInterface NumberFormat { get; set; }
        /// <summary>
        /// Gets or sets a DateTimeFormatInfo object that defines the format
        /// of dates and times according to the Gregorian calendar.
        /// </summary>
        public DateTimeFormatInfo GregorianDateTimeFormat { get; set; }
        /// <summary>
        /// Gets or sets the predominant direction of lines of text in the
        /// writing system associated with the current CultureAndRegionInfoBuilder object.
        /// </summary>
        public bool IsRightToLeft { get; set; }
        /// <summary>
        /// Gets or sets the CultureInfo object that represents the parent
        /// culture of the current custom culture.
        /// </summary>
        public CultureInfo Parent { get; set; }
        /// <summary>
        /// Gets or sets the region information.
        /// </summary>
        /// <value>
        /// The region information.
        /// </value>
        [TypeConverter(typeof(TypeConverter<RegionInfoInterface>))]
        [Description("Gets or sets the TextInfo object that defines the writing system associated with this custom culture.")]
        public RegionInfoInterface RegionInfo { get; set; }
        /// <summary>
        /// Gets or sets the TextInfo object that defines the writing system
        /// associated with this custom culture.
        /// </summary>
        [TypeConverter(typeof(TypeConverter<TextInfoInterface>))]
        [Description("Gets or sets the TextInfo object that defines the writing system associated with this custom culture.")]
        public TextInfoInterface TextInfo { get; set; }
        /// <summary>
        /// Gets or sets the ISO 639-2 three-letter code for the language of
        /// this custom culture.
        /// </summary>
        public string ThreeLetterISOLanguageName { get; set; }
        /// <summary>
        /// Gets or sets the three-letter code for the language as defined in
        /// the Windows API.
        /// </summary>
        public string ThreeLetterWindowsLanguageName { get; set; }
        /// <summary>
        /// Gets or sets the ISO 639-1 two-letter code for the language of the
        /// current CultureInfo object.
        /// </summary>
        public string TwoLetterISOLanguageName { get; set; }
    }
}
