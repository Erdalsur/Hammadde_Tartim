using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Sanmark.Core.Utilities.Yazici
{
    public class RawPrinterHelper
    {
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool StartDocPrinter(
          IntPtr hPrinter,
          int level,
          [MarshalAs(UnmanagedType.LPStruct), In] RawPrinterHelper.DOCINFOA di);

        [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        public static extern bool WritePrinter(
          IntPtr hPrinter,
          IntPtr pBytes,
          int dwCount,
          out int dwWritten);

        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
        {
            int dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            RawPrinterHelper.DOCINFOA di = new RawPrinterHelper.DOCINFOA();
            bool flag = false;
            di.pDocName = "Sanmark ERP (Barkod)";
            di.pDataType = "RAW";
            if (RawPrinterHelper.OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                if (RawPrinterHelper.StartDocPrinter(hPrinter, 1, di))
                {
                    if (RawPrinterHelper.StartPagePrinter(hPrinter))
                    {
                        flag = RawPrinterHelper.WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        RawPrinterHelper.EndPagePrinter(hPrinter);
                    }
                    RawPrinterHelper.EndDocPrinter(hPrinter);
                }
                RawPrinterHelper.ClosePrinter(hPrinter);
            }
            if (!flag)
                Marshal.GetLastWin32Error();
            return flag;
        }

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            bool flag = false;
            try
            {
                FileStream fileStream = new FileStream(szFileName, FileMode.Open);
                BinaryReader binaryReader = new BinaryReader((Stream)fileStream);
                byte[] numArray = new byte[fileStream.Length];
                IntPtr num1 = new IntPtr(0);
                int int32 = Convert.ToInt32(fileStream.Length);
                byte[] source = binaryReader.ReadBytes(int32);
                IntPtr num2 = Marshal.AllocCoTaskMem(int32);
                Marshal.Copy(source, 0, num2, int32);
                flag = RawPrinterHelper.SendBytesToPrinter(szPrinterName, num2, int32);
                Marshal.FreeCoTaskMem(num2);
                fileStream.Close();
            }
            catch (Exception ex)
            {
            }
            return flag;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            int length = szString.Length;
            IntPtr coTaskMemAnsi = Marshal.StringToCoTaskMemAnsi(szString);
            RawPrinterHelper.SendBytesToPrinter(szPrinterName, coTaskMemAnsi, length);
            Marshal.FreeCoTaskMem(coTaskMemAnsi);
            return true;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
    }
}
