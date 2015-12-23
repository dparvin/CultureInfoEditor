using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CultureInfoEditor.Interfaces
{
    /// <summary>
    ///
    /// </summary>
    class RegionInfoInterface
    {
        /// <summary>
        /// Gets or sets the name, in English, of the currency used in the
        /// country/region represented by the current CultureAndRegionInfoBuilder
        /// object.
        /// </summary>
        public string CurrencyEnglishName { get; set; }
        /// <summary>
        /// Gets or sets the native name of the currency used in the country/region
        /// represented by the current CultureAndRegionInfoBuilder object.
        /// </summary>
        public string CurrencyNativeName { get; set; }
        /// <summary>
        /// Gets or sets the string to use as the currency symbol.
        /// </summary>
        /// <value>
        /// The string to use as the currency symbol. The default for
        /// System.Globalization.NumberFormatInfo.InvariantInfo is "¤".
        /// </value>
        /// <exception cref="System.ArgumentNullException">
        /// The property is being set to null.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo object is read-only.
        /// </exception>
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// Gets or sets the full name of the country/region in the language of the localized version of .NET Framework.
        /// </summary>
        [Description("Gets or sets the full name of the country/region in the language of the localized version of .NET Framework.")]
        public string DisplayName { get; set; }
        /// <summary>
        /// Gets or sets the full name of the country/region in English.
        /// </summary>
        [Description("Gets or sets the full name of the country/region in English.")]
        public string EnglishName { get; set; }
        /// <summary>
        /// Gets or sets a unique identification number for a geographical
        /// region, country, city, or location.
        /// </summary>
        public Int32 GeoId { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the country/region
        /// uses the metric system for measurements.
        /// </summary>
        public bool IsMetric { get; set; }
        /// <summary>
        /// Gets or sets the three-character ISO 4217 currency symbol
        /// associated with the country/region.
        /// </summary>
        public string ISOCurrencySymbol { get; set; }
        /// <summary>
        /// Gets the name of the country/region for the current RegionInfo object.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the full name of the country/region as known by the
        /// people of this custom culture.
        /// </summary>
        public string NativeName { get; set; }
        /// <summary>
        /// Gets or sets the three-letter code defined in ISO 3166 for the
        /// country/region.
        /// </summary>
        public string ThreeLetterISORegionName { get; set; }
        /// <summary>
        /// Gets or sets the three-letter code assigned by Windows to the
        /// country/region represented by the current custom culture.
        /// </summary>
        public string ThreeLetterWindowsRegionName { get; set; }
        /// <summary>
        /// Gets or sets the two-letter code defined in ISO 3166 for the
        /// country/region.
        /// </summary>
        public string TwoLetterISORegionName { get; set; }
    }
}
