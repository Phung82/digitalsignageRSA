using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chukyso
{
    public partial class GenerateRSAKey_form : Form
    {
        public GenerateRSAKey_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GenerateRSAKey_form_Load(object sender, EventArgs e)
        {

        }

        public static void GKEY()
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                string publicKey = rsa.ToXmlString(false);
                string privateKey = rsa.ToXmlString(true);
            }
        }

        private void btn_CreateRSA_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            using (StreamWriter writer = new StreamWriter(txt_privateName.Text+"_Privatekey.txt")) 
            {
                txt_privateShow.Text = rsa.ToXmlString(true);
                writer.Write(txt_privateShow.Text);
                writer.Close();

            }
            using (StreamWriter writer = new StreamWriter(txt_publicName.Text+"_PublicKey.txt"))
            {
                txt_publicShow.Text = rsa.ToXmlString(true);
                writer.Write(txt_publicShow.Text);
                writer.Close();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_publicShow.SelectionLength > 0)
            {
                txt_publicShow.Copy();
            }
        }

        private void btn_privateCopy_Click(object sender, EventArgs e)
        {
            if (txt_privateShow.SelectionLength > 0)
            {
                txt_privateShow.Copy();
            }
        }
    }
}
