using CultureInfoEditor.Attributes;

namespace CultureInfoEditor.Enums
{
    /// <summary>
    /// The format pattern for positive currency values. The default for
    /// System.Globalization.NumberFormatInfo.InvariantInfo is 0, which
    /// represents "$n", where "$" is the System.Globalization.NumberFormatInfo.CurrencySymbol
    /// and n is a number.
    /// </summary>
    /// <remarks>
    /// c = currency symbol
    /// n = number
    /// _ = space
    /// </remarks>
    public enum CurrencyPositivePatterns
    {
        /// <summary>
        /// $n
        /// </summary>
        [EnumText("$n")]
        cn = 0,
        /// <summary>
        /// n$
        /// </summary>
        [EnumText("n$")]
        nc = 1,
        /// <summary>
        /// $ n
        /// </summary>
        [EnumText("$ n")]
        c_n = 2,
        /// <summary>
        /// n $
        /// </summary>
        [EnumText("n $")]
        n_c = 3
    }
}
