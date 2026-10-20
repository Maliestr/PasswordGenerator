using System.Globalization;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace security_lab2
{
    public partial class Form1 : Form
    {
        private static readonly Regex regP = new Regex(@"^(0[.]\d{0,9}|[01]|0[.])?$", RegexOptions.Compiled);
        private static readonly Regex regV = new Regex(@"^([1-9][0-9]{0,9})?$", RegexOptions.Compiled);
        private static readonly Regex regT = new Regex(@"^([1-9][0-9]{0,3})?$", RegexOptions.Compiled);

        private static readonly string l_cap = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static readonly string l_sm = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string r_cap = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private static readonly string r_sm = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private static readonly string symb = "!@#$%^&*()-_=+[]{};:'\",.<>/?\\|`~";
        private static readonly string numb = "0123456789";

        Generation main = new Generation();

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

        public Form1()
        {
            InitializeComponent();

            lat_CAP.CheckedChanged += (s, e) => UpdateAlphabet();
            lat_small.CheckedChanged += (s, e) => UpdateAlphabet();
            rus_CAP.CheckedChanged += (s, e) => UpdateAlphabet();
            rus_small.CheckedChanged += (s, e) => UpdateAlphabet();
            symbols.CheckedChanged += (s, e) => UpdateAlphabet();
            numbers.CheckedChanged += (s, e) => UpdateAlphabet();
        }

        private void p_print_TextChanged(object sender, EventArgs e) => Recalc();
        private void v_print_TextChanged(object sender, EventArgs e) => Recalc();
        private void t_print_TextChanged(object sender, EventArgs e) => Recalc();

        private void p_print_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!regP.IsMatch(p_print.Text + e.KeyChar)) e.Handled = true;
        }

        private void v_print_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!regV.IsMatch(v_print.Text + e.KeyChar)) e.Handled = true;
        }

        private void t_print_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!regT.IsMatch(t_print.Text + e.KeyChar)) e.Handled = true;
        }

        private void UpdateAlphabet()
        {
            int a = 0;
            main.alph = "";

            if (lat_CAP.Checked)
            {
                a += 26;
                main.alph += l_cap;
            }
            if (lat_small.Checked)
            {
                a += 26;
                main.alph += l_sm;
            }
            if (rus_CAP.Checked)
            {
                a += 33;
                main.alph += r_cap;
            }

            if (rus_small.Checked)
            {
                a += 33;
                main.alph += r_sm;
            }

            if (symbols.Checked)
            {
                a += 33;
                main.alph += symb;
            }

            if (numbers.Checked)
            {
                a += 10;
                main.alph += numb;
            }

            main.a = a;
            a_print.Text = a.ToString();
            Recalc();
        }

        private void Recalc()
        {
            if (double.TryParse(p_print.Text, NumberStyles.Float,
                                CultureInfo.InvariantCulture, out double p)) main.p = p;
            else main.p = 0;
            if (int.TryParse(v_print.Text, out int v)) main.v = v; else main.v = 0;
            if (int.TryParse(t_print.Text, out int t)) main.t = t; else main.t = 0;

            s_print.Text = main.p > 0 ? main.CalcS().ToString("N0") : "0";
            l_print.Text = main.a > 0 & main.p > 0 & main.v > 0 & main.t > 0 ? main.CalcL().ToString() : "0";
        }

        private void generation_Click(object sender, EventArgs e)
        {
            if (main.alph == "")
            {
                MessageBox.Show("Выберите мощность алфавита!");
                return;
            }
            if (main.l == 0)
            {
                MessageBox.Show("Введите P, V, T!");
                return;
            }
                var chars = new char[main.l];
            for (int i = 0; i < main.l; i++)
                chars[i] = main.alph[RandomNumberGenerator.GetInt32(main.alph.Length)];
            password_print.Text = new string(chars);
        }
    }
}