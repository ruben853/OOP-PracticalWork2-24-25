using System;

namespace practicalwork2.Conversion{
    public class DecimalInputValidator : InputValidator{
        public override void Validate(string input){
            for(int i = 0; i < input.Length; i++){
                if(input[i] == '-' && input[i] >0){
                    throw new FormatException("Bad format");
                }
                else if(!char.IsDigit(input[i])){
                    throw new FormatException("Bad format");
                }
            }
        }
    }
}