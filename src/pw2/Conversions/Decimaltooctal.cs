using System;

namespace practicalwork2.Conversion{
    public class Decimaltooctal : Conversion{
        public Decimaltooctal(string name, string definition) : base(name, definition, new DecimalInputValidator()){}

        public override string Change(string input){
            int number = Int32.Parse(input);
            if(number == 0) return "0";

            string octalString = "";

            while(number > 0){
                int remainder = number % 8;
                octalString = remainder + octalString;
                number /= 8;
            }

            return octalString;
        }
    }
}
