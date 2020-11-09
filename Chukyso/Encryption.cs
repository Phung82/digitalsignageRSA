using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Chukyso
{
    public partial class Encryption_form : Form
    {
        public Encryption_form()
        {
            InitializeComponent();
        }
        public class BitConverter
        {
            static public string EncodeTo64(string toEncode)
            {
                byte[] toEncodeAsBytes
                      = System.Text.ASCIIEncoding.ASCII.GetBytes(toEncode);
                string returnValue
                      = System.Convert.ToBase64String(toEncodeAsBytes);
                return returnValue;
            }
            static public string DecodeFrom64(string encodedData)
            {
                byte[] encodedDataAsBytes
                    = System.Convert.FromBase64String(encodedData);
                string returnValue =
                   System.Text.ASCIIEncoding.ASCII.GetString(encodedDataAsBytes);
                return returnValue;
            }

            static public byte[] GetBytes(string s)
            {
                return Convert.FromBase64String(EncodeTo64(s));
            }

            static public string GetString(byte[] b)
            {
                return DecodeFrom64(Convert.ToBase64String(b));
            }


        }
        private void Encryption_Load(object sender, EventArgs e)
        {

        }

        private void SplitString(String str)
        {
            //str = "các hàm xử lý chuỗi, xử lý chuỗi trong c#";
            //string[] arrListStr = str.Split("\\");//tách trong chuỗi str trên khi gặp ký tự '/'

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Doc_Name;

                Doc_Name = dlg.FileName;
                MessageBox.Show(Doc_Name);
                lb_DocName.Text = Doc_Name;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string Sign_Name;

                Sign_Name = dlg.FileName;
                MessageBox.Show(Sign_Name);
                //lb_DocName.Text = Sign_Name;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string data = txt_plainText.ToString();
            string data = "SmallBird so handsome";
            byte[] binaryData = BitConverter.GetBytes(data);

            //密钥对生成：private key: rsa.ToXmlString(true),  public key rsa.ToXmlString(false);
            //加密用公钥
            RSACryptoServiceProvider rsaPublic = new RSACryptoServiceProvider();
            //rsaPublic.FromXmlString("<RSAKeyValue><Modulus>wRF/xutZI+fDG+2381DXXYmcGPdc1QHv7ymVGcAT+YHyjXAdlJlODGhsNT3TRuVc6XTInKblPflPTWt90SQ2llOZuFQyBo6McqZh1yKpquDzhPxMrFeX/hERYMYFapNATvKC+D61/4KCET9UFIJ37X3TYJ5xduo6r66M46DZ9uE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
            rsaPublic.FromXmlString("<RSAKeyValue><Modulus>ylCO9dE9aFMK6brxSrJCDwfPMDSd/Q/44s5TsUnRFvkvt+VQgnMSdJBEBd6JCKsXl1n9kUjbmGRwmqMbFzfyUE10Ne1QF3Z66RfiMoTPpyuHjoAY1iASDiiA2nEpZeL+MVxrHpFVuuoMumwacZMLI6zmWbL+T741V64UIvStdU0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
            var encryptedBinary = rsaPublic.Encrypt(binaryData, true);
            string result = (new UTF8Encoding(false)).GetString(encryptedBinary);
            lb_ma.Text = result;
        }
    }



    /*
    public static class RSA
    {
        /// <summary>
        /// The padding scheme often used together with RSA encryption.
        /// </summary>
        private static bool _optimalAsymmetricEncryptionPadding = false;

        /// <summary>
        /// Converts the RSA-encrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted text</returns>
        public static string Encrypt(string text, string publicKeyXml, int keySize)
        {
            var encrypted = EncryptByteArray(Encoding.UTF8.GetBytes(text), publicKeyXml, keySize);

            return Convert.ToBase64String(encrypted);
        }

        /// <summary>
        /// Gets and validates the RSA-encrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-encrypted byte array</returns>
        private static byte[] EncryptByteArray(byte[] data, string publicKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            int maxLength = GetMaxDataLength(keySize);

            if (data.Length > maxLength)
            {
                throw new ArgumentException(String.Format("Maximum data length is {0}", maxLength), "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (String.IsNullOrEmpty(publicKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicKeyXml);
                return provider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        /// <summary>
        /// Converts the RSA-decrypted text into a string
        /// </summary>
        /// <param name="text">The plain text input</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted text</returns>
        public static string Decrypt(string text, string publicAndPrivateKeyXml, int keySize)
        {
            var decrypted = DecryptByteArray(Convert.FromBase64String(text), publicAndPrivateKeyXml, keySize);
            return Encoding.UTF8.GetString(decrypted);
        }

        /// <summary>
        /// Gets and validates the RSA-decrypted text as a byte array
        /// </summary>
        /// <param name="data">The plain text in byte array format</param>
        /// <param name="publicKeyXml">The RSA public key in XML format</param>
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The the RSA-decrypted byte array</returns>
        private static byte[] DecryptByteArray(byte[] data, string publicAndPrivateKeyXml, int keySize)
        {
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data are empty", "data");
            }

            if (!IsKeySizeValid(keySize))
            {
                throw new ArgumentException("Key size is not valid", "keySize");
            }

            if (String.IsNullOrEmpty(publicAndPrivateKeyXml))
            {
                throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
            }

            using (var provider = new RSACryptoServiceProvider(keySize))
            {
                provider.FromXmlString(publicAndPrivateKeyXml);
                return provider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
            }
        }

        /// <summary>
        /// Gets the maximum data length for a given key
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>The maximum allowable data length</returns>
        public static int GetMaxDataLength(int keySize)
        {
            if (_optimalAsymmetricEncryptionPadding)
            {
                return ((keySize - 384) / 8) + 7;
            }
            return ((keySize - 384) / 8) + 37;
        }

        /// <summary>
        /// Checks if the given key size if valid
        /// </summary>       
        /// <param name="keySize">The RSA key length</param>
        /// <returns>True if valid; false otherwise</returns>
        public static bool IsKeySizeValid(int keySize)
        {
            return keySize >= 384 &&
                   keySize <= 16384 &&
                   keySize % 8 == 0;
        }
    }
    */
}
