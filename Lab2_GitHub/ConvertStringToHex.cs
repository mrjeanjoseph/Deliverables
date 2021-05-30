using System;
using System.Text;

class ConvertStringToHex
{
    static void StringToHexaCaller()
    {
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            string someString = StringToHexa(Console.ReadLine());
            Console.WriteLine(someString);
        }
    }
    static string StringToHexa(string input)
    {
        string output = string.Empty;
        char[] value = input.ToCharArray();
        foreach (char a in value)
        {
            int b = Convert.ToInt32(a);
            output += string.Format("{0:x}", b);
        }
        return output;
    }
    public static string ConvertStringToHexa(String input, Encoding encoding)
    {
        {
            Byte[] stringBytes = encoding.GetBytes(input);
            StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
            foreach (byte b in stringBytes)
            {
                sbBytes.AppendFormat("{0:X2}", b);
            }
            //Console.WriteLine(sbBytes.ToString());
            sbBytes.ToString();
            return sbBytes.ToString();
        }
        // Find more information about encoding and how to this peice of the code.
    }


    public static string ConvertHexToString(String hexInput, Encoding encoding)
    {
        int numberChars = hexInput.Length;
        byte[] bytes = new byte[numberChars / 2];
        for (int i = 0; i < numberChars; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hexInput.Substring(i, 2), 16);
        }
        return encoding.GetString(bytes);
    }
}