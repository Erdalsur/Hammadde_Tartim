using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;

namespace Sanmark.Core.Utilities.Tipler
{
    public static class EnumHelper
    {

        public static string GetDescription(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            System.Reflection.FieldInfo fieldInfo = value.GetType().GetField(description);
            DescriptionAttribute[] attributes =
               (DescriptionAttribute[])
             fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                description = attributes[0].Description;
            }
            return description;
        }
        public static string StringValueOf(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
        public static IList ToList(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            ArrayList list = new ArrayList();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }

            return list;
        }
        public static IList ToList2(this Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            List<EnumListesi> list;            
            Array enumValues = Enum.GetValues(type);
            list = new List<EnumListesi>();
            foreach (Enum value in enumValues)
            {
                
                list.Add(new EnumListesi { Key = (int)value.GetInt(), Value = GetDescription(value) });
                //list.Add(new KeyValuePair<Enum, string>(value, GetDescription(value)));
            }

            return list;
        }
        public static string ToDescription(this Enum enumeration)
        {
            var attribute = GetText<DescriptionAttribute>(enumeration);

            return attribute.Description;
        }

        public static T GetText<T>(Enum enumeration) where T : Attribute
        {
            var type = enumeration.GetType();

            var memberInfo = type.GetMember(enumeration.ToString());

            if (!memberInfo.Any())
                throw new ArgumentException($"No public members for the argument '{enumeration}'.");

            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);

            if (attributes == null || attributes.Length != 1)
                throw new ArgumentException($"Can't find an attribute matching '{typeof(T).Name}' for the argument '{enumeration}'");

            return attributes.Single() as T;
        }
        /// <summary>
        /// Enum değerini belirttiğiniz türde alabilirsiniz.
        /// </summary>
        /// <typeparam name="T">
        /// Enum value'sunu hangi türde almak istiyorsanız o türü belirtmelisiniz.
        /// </typeparam>
        /// <example>
        /// var code = HttpStatusCode.Accepted.GetValue<int>()
        /// </example>
        /// <param name="enumVal"></param>
        /// <returns></returns>
        public static T GetValue<T>(this Enum enumVal)
            => (T)Convert.ChangeType(enumVal, typeof(T));

        /// <summary>
        /// Enum elemanının değerini <see cref="int"/> tipinde alabilirsiniz.
        /// </summary>
        /// <param name="enumVal">Enum türü</param>
        /// <returns>Geriye <see cref="int"/> tipinde bir sayı döner.</returns>
        public static int GetInt(this Enum enumVal)
            => enumVal.GetValue<int>();

        /// <summary>
        /// Enum elemanının değerini <see cref="short"/> tipinde alabilirsiniz.
        /// </summary>
        /// <param name="enumVal">Enum türü</param>
        /// <returns>Geriye <see cref="short"/> tipinde bir sayı döner.</returns>
        public static short GetShort(this Enum enumVal)
            => enumVal.GetValue<short>();

        /// <summary>
        /// Enum elemanına tanımlanmış attribute varsa belirttiğiniz türe göre attribute'ü elde etmeyi sağlayabilirsiniz.
        /// </summary>
        /// <typeparam name="T">Enum elemanına tanımlanmış attribute türünü belirtiniz.</typeparam>
        /// <param name="enumVal">Enum türü</param>
        /// <returns>Eğer <see cref="T"/> türündeki attribute enum elemanında varsa <see cref="T"/> türü geri dönderilir.</returns>
        /// <example>string desc = myEnumVariable.GetAttributeOfType<DescriptionAttribute>().Description;</example>
        public static T GetAttributeOfType<T>(this Enum enumVal) where T : System.Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            return (attributes.Length > 0) ? (T)attributes[0] : null;
        }

        /// <summary>
        /// Enum elemanınızda <see cref="DescriptionAttribute"/> tanımlı ise bu attribut'un Description değeri geri dönderilir.
        /// </summary>
        /// <param name="value">Enum türü</param>
        /// <returns>Geriye <see cref="DescriptionAttribute"/> türünün Description özelliği değeri dönderilir.</returns>
        public static string GetDescription2(this Enum value)
        {
            var desc = value.GetAttributeOfType<DescriptionAttribute>();
            if (desc != null)
                return desc.Description;
            return value.ToString();
        }
    }
    /// <summary>
    /// 	Extension methods for byte-Arrays
    /// </summary>
    public static class ByteArrayExtension
    {
        public static byte[] Compress(this byte[] data)
        {
            MemoryStream output = new MemoryStream();
            GZipStream gzip = new GZipStream(output, CompressionMode.Compress, true);
            gzip.Write(data, 0, data.Length);
            gzip.Close();
            return output.ToArray();
        }

        public static byte[] Decompress(this byte[] data)
        {
            MemoryStream input = new MemoryStream();
            input.Write(data, 0, data.Length);
            input.Position = 0;
            GZipStream gzip = new GZipStream(input, CompressionMode.Decompress, true);
            MemoryStream output = new MemoryStream();
            byte[] buff = new byte[64];
            int read = -1;
            read = gzip.Read(buff, 0, buff.Length);
            while (read > 0)
            {
                output.Write(buff, 0, read);
                read = gzip.Read(buff, 0, buff.Length);
            }
            gzip.Close();
            return output.ToArray();
        }
    }
    public static class BooleanExtension
    {
        /// <summary>
        /// C# Boolean değeri javascript boolean değerine çeviren metod.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToJavascript(this bool value)
            => value ? "true" : "false";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool Not(this bool value)
        {
            return value != true;
        }

        /// <summary>
        /// Converts the value of this instance to its equivalent string representation (either "Yes" or "No").
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns>string</returns>
        public static string ToYesNo(this bool boolean)
        {
            return boolean ? "Yes" : "No";
        }

        /// <summary>
        /// Converts the value in number format {1 , 0}.
        /// </summary>
        /// <param name="boolean"></param>
        /// <returns>int</returns>
        /// <example>
        /// 	<code>
        /// 		int result= default(bool).ToBinaryTypeNumber()
        /// 	</code>
        /// </example>
        public static int ToBinaryTypeNumber(this Boolean boolean)
        {
            return boolean ? 1 : 0;
        }
    }
}
