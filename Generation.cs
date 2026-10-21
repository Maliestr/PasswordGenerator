using System.Text.RegularExpressions;

namespace security_lab2
{
    public class Generation
    {
        public double p = 0;
        public int v = 0, t = 0;
        public ulong sSm = 0, s = 0;
        public int a = 0;
        public int l = 0;
        public string alph = "";

        public ulong CalcS()
        {
            if (p <= 0) return sSm = 0;
            return sSm = (ulong)Math.Ceiling((v * 60 * 24) * t / p);
        }
        public int CalcL()
        {
            if (a <= 0) return l = 0;
            s = (ulong)(t * v * 60 * 24);
            return l = (int)Math.Ceiling(Math.Log(s, a));
        }
    }

    public static class Alphabet
    {
        public static readonly Regex regP = new Regex(@"^(0[.]\d{0,9}|[01]|0[.])?$", RegexOptions.Compiled);
        public static readonly Regex regV = new Regex(@"^([1-9][0-9]{0,9})?$", RegexOptions.Compiled);
        public static readonly Regex regT = new Regex(@"^([1-9][0-9]{0,3})?$", RegexOptions.Compiled);

        public static readonly string l_cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static readonly string l_sm = "abcdefghijklmnopqrstuvwxyz";
        public static readonly string r_cap = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        public static readonly string r_sm = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static readonly string symb = "!@#$%^&*()-_=+[]{};:'\",.<>/?\\|`~";
        public static readonly string numb = "0123456789";
    }
}
