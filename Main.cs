using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LetsHash
{
    public partial class Main : Form
    {
        public Main()
        {
            Methods methods = new Methods();
            Frames frames = new Frames();
            InitializeComponent();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_input.Text))
            {
                MessageBox.Show("Input field is empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);  
            }         
            if (rb_base64.Checked == true && rb_cod.Checked == true)
            {
                tb_output.Text = Methods.GetBase64(tb_input.Text); ;
            }
            if (rb_base64.Checked == true && rb_enc.Checked == true)
            {
                tb_output.Text = Methods.GetTextFromBase64(tb_input.Text);
            }
            if (rb_md5.Checked == true)
            {
                tb_output.Text = Methods.MD5(tb_input.Text);
            }
            if (rb_sha1.Checked == true)
            {
                tb_output.Text = Methods.SHA1(tb_input.Text);
            }
            if (rb_sha256.Checked == true)
            {
                tb_output.Text = Methods.SHA256(tb_input.Text);
            }
            if (rb_sha384.Checked == true)
            {
                tb_output.Text = Methods.SHA384(tb_input.Text);
            }
            if (rb_sha512.Checked == true)
            {
                tb_output.Text = Methods.SHA512(tb_input.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Frames.AboutWindow();
        }

        private void rb_base64_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_base64.Checked == true)
            {
                rb_enc.Enabled = true;
            }
            else
            {
                rb_enc.Enabled = false;
            }
        }
    }
}
