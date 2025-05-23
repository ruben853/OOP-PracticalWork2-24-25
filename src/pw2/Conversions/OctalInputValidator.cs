using System;

namespace practicalwork2.Conversion{
    public class OctalInputValidator : InputValidator{
        public override void Validate(string input){
            for(int i = 0; i < input.Length; i++){
                char c = input[i];

                bool isDigit = c >= '0' && c <= '7';
                if(!isDigit){
                    throw new FormatException("Bad format");
                }
            }    
        }
    }
}