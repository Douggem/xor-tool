using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace XORTool
{
    class Bitwise
    {
        public static byte[] bitwiseOp(string inputString, byte[] key, String op)
        {
            byte[] input = Encoding.ASCII.GetBytes(Encoding.ASCII.GetString(Encoding.Unicode.GetBytes(inputString)));
            int inputLength = input.Length;
            int keyLength = key.Length;
            byte[] returnArray = new byte[inputLength];
            for (int i = 0; i < input.Length; i++)
            {
                returnArray[i] = doOp(input[i], key[i % key.Length], op);
            }

            return returnArray;
        }
        public static byte[] bitwiseOp(byte[] input, byte[] key, String op)
        {
            int inputLength = input.Length;
            int keyLength = key.Length;
            byte[] returnArray = new byte[inputLength];
            if (key.Length <= 0) return input;
            for (int i = 0; i < input.Length; i++)
            {
                Debug.WriteLine("i = " + i + " key Length = " + key.Length + "input[i] = " + input[i] + " key[i%lenght] = " + key[i%key.Length]);
                returnArray[i] = doOp(input[i], key[i % key.Length], op);                
            }

            return returnArray;
        }

        protected static byte doOp(byte input, byte key, String op)
        {
            switch (op)
            {                
                case "and":
                    return (byte)(input & key);
                case "or":
                    return (byte)(input | key);
                default:
                    return (byte)(input ^ key);
            }            
        }

        public static string bytesToHexEscString(byte[] input)
        {
            string output = "\\x";
            output += BitConverter.ToString(input);
            return output.Replace("-", "\\x");
        }

        public static string bytesToHexString(byte[] input)
        {
            string output = "";
            output += BitConverter.ToString(input);
            return output.Replace("-", "  ");
        }

        public static byte[] stringToHexValues(string input)
        {
            input.Replace("\\x", " ");
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] returnBytes = new byte[bytes.Length / 2];            
            for(int i = 0; i < bytes.Length; i++)
            {
                byte b = bytes[i];
                if(b >= 48 && b <= 57) bytes[i] = (byte)(b - 48);
                else if(b >= 65 && b <= 70) bytes[i] = (byte)(b - 55);
                else if(b >= 97 && b <= 102) bytes[i] = (byte)(b - 87);
            }

            for (int i = 0; i < bytes.Length/2; i++)
            {
                returnBytes[i] = (byte)(bytes[i*2] * 0x10 + bytes[i*2 + 1]);
            }
            return returnBytes;
        }
    }
}
