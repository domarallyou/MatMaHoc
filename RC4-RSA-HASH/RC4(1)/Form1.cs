using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace RC4_1_
{
    public partial class Form1 : Form
    {
        RSA rsa=new RSA();
        HashSHA256 HashSHA256 = new HashSHA256();
        RC4 RC4 = new RC4();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_N.ReadOnly = true;
            tb_PhiN.ReadOnly = true; 
    

        }


        private void mh_button_Click_1(object sender, EventArgs e)
        {
            RC4 rc4 = new RC4();
            RSA rsa = new RSA();

            string Plaintext = textBox2.Text.Trim();
            string Key = textBox1.Text.Trim();
            string CipherText = rc4.mahoaRC4(Plaintext, Key);

            textBox3.Text = CipherText.ToString();



        }

        private void GM_button_Click_1(object sender, EventArgs e)
        {
            RC4 rc4 = new RC4();
            string Plaintext = textBox2.Text.Trim();
            string Key = textBox1.Text.Trim();
            string CipherText = rc4.giaimaRC4(Plaintext, Key);

            string hexString = CipherText.ToString();
            byte[] bytes = Enumerable.Range(0, hexString.Length)
                 .Where(x => x % 2 == 0)
                 .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                 .ToArray(); // chuyển chuỗi hex sang mảng byte

            string result = Encoding.ASCII.GetString(bytes);
            textBox3.Text = result;


        }

        private void tb_sont1_TextChanged(object sender, EventArgs e)
        {
            if (tb_sont1.Text.Trim() != "")
            {
                long a = Convert.ToInt64(tb_sont1.Text.Trim());
                long b = Convert.ToInt64(tb_sont2.Text.Trim());
                tb_N.Text = (a * b).ToString();
                tb_PhiN.Text = ((a - 1) * (b - 1)).ToString();

            }
            else
            {
                tb_N.Text = "";
                tb_PhiN.Text = "";

            }
        }

        private void tb_sont2_TextChanged(object sender, EventArgs e)
        {
            if (tb_sont2.Text.Trim() != "")
            {
                long a = Convert.ToInt64(tb_sont1.Text.Trim());
                long b = Convert.ToInt64(tb_sont2.Text.Trim());
                tb_N.Text = (a * b).ToString();
                tb_PhiN.Text = ((a-1) * (b-1)).ToString();
            }
            else
            {
                tb_N.Text = "";
                tb_PhiN.Text = "";
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            long a = Convert.ToInt64(tb_sont1.Text.Trim());
            long b = Convert.ToInt64(tb_sont2.Text.Trim());
            List<long> Ciphertext = new List<long>();

            Ciphertext=rsa.MaHoaRSA(tb_PlaintextRSA.Text.Trim(), a, b);

            tb_KCK.Text = (a*b).ToString() +","+ Ciphertext[0].ToString();
            tb_KBM.Text = (a*b).ToString()+","+ Ciphertext[1].ToString();
            tb_CPtext.Text= Ciphertext[2].ToString();

        }

        private void bt_GiaiMa_Click(object sender, EventArgs e)
        {
            long a = Convert.ToInt64(tb_GMN.Text.Trim());
            long b = Convert.ToInt64(tb_GMD.Text.Trim());
            List<long> Plaintext = new List<long>();
            Plaintext = rsa.GiaiMa(tb_CPGM.Text.Trim(), b, a);
            tb_GiaiMa.Text = Plaintext[0].ToString();
        }

        private void bt_dangky_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new FileStream(@"C:\\Users\\PC\\OneDrive\\Máy tính\\test.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);

            string user = RC4.mahoaRC4(tb_user.Text.Trim(),"user");
            string pass = HashSHA256.ComputeSha256Hash(tb_pass.Text.Trim());
            sw.WriteLine(user);
            sw.WriteLine( pass );

            sw.Flush(); 
            sw.Close();
            fs.Close();
            



        }

        private void bt_dangnhap_Click(object sender, EventArgs e)
        {
            string fs = @"C:\\Users\\PC\\OneDrive\\Máy tính\\test.txt";
            using (StreamReader sr = new StreamReader(fs))
            {
                string line = RC4.mahoaRC4(tb_dnuser.Text.Trim(), "user");
                string dem;
                while ((dem = sr.ReadLine()) != null)
                {
                    if (dem == line)
                    {
                        Console.WriteLine(dem);

                        tb_hash2.Text = sr.ReadLine();
                        break;

                    }
                  

                }
                
            }


            


        }
    }
}
