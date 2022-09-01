using DevExpress.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Sanmark.ERP.WinUI.Core
{
    public static class GenericExtensions
    {
        public static List<string> ReverseStringFormat(this string @string, string template)
        {
            // create matches list
            List<string> matches = null;

            // replace slashes
            template = Regex.Replace(template, @"[\\\^\$\.\|\?\*\+\(\)]", p => "\\" + p.Value);

            // replace index numbers
            var pattern = "^" + Regex.Replace(template, @"\{[0-9]+\}", "(.*?)") + "$";

            // get matches
            var match = new Regex(pattern).Match(@string);

            // if there is not any match, return null matches
            if (match.Groups.Count <= 0) return matches;

            // set list
            matches = new List<string>();

            // loop with match count
            for (var i = 1; i < match.Groups.Count; i++)
            {
                // add to matches list
                matches.Add(match.Groups[i].Value);
            }

            return matches;
        }
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static UnmanagedMemoryStream GetResourceStream(string resName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var strResources = assembly.GetName().Name + ".resources";
            var stream = assembly.GetManifestResourceStream(resName);

            if (stream == null)
            {
                throw new FileNotFoundException("Cannot find mappings file.", resName);
            }
            //var rStream = assembly.GetManifestResourceStream(strResources);
            //var resourceReader = new System.Resources.ResourceReader(rStream);
            //var items = resourceReader.OfType<System.Collections.DictionaryEntry>();
           // var stream = items.First(x => (x.Key as string) == resName.ToLower()).Value;
            return (UnmanagedMemoryStream)stream;
        }
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>
    (this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (!seenKeys.Contains(keySelector(element)))
                {
                    seenKeys.Add(keySelector(element));
                    yield return element;
                }
            }
        }
        public static void AutoSize(this SplitContainerControl sc, double oran = 0.5)
        {
            sc.SizeChanged += SplitterSizeChanged;
            SetSplitterPosition(sc, oran);
        }
        private static void SplitterSizeChanged(object sender, EventArgs e)
        {
            SetSplitterPosition(sender as SplitContainerControl);
        }
        private static void SetSplitterPosition(SplitContainerControl sc, double oran = 0.5)
        {
            sc.SplitterPosition = Convert.ToInt32((sc.Horizontal ? sc.Width : sc.Height) * oran);
        }
        public static string ToStr(this object value)
        {
            string result = "";

            if (value != null)
                if (value != DBNull.Value)
                    result = value.ToString().Trim();

            return result;
        }
        public static bool IsNumeric(this object s)
        {
            float output;
            return float.TryParse(s.ToStr(), out output);
        }
        public static decimal ToDecimal(this object value, decimal ExceptionalReturnValue = 0)
        {
            decimal result = ExceptionalReturnValue;

            if (value != null)
                if (value != DBNull.Value)
                    if (value.ToString() != "")
                        try
                        {
                            result = Convert.ToDecimal(value, CultureInfo.CurrentCulture);

                            //CultureInfo ci = new CultureInfo("en-US");
                            //result = Convert.ToDecimal(value, ci);
                        }
                        catch
                        {

                        }

            return result;
        }
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }
        /// <summary>
        /// Bu fonksyion, aldığı object türünde veriyi integer a çevirir. Çeviremediği durumlarda ExceptionalReturnValue olarak geçilen parametreyi döndürür.
        /// </summary>
        /// <param name="value">Oject türünde herhangi bir parametre. Null ya da DBNull.Value da olabilir.</param>
        /// <returns>Integer a dönüştürülmüş hali ya da hata durumunda ExceptionalReturnValue</returns>
        public static int ToInt(this object value, int ExceptionalReturnValue = 0)
        {
            int result = ExceptionalReturnValue;

            if (value != null)
                if (value != DBNull.Value)
                    if (value.ToString() != "")
                        try
                        {
                            result = Convert.ToInt32(value);
                        }
                        catch
                        {
                        }

            return result;
        }
        public static object ToIntDBNull(this object value)
        {
            if (value != null)
                if (value != DBNull.Value)
                    if (value.ToString() != "")
                        try
                        {
                            int result = Convert.ToInt32(value);
                            return result;
                        }
                        catch
                        {
                        }

            return DBNull.Value;
        }
        public static long ToBigInt(this object value, long ExceptionalReturnValue = 0)
        {
            long result = ExceptionalReturnValue;

            if (value != null)
                if (value != DBNull.Value)
                    if (value.ToString() != "")
                        try
                        {
                            result = Convert.ToInt64(value);
                        }
                        catch
                        {
                        }

            return result;
        }
        public static DateTime ToDate(this object value)
        {
            DateTime result = new DateTime(2020, 1, 1);

            if (value != null)
                if (value != DBNull.Value)
                    DateTime.TryParse(value.ToString(), out result);

            return result;
        }
        public static bool ToBool(this DefaultBoolean value)
        {
            return value == DefaultBoolean.True;
        }
        public static bool ToBool(this object value)
        {
            bool result = false;

            if (value != null)
                if (value != DBNull.Value)
                    if (value.ToString() != "")
                        try
                        {
                            result = Convert.ToBoolean(value);
                        }
                        catch
                        {
                        }
            return result;
        }
        public static DefaultBoolean Toggle(this DefaultBoolean value)
        {

            if (value == DefaultBoolean.True)
                return DefaultBoolean.False;
            else if (value == DefaultBoolean.False)
                return DefaultBoolean.True;
            else //TODO : bu kısım sorun çıkarabilir
                return DefaultBoolean.Default;
        }
        public static string RemoveIfEndsWith(this string source, string stringToRemove)
        {
            if (source.EndsWith(stringToRemove))
                source = source.Substring(0, source.Length - stringToRemove.Length);

            return source;
        }
        public static string RemoveBetween(this string source, char begin, char end)
        {
            Regex regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
            return regex.Replace(source, string.Empty);
        }

        public static string ToUnsecureString(this SecureString secureString)
        {
            if (secureString == null) throw new ArgumentNullException("secureString");

            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        public static SecureString ToSecureString(this string unsecureString)
        {
            if (unsecureString == null) throw new ArgumentNullException("unsecureString");

            return unsecureString.Aggregate(new SecureString(), AppendChar, MakeReadOnly);
        }

        private static SecureString MakeReadOnly(SecureString ss)
        {
            ss.MakeReadOnly();
            return ss;
        }

        private static SecureString AppendChar(SecureString ss, char c)
        {
            ss.AppendChar(c);
            return ss;
        }
        //public static string UnWrap(this SecureString value)
        //{
        //    if (value == null) throw new ArgumentNullException("value");
        //    IntPtr ptr = Marshal.SecureStringToCoTaskMemUnicode(value);
        //    try
        //    {
        //        return Marshal.PtrToStringUni(ptr);
        //    }
        //    finally
        //    {
        //        Marshal.ZeroFreeCoTaskMemUnicode(ptr);
        //    }
        //}
        //public static SecureString ToSecureString(this string source)
        //{
        //    if (string.IsNullOrWhiteSpace(source))
        //        return null;
        //    else
        //    {
        //        SecureString result = new SecureString();
        //        foreach (char c in source.ToCharArray())
        //            result.AppendChar(c);
        //        return result;
        //    }
        //}
        //public static SecureString ToSecureString(this IEnumerable value)
        //{
        //    if (value == null) throw new ArgumentNullException("value");
        //    var secured = new SecureString();

        //    var charArray = value.ToString().ToArray();
        //    for (int i = 0; i < charArray.Length; i++)
        //    {
        //        secured.AppendChar(charArray[i]);
        //    }

        //    secured.MakeReadOnly();
        //    return secured;
        //}
        public static string Encrypt(this SecureString value)
        {

            if (value == null) throw new ArgumentNullException("value");

            IntPtr ptr = Marshal.SecureStringToCoTaskMemUnicode(value);
            try
            {
                char[] buffer = new char[value.Length];
                Marshal.Copy(ptr, buffer, 0, value.Length);

                byte[] data = Encoding.Unicode.GetBytes(buffer);
                byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.LocalMachine);

                return Convert.ToBase64String(encrypted);
            }
            finally
            {
                Marshal.ZeroFreeCoTaskMemUnicode(ptr);
            }
        }

        public static SecureString DecryptSecure(this string encryptedText)
        {
            if (encryptedText == null) throw new ArgumentNullException("encryptedText");

            byte[] data = Convert.FromBase64String(encryptedText);
            byte[] decrypted = ProtectedData.Unprotect(data, null, DataProtectionScope.LocalMachine);

            SecureString ss = new SecureString();

            int count = Encoding.Unicode.GetCharCount(decrypted);
            int bc = decrypted.Length / count;
            for (int i = 0; i < count; i++)
            {
                ss.AppendChar(Encoding.Unicode.GetChars(decrypted, i * bc, bc)[0]);
            }

            ss.MakeReadOnly();
            return ss;
        }
    }
}
