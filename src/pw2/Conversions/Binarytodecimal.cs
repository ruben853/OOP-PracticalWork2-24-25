using System;

namespace practicalwork2.Conversion{
    public class Binarytodecimal : Conversion{
        public Binarytodecimal(string name, string definition) : base(name, definition, new BinaryInputValidator()) {}

        public override string Change(string input)
        {
            string binaryString = input.ToString();
            int decimalValue = 0;
            int length = binaryString.Length;

            for (int i = 0; i < length; i++)
            {
                int bit = binaryString[i] - '0'; 
                decimalValue += bit * (int)Math.Pow(2, length - i - 1);
            }

            return decimalValue.ToString();
        }
    }
}
