using System.Numerics;
using System.Text;

namespace IT_Lab4;

public partial class Form1 : Form
{
    private byte[] plainBytes;
    private string filePath;
    private string plainText;

    private BigInteger q;
    private BigInteger p;
    private BigInteger h;
    private BigInteger x;
    private BigInteger k;
    private BigInteger g;
    private BigInteger y;
    
    public Form1()
    {
        InitializeComponent();
    }
    
    private string GetMistake()
    {
        string errorText = "";

        if (filePath == null)
        {
            errorText += "Откройте файл!";
            return errorText;
        }
        
        if (!BigInteger.TryParse(pTextBox.Text, out BigInteger p) || !BigInteger.TryParse(qTextBox.Text, out BigInteger q) || !BigInteger.TryParse(hTextBox.Text, out BigInteger h) || !BigInteger.TryParse(xTextBox.Text, out BigInteger x) || !BigInteger.TryParse(kTextBox.Text, out BigInteger k) || p < 1 || q < 1 || h < 1 || x < 1 || k < 1)
        {
            errorText += "Числа не натуральные!";
            return errorText;
        }

        if (!DSA.IsPrime(p))
        {
            errorText += "Число p составное!" + Environment.NewLine;
        }
        if ((p-1) % q != 0)
        {
            errorText += "Число q должно быть делителем числа (p-1)!" + Environment.NewLine;
        }
        if (!DSA.IsPrime(q))
        {
            errorText += "Число q составное!" + Environment.NewLine;
        }
        if (h <= 1 || h >= (p-1))
        {
            errorText += "Число h должно быть в интервале (1, p-1)!" + Environment.NewLine;
        }
        if (x <= 0 || x >= q)
        {
            errorText += "Число x должно быть в интервале (0, q)!" + Environment.NewLine;
        }
        if (k <= 0 || k >= q)
        {
            errorText += "Число k должно быть в интервале (0, q)!" + Environment.NewLine;
        }

        g = DSA.FastPow(h, ((p - 1) / q), p);
        if (g <= 1)
        {
            errorText += "Не выполняется условие g > 1, где g = h^((p-1)/q) mod p" + Environment.NewLine;
        }
        return errorText;
    }


    private void SignButtonClick(object sender, EventArgs e)
    {
        string errorText = GetMistake();

        if (errorText != "")
        {
            MessageBox.Show(errorText, "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        q = BigInteger.Parse(qTextBox.Text);
        p = BigInteger.Parse(pTextBox.Text);
        x = BigInteger.Parse(xTextBox.Text);
        k = BigInteger.Parse(kTextBox.Text);
        BigInteger r, s;
        (h, r, s)= DSA.GetSignature(plainBytes, q, p, x, k, g);

        if (r == 0 || s == 0)
        {
            MessageBox.Show("Выберите другое k, т.к. r = 0 или s = 0");
            return;
        }

        HashTextBox.Text = h.ToString();
        SignTextBox.Text = "r = " + r.ToString() + ' ' + "s = " + s.ToString();
        
        plainText += ' ' + r.ToString() + ' ' + s.ToString();
        ContentTextBox.Text = plainText;
        
        System.IO.File.WriteAllText(filePath, plainText);
    }


    private void OpenFileClick(object sender, EventArgs e)
    {
        if (OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            return;

        filePath = OpenFileDialog.FileName;
        plainText = System.IO.File.ReadAllText(filePath);
        ContentTextBox.Text = plainText;

        plainBytes = System.IO.File.ReadAllBytes(filePath);
    }

    private void CheckButtonClick(object sender, EventArgs e)
    {
        string errorText = GetMistake();

        if (errorText != "")
        {
            MessageBox.Show(errorText, "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        string[] words = plainText.TrimEnd().Split(' ');
        
        if (!BigInteger.TryParse(words[words.Length - 2], out BigInteger _r) ||
            !BigInteger.TryParse(words[words.Length - 1], out BigInteger _s))
        {
            MessageBox.Show("Файл не подписан!");
            return;
        }
        
        int len = words[words.Length - 1].Length + words[words.Length - 2].Length + 2;

        string text = plainText.TrimEnd().Substring(0, plainText.Length - len);

        byte[] data = Encoding.UTF8.GetBytes(text);

        BigInteger _h = DSA.GetHash(data, q);

        y = DSA.FastPow(g, x, p);
        
        BigInteger w = DSA.FastPow(_s, q - 2, q);
        BigInteger u1 = (_h * w) % q;
        BigInteger u2 = (_r * w) % q;
        BigInteger v = DSA.FastPow(g, u1, p) * DSA.FastPow(y, u2, p) % p % q;
        
        //BigInteger s = ((_h + x * _r) / k) % q;

        string result = "h = " + _h.ToString() + Environment.NewLine +
                        "r = " + _r.ToString() + Environment.NewLine +
                        "v = " + v.ToString();
        
        if (v == _r)
        {
            MessageBox.Show("Подпись подлинна");
        }
        else
        {
            MessageBox.Show("Подпись не подлинна");
        }

        MessageBox.Show(result);
    }
}