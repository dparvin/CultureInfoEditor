using CultureInfoEditor.Attributes;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace CultureInfoEditor.Converters
{
    class EnumDescriptionConverter : EnumConverter
        {
            private Type _enumType;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumDescriptionConverter"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public EnumDescriptionConverter(Type type)
                : base(type)
            {
                _enumType = type;
            }

        /// <summary>
        /// Determines whether this instance can convert to the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="destType">Type of the destination.</param>
        /// <returns></returns>
        public override bool CanConvertTo(ITypeDescriptorContext context,
                Type destType)
            {
                return destType == typeof(string);
            }

        /// <summary>
        /// Converts to.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="value">The value.</param>
        /// <param name="destType">Type of the dest.</param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context,
                CultureInfo culture,
                object value, Type destType)
            {
                FieldInfo fi = _enumType.GetField(Enum.GetName(_enumType, value));
                DescriptionAttribute dna =
                    (DescriptionAttribute)Attribute.GetCustomAttribute(
                    fi, typeof(DescriptionAttribute));

                if (dna != null)
                    return dna.Description;
                else
                    return value.ToString();
            }

        /// <summary>
        /// Determines whether this instance can convert from the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="srcType">Type of the source.</param>
        /// <returns></returns>
        public override bool CanConvertFrom(
                ITypeDescriptorContext context,
                Type srcType)
            {
                return srcType == typeof(string);
            }

        /// <summary>
        /// Converts from.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="culture">The culture.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public override object ConvertFrom(
                ITypeDescriptorContext context,
                CultureInfo culture,
                object value)
            {
                foreach (FieldInfo fi in _enumType.GetFields())
                {
                EnumTextAttribute dna =
                        (EnumTextAttribute)Attribute.GetCustomAttribute(
                            fi, typeof(EnumTextAttribute));

                    if ((dna != null) && ((string)value == dna.EnumText))
                        return Enum.Parse(_enumType, fi.Name);
                }
                return Enum.Parse(_enumType, (string)value);
            }
        }
    }
