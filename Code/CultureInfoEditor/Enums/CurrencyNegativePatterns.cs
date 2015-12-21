using CultureInfoEditor.Attributes;

namespace CultureInfoEditor.Enums
{
    /// <summary>
    /// The format pattern for negative currency values. The default for
    /// System.Globalization.NumberFormatInfo.InvariantInfo is 0, which
    /// represents "($n)", where "$" is
    /// the System.Globalization.NumberFormatInfo.CurrencySymbol and n is a
    /// number.
    /// </summary>
    /// <remarks>
    /// p = parenthesis
    /// c = currency symbol
    /// s = sign
    /// n = number
    /// _ = space
    /// </remarks>
    public enum CurrencyNegativePatterns
    {
        /// <summary>
        /// ($n)
        /// </summary>
        [EnumText("($n)")]
        pcnp = 0,
        /// <summary>
        /// -$n
        /// </summary>
        [EnumText("-$n")]
        scn = 1,
        /// <summary>
        /// $-n
        /// </summary>
        [EnumText("$-n")]
        csn = 2,
        /// <summary>
        /// $n-
        /// </summary>
        [EnumText("$n-")]
        cns = 3,
        /// <summary>
        /// (n$)
        /// </summary>
        [EnumText("(n$)")]
        pncp = 4,
        /// <summary>
        /// -n$
        /// </summary>
        [EnumText("-n$")]
        snc = 5,
        /// <summary>
        /// n-$
        /// </summary>
        [EnumText("n-$")]
        nsc = 6,
        /// <summary>
        /// n$-
        /// </summary>
        [EnumText("n$-")]
        ncs = 7,
        /// <summary>
        /// -n $
        /// </summary>
        [EnumText("-n $")]
        sn_c = 8,
        /// <summary>
        /// -$ n
        /// </summary>
        [EnumText("-$ n")]
        sc_n = 9,
        /// <summary>
        /// n $-
        /// </summary>
        [EnumText("n $-")]
        n_cs = 10,
        /// <summary>
        /// $ n-
        /// </summary>
        [EnumText("$ n-")]
        c_ns = 11,
        /// <summary>
        /// $ -n
        /// </summary>
        [EnumText("$ -n")]
        c_sn = 12,
        /// <summary>
        /// n- $
        /// </summary>
        [EnumText("n- $")]
        ns_c = 13,
        /// <summary>
        /// ($ n)
        /// </summary>
        [EnumText("($ n)")]
        pc_np = 14,
        /// <summary>
        /// (n $)
        /// </summary>
        [EnumText("(n $)")]
        pn_cp = 15
    }
}
