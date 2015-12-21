using CultureInfoEditor.Converters;
using CultureInfoEditor.Enums;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;

namespace CultureInfoEditor.Interfaces
{
    class NumberFormatInfoInterface
    {
        /// <summary>
        /// Gets or sets the number of decimal places to use in currency values.
        /// </summary>
        /// <value>
        /// The number of decimal places to use in currency values. The default
        /// for System.Globalization.NumberFormatInfo.InvariantInfo is 2.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The property is being set to a value that is less than 0 or greater than 99.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        [Description("Gets or sets the number of decimal places to use in currency values.")]
        public int CurrencyDecimalDigits { get; set; }
        /// <summary>
        /// Gets or sets the string to use as the decimal separator in currency values.
        /// </summary>
        /// <value>
        /// The string to use as the decimal separator in currency values. The default for System.Globalization.NumberFormatInfo.InvariantInfo is ".".
        /// </value>
        /// <exception cref="System.ArgumentNullException">
        /// The property is being set to null.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// The property is being set to an empty string.
        /// </exception>
        [Description("Gets or sets the string to use as the decimal separator in currency values.")]
        public string CurrencyDecimalSeparator { get; set; }
        /// <summary>
        /// Gets or sets the string that separates groups of digits to the left
        /// of the decimal in currency values.
        /// </summary>
        /// <value>
        /// The string that separates groups of digits to the left of the
        /// decimal in currency values. The default for
        /// System.Globalization.NumberFormatInfo.InvariantInfo is ",".
        /// </value>
        /// <exception cref="System.ArgumentNullException">
        /// The property is being set to null.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        [Description("Gets or sets the string that separates groups of digits to the left of the decimal in currency values.")]
        public string CurrencyGroupSeparator { get; set; }
        /// <summary>
        /// Gets or sets the number of digits in each group to the left of the decimal in currency values.
        /// </summary>
        /// <value>
        /// The number of digits in each group to the left of the decimal in
        /// currency values. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        /// is a one-dimensional array with only one element, which is set to 3.
        /// </value>
        /// <exception cref="System.ArgumentNullException">
        /// The property is being set to null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// The property is being set and the array contains an entry that is
        /// less than 0 or greater than 9.-or- The property is being set and the
        /// array contains an entry, other than the last entry, that is set to 0.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        [Description("Gets or sets the number of digits in each group to the left of the decimal in currency values.")]
        public int[] CurrencyGroupSizes { get; set; }
        /// <summary>
        /// Gets or sets the format pattern for negative currency values.
        /// </summary>
        /// <value>
        /// The format pattern for negative currency values. The default for System.Globalization.NumberFormatInfo.InvariantInfo is 0, which represents "($n)", where "$" is the System.Globalization.NumberFormatInfo.CurrencySymbol and n is a number.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The property is being set to a value that is less than 0 or greater than 15.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo object is read-only.
        /// </exception>
        [Description("Gets or sets the format pattern for negative currency values.")]
        [TypeConverter(typeof(EnumDescriptionConverter))]
        [DefaultValue(CurrencyNegativePatterns.pcnp)]
        public CurrencyNegativePatterns CurrencyNegativePattern { get; set; }
        /// <summary>
        /// Gets or sets the format pattern for positive currency values.
        /// </summary>
        /// <value>
        /// The format pattern for positive currency values. The default for
        /// System.Globalization.NumberFormatInfo.InvariantInfo is 0, which
        /// represents "$n", where "$" is the System.Globalization.NumberFormatInfo.CurrencySymbol
        /// and n is a number.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The property is being set to a value that is less than 0 or greater
        /// than 3.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        [Description("Gets or sets the format pattern for positive currency values.")]
        [TypeConverter(typeof(EnumDescriptionConverter))]
        [DefaultValue(CurrencyPositivePatterns.cn)]
        public CurrencyPositivePatterns CurrencyPositivePattern { get; set; }
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
        /// Gets or sets a value that specifies how the graphical user interface
        /// displays the shape of a digit.
        /// </summary>
        /// <value>
        /// One of the enumeration values that specifies the culture-specific
        /// digit shape.
        /// </value>
        /// <exception cref="System.InvalidOperationException">
        /// The current System.Globalization.NumberFormatInfo object is read-only.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// The value in a set operation is not a valid
        /// System.Globalization.DigitShapes value.
        /// </exception>
        [ComVisible(false)]
        public DigitShapes DigitSubstitution { get; set; }
        /// <summary>
        /// Gets a value that indicates whether this System.Globalization.NumberFormatInfo object is read-only.
        /// </summary>
        /// <value>
        /// <c>true</c> if the System.Globalization.NumberFormatInfo is read-only; otherwise, <c>false</c>.
        /// </value>
        public bool IsReadOnly { get; }
        /// <summary>
        /// Gets or sets the string that represents the IEEE NaN (not a number)
        /// value.
        /// </summary>
        /// <value>
        /// The string that represents the IEEE NaN (not a number) value. The
        /// default for System.Globalization.NumberFormatInfo.InvariantInfo is
        /// "NaN".
        /// </value>
        /// <exception cref="System.ArgumentNullException">
        /// The property is being set to null.
        /// </exception>
        /// <exception cref="System.InvalidOperationException">
        /// The property is being set and the System.Globalization.NumberFormatInfo
        /// object is read-only.
        /// </exception>
        public string NaNSymbol { get; set; }
        ///<summary>
        /// Gets or sets a string array of native digits equivalent to the
        /// Western digits 0 through 9.
        /// </summary>
        /// <value>
        /// A string array that contains the native equivalent of the Western
        /// digits 0 through 9. The default is an array having the elements "0",
        /// "1", "2", "3", "4", "5", "6", "7", "8", and "9".
        /// </value>
        /// <exception cref="System.InvalidOperationException">
        /// The current System.Globalization.NumberFormatInfo object is read-only.
        /// </exception>
        /// <exception cref="">
        /// In a set operation, the value is null.-or-In a set operation, an
        /// element of the value array is null.
        /// </exception>
        /// <exception cref="System.ArgumentException">
        /// In a set operation, the value array does not contain 10 elements.
        /// -or- In a set operation, an element of the value array does not
        /// contain either a single System.Char object or a pair of System.Char
        /// objects that comprise a surrogate pair.-or-In a set operation, an
        /// element of the value array is not a number digit as defined by the
        /// Unicode Standard. That is, the digit in the array element does not
        /// have the Unicode Number, Decimal Digit (Nd) General Category value.
        /// -or-In a set operation, the numeric value of an element in the value
        /// array does not correspond to the element's position in the array.
        /// That is, the element at index 0, which is the first element of the
        /// array, does not have a numeric value of 0, or the element at index 1
        /// does not have a numeric value of 1.
        /// </exception>
        [ComVisible(false)]
        public string[] NativeDigits { get; set; }
        //
        // Summary:
        //     Gets or sets the string that represents negative infinity.
        //
        // Returns:
        //     The string that represents negative infinity. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is "-Infinity".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string NegativeInfinitySymbol { get; set; }
        //
        // Summary:
        //     Gets or sets the string that denotes that the associated number is negative.
        //
        // Returns:
        //     The string that denotes that the associated number is negative. The default for
        //     System.Globalization.NumberFormatInfo.InvariantInfo is "-".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string NegativeSign { get; set; }
        //
        // Summary:
        //     Gets or sets the number of decimal places to use in numeric values.
        //
        // Returns:
        //     The number of decimal places to use in numeric values. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is 2.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property is being set to a value that is less than 0 or greater than 99.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int NumberDecimalDigits { get; set; }
        //
        // Summary:
        //     Gets or sets the string to use as the decimal separator in numeric values.
        //
        // Returns:
        //     The string to use as the decimal separator in numeric values. The default for
        //     System.Globalization.NumberFormatInfo.InvariantInfo is ".".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        //
        //   T:System.ArgumentException:
        //     The property is being set to an empty string.
        public string NumberDecimalSeparator { get; set; }
        //
        // Summary:
        //     Gets or sets the string that separates groups of digits to the left of the decimal
        //     in numeric values.
        //
        // Returns:
        //     The string that separates groups of digits to the left of the decimal in numeric
        //     values. The default for System.Globalization.NumberFormatInfo.InvariantInfo is
        //     ",".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string NumberGroupSeparator { get; set; }
        //
        // Summary:
        //     Gets or sets the number of digits in each group to the left of the decimal in
        //     numeric values.
        //
        // Returns:
        //     The number of digits in each group to the left of the decimal in numeric values.
        //     The default for System.Globalization.NumberFormatInfo.InvariantInfo is a one-dimensional
        //     array with only one element, which is set to 3.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.ArgumentException:
        //     The property is being set and the array contains an entry that is less than 0
        //     or greater than 9.-or- The property is being set and the array contains an entry,
        //     other than the last entry, that is set to 0.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int[] NumberGroupSizes { get; set; }
        //
        // Summary:
        //     Gets or sets the format pattern for negative numeric values.
        //
        // Returns:
        //     The format pattern for negative numeric values.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property is being set to a value that is less than 0 or greater than 4.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int NumberNegativePattern { get; set; }
        //
        // Summary:
        //     Gets or sets the number of decimal places to use in percent values.
        //
        // Returns:
        //     The number of decimal places to use in percent values. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is 2.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property is being set to a value that is less than 0 or greater than 99.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int PercentDecimalDigits { get; set; }
        //
        // Summary:
        //     Gets or sets the string to use as the decimal separator in percent values.
        //
        // Returns:
        //     The string to use as the decimal separator in percent values. The default for
        //     System.Globalization.NumberFormatInfo.InvariantInfo is ".".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        //
        //   T:System.ArgumentException:
        //     The property is being set to an empty string.
        public string PercentDecimalSeparator { get; set; }
        //
        // Summary:
        //     Gets or sets the string that separates groups of digits to the left of the decimal
        //     in percent values.
        //
        // Returns:
        //     The string that separates groups of digits to the left of the decimal in percent
        //     values. The default for System.Globalization.NumberFormatInfo.InvariantInfo is
        //     ",".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string PercentGroupSeparator { get; set; }
        //
        // Summary:
        //     Gets or sets the number of digits in each group to the left of the decimal in
        //     percent values.
        //
        // Returns:
        //     The number of digits in each group to the left of the decimal in percent values.
        //     The default for System.Globalization.NumberFormatInfo.InvariantInfo is a one-dimensional
        //     array with only one element, which is set to 3.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.ArgumentException:
        //     The property is being set and the array contains an entry that is less than 0
        //     or greater than 9.-or- The property is being set and the array contains an entry,
        //     other than the last entry, that is set to 0.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int[] PercentGroupSizes { get; set; }
        //
        // Summary:
        //     Gets or sets the format pattern for negative percent values.
        //
        // Returns:
        //     The format pattern for negative percent values. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is 0, which represents "-n %", where "%" is the System.Globalization.NumberFormatInfo.PercentSymbol
        //     and n is a number.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property is being set to a value that is less than 0 or greater than 11.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int PercentNegativePattern { get; set; }
        //
        // Summary:
        //     Gets or sets the format pattern for positive percent values.
        //
        // Returns:
        //     The format pattern for positive percent values. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is 0, which represents "n %", where "%" is the System.Globalization.NumberFormatInfo.PercentSymbol
        //     and n is a number.
        //
        // Exceptions:
        //   T:System.ArgumentOutOfRangeException:
        //     The property is being set to a value that is less than 0 or greater than 3.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public int PercentPositivePattern { get; set; }
        //
        // Summary:
        //     Gets or sets the string to use as the percent symbol.
        //
        // Returns:
        //     The string to use as the percent symbol. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is "%".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string PercentSymbol { get; set; }
        //
        // Summary:
        //     Gets or sets the string to use as the per mille symbol.
        //
        // Returns:
        //     The string to use as the per mille symbol. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is "‰", which is the Unicode character U+2030.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string PerMilleSymbol { get; set; }
        //
        // Summary:
        //     Gets or sets the string that represents positive infinity.
        //
        // Returns:
        //     The string that represents positive infinity. The default for System.Globalization.NumberFormatInfo.InvariantInfo
        //     is "Infinity".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The property is being set to null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string PositiveInfinitySymbol { get; set; }
        //
        // Summary:
        //     Gets or sets the string that denotes that the associated number is positive.
        //
        // Returns:
        //     The string that denotes that the associated number is positive. The default for
        //     System.Globalization.NumberFormatInfo.InvariantInfo is "+".
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     In a set operation, the value to be assigned is null.
        //
        //   T:System.InvalidOperationException:
        //     The property is being set and the System.Globalization.NumberFormatInfo object
        //     is read-only.
        public string PositiveSign { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return "Open the tree to see the settings for this property";
        }
    }
}
