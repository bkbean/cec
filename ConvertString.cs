using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CEC
{
    internal class ConvertString
    {
        [DllImport("kernel32.dll", EntryPoint = "LCMapStringA")]
        private static extern int LCMapString(int Locale, int dwMapFlags, byte[] lpSrcStr, int cchSrc, byte[] lpDestStr, int cchDest);

        private const int LCMAP_SIMPLIFIED_CHINESE = 0x02000000;
        private const int LCMAP_TRADITIONAL_CHINESE = 0x04000000;

        private static Encoding GB2312 = Encoding.GetEncoding(936);
        private static Encoding BIG5 = Encoding.GetEncoding(950);

        public static string Big5ToGb2312S(string strBig5)
        {
            byte[] src = BIG5.GetBytes(strBig5);
            byte[] dest = new byte[src.Length];

            byte[] gb2312 = Encoding.Convert(BIG5, GB2312, src);
            LCMapString(0x0804, LCMAP_SIMPLIFIED_CHINESE, gb2312, -1, dest, src.Length);

            return GB2312.GetString(dest);
        }

        public static string Gb2312SToBig5(string strGb2312)
        {
            byte[] src = GB2312.GetBytes(strGb2312);
            byte[] dest = new byte[src.Length];

            LCMapString(0x0804, LCMAP_TRADITIONAL_CHINESE, src, -1, dest, src.Length);
            byte[] big5 = Encoding.Convert(GB2312, BIG5, dest);

            return BIG5.GetString(big5);
        }
    }
}
