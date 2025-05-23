using System;

namespace practicalwork2.Conversion
{
    public class Hexadecimaltodecimal : Conversion{
        public Hexadecimaltodecimal(string name, string definition) : base(name, definition, new HexadecimalInputValidator()){

        }

        public override string Change(string input)
        {
            int decimalValue = 0;
            int length = input.Length;

            for(int i = 0; i < length; i++){
                char digitalChar = input[i];
                int digit;

                if(char.IsDigit(digitalChar)){
                    digit = digitalChar;
                }
                else{
                    digit = char.ToUpper(digitalChar) - 'A' + 10;
                }

                int power = length - i - 1;
                decimalValue += digit * (int)Math.Pow(16, power);
            }
            return decimalValue.ToString();
        }
    }
}