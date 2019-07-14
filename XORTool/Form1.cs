using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace XORTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void grpBoxInput_Enter(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            byte[] output;
            
            if (radBtnText.Checked)
            {
                string text = System.String.Empty;                
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(txtBoxInput.Text);
                List<byte> byteList = bytes.ToList();
                byteList.Add((byte)0);
                bytes = byteList.ToArray();
                setOutputBoxText(Bitwise.bitwiseOp(bytes, Bitwise.stringToHexValues(txtBoxKey.Text.Replace(" ", "")), "xor"));                 
                //rTxtBoxOutput.Text = Bitwise.bytesToHexString(Bitwise.stringToHexValues(txtBoxKey.Text));
            }
            else if (radBtnHex.Checked)
            {
                string text = System.String.Empty;
                txtBoxInput.Text = txtBoxInput.Text.Replace("\\x", "");
                txtBoxKey.Text = txtBoxKey.Text.Replace("\\x", "");
                byte[] input_array = Bitwise.stringToHexValues(txtBoxInput.Text.Replace(" ", ""));
                byte[] output_array = Bitwise.bitwiseOp(input_array, Bitwise.stringToHexValues(txtBoxKey.Text.Replace(" ", "")), "xor");
                setOutputBoxText(output_array);
                //rTxtBoxOutput.Text = Bitwise.bytesToHexString(Bitwise.stringToHexValues(txtBoxKey.Text));
            }
        }

        private void setOutputBoxText(byte[] output)
        {
            string text = System.String.Empty;            
            txtBoxHex.Text = Bitwise.bytesToHexString(output);
            txtBoxHexEsc.Text = Bitwise.bytesToHexEscString(output);
            txtBoxString.Text = System.Text.Encoding.ASCII.GetString(output);

            text = txtBoxInput.Text;
            
            text = text.Replace(" ", "_");
            text = text.Replace("\n", "");
            text = text.Replace("\t", "");
            text = text.Replace("\r", "");
            text = text.Replace(".", "");
            text = text.Replace(",", "");
            text = text.Replace("[", "");
            text = text.Replace("]", "");
            text = text.Replace("(", "");
            text = text.Replace(")", "");
            text = text.Replace("=", "");
            text = text.Replace("+", "");
            text = text.Replace(">", "");
            text = text.Replace("<", "");
            text = text.Replace("?", "");
            int ostr_len = text.Length;
            if (ostr_len > 14)
            {
                ostr_len = 14;
            }
            text = "const char* OS_" + text.Substring(0, ostr_len) + " = " + "\"" + txtBoxHexEsc.Text + "\"" + "; // " + txtBoxInput.Text;
            rTxtBoxOutput.Text = text;
            Clipboard.SetText(text);
            
        }
    }
}
