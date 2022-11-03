using System;
using System.Reflection.Metadata.Ecma335;

namespace ConverToHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string str = Console.ReadLine();
           Console.WriteLine(ConverToHex(str));
        }
        public static string ConverToHex(string str)
        {
            byte[] hex = System.Text.Encoding.ASCII.GetBytes(str);
            string hexStr = BitConverter.ToString(hex, 0, hex.Length).Replace("-", " ").ToLower();
            return hexStr;
        }
    }
}
