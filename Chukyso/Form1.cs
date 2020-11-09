using Libs;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Chukyso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //SHA256 dùng thư viện Cryptography
        static string GetSHA256Hash(SHA256 sha256Hash, string input)
        {

            // Chuyển chuỗi đầu vào thành một mảng byte và tính toán băm.
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Tạo một Stringbuilder mới để thu thập các byte
            // và tạo một chuỗi.
            StringBuilder sBuilder = new StringBuilder();

            // Lặp lại từng byte dữ liệu đã băm
            // và định dạng từng cái dưới dạng chuỗi thập lục phân.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Trả về chuỗi 16
            return sBuilder.ToString();
        }
        private void toolToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Hàm tạo chữ ký điện tử
        public static string SignData(string message, string privateKey)
        {
            //// Mảng lưu trữ thông báo đã ký theo byte
            byte[] signedBytes;
            using (var rsa = new RSACryptoServiceProvider())
            {
                //// Viết thông báo vào một mảng byte sử dụng UTF8 làm mã hóa.
                var encoder = new UTF8Encoding();
                byte[] originalData = encoder.GetBytes(message);

                try
                {
                    //// Nhập khóa cá nhân được sử dụng để ký tin nhắn
                    rsa.FromXmlString(privateKey);

                    //// Ký dữ liệu, sử dụng SHA256 làm thuật toán băm
                    signedBytes = rsa.SignData(originalData, CryptoConfig.MapNameToOID("SHA256"));
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                finally
                {
                    //// Đặt keycontainer được xóa khi rsa được thu thập rác.
                    rsa.PersistKeyInCsp = false;
                }
            }
            //// Chuyển đổi chuỗi base64 trước khi trả về
            return Convert.ToBase64String(signedBytes);
        }

        //Hàm kiểm tra chữ ký điện tử
        public static bool VerifyData(string originalMessage, string signedMessage, string publicKey)
        {
            bool success = false;
            using (var rsa = new RSACryptoServiceProvider())
            {
                var encoder = new UTF8Encoding();
                byte[] bytesToVerify = encoder.GetBytes(originalMessage);

                byte[] signedBytes = Convert.FromBase64String(signedMessage);
                try
                {
                    rsa.FromXmlString(publicKey);

                    SHA256Managed Hash = new SHA256Managed();

                    byte[] hashedData = Hash.ComputeHash(signedBytes);

                    success = rsa.VerifyData(bytesToVerify, CryptoConfig.MapNameToOID("SHA256"), signedBytes);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
            return success;
        }
        private void rSAEncryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Encryption_form encryption_Form = new Encryption_form();
            encryption_Form.ShowDialog();

        }

        private void generateRSAKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateRSAKey_form generateRSAKey_Form = new GenerateRSAKey_form();
            generateRSAKey_Form.ShowDialog();
        }

        private void rSADecryptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //-------------
        string VB_can_ky = "";
        string Encryp_file = "";
        string Private_key = "";
        string VB_Test = "";
        string sign_test = "";
        string Public_key = "";
        string Inputfile, File_sign;

        private void btn_chonVB_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.AddExtension = true;
            ofd.CheckFileExists = true;
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd.InitialDirectory = "./PlainText";
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            ofd.Title = "Chọn VB cần ký";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;
            VB_can_ky = ofd.FileName;

            Inputfile = System.IO.Path.GetFileName(ofd.FileName);
        }
        private void btn_chonPrivate_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd_pr = new OpenFileDialog();
            ofd_pr.AddExtension = true;
            ofd_pr.CheckFileExists = true;
            ofd_pr.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd_pr.InitialDirectory = "./KEY";
            ofd_pr.Multiselect = false;
            ofd_pr.RestoreDirectory = true;
            ofd_pr.Title = "Chọn File Private Key";
            if (ofd_pr.ShowDialog() != DialogResult.OK)
                return;
            Private_key = ofd_pr.FileName;
        }
        private void btn_Encryp_Click(object sender, EventArgs e)
        {
            txt_showCode.Text = SignData(libs.ReadTextFile(VB_can_ky) + "\n----" + txt_sign.Text + "----", libs.ReadTextFile(Private_key));
        }

        private void btn_chonPublic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_pub = new OpenFileDialog();
            ofd_pub.AddExtension = true;
            ofd_pub.CheckFileExists = true;
            ofd_pub.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //ofd_pub.InitialDirectory = @"C:\Users\SB\Desktop\";
            ofd_pub.Multiselect = false;
            ofd_pub.RestoreDirectory = true;
            ofd_pub.Title = "Chọn file Public Key";
            if (ofd_pub.ShowDialog() != DialogResult.OK)
                return;
            Public_key = ofd_pub.FileName;
        }

        private void btn_KTra_Click(object sender, EventArgs e)
        {

            if (VerifyData(VB_Test, sign_test, libs.ReadTextFile(Public_key)))
            {

                lb_thongbao.Text = "Chữ ký điện tử hợp lệ!!! ";
                txt_showVB.Text = VB_Test;
            }

            else
            {

                lb_thongbao.Text = " LỖI: Văn bản không hợp lệ ";

            }

        }

        private void btn_VBTest_Click(object sender, EventArgs e)
        {

            string[] lines;

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;

                fileName = dlg.FileName;
                lines = File.ReadAllLines(fileName);
                VB_Test = lines[0] + "\n" + lines[1];
                sign_test = lines[2];
            }
        }

        private void btn_chuky_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd_signTest = new OpenFileDialog();
            ofd_signTest.AddExtension = true;
            ofd_signTest.CheckFileExists = true;
            ofd_signTest.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofd_signTest.InitialDirectory = File_sign;
            ofd_signTest.Multiselect = false;
            ofd_signTest.RestoreDirectory = true;
            ofd_signTest.Title = "Chọn file .txt chữ ký: ";

            if (ofd_signTest.ShowDialog() != DialogResult.OK)
                return;




        }

        private void btn_luu_Click_1(object sender, EventArgs e)
        {

            string fileLPath = VB_can_ky + ".sig";


            string[] lines = new string[2];
            lines[0] = libs.ReadTextFile(VB_can_ky) + "\n----" + txt_sign.Text + "----";
            lines[1] = txt_showCode.Text;

            File.WriteAllLines(fileLPath, lines);
            MessageBox.Show("Đã Lưu !");

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {

        }


    }
}
