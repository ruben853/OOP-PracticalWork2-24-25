using System;

namespace practicalwork2.Conversion{
    public class Converter{
        private List<Conversion> operations;

        public Converter(){
            this.operations = new List<Conversion>();

            this.operations.Add(new Decimaltobinary("Binary", "Decimal to binary"));
            this.operations.Add(new Decimaltooctal("Octal", "Decimal to octal"));
            this.operations.Add(new Decimaltohexadecimal("Hexadecimal", "Decimal to hexadecimal"));
            this.operations.Add(new Decimaltotwocomplement("TwoComplement", "Decimal to two complement"));
            this.operations.Add(new Binarytodecimal("Decimal", "Binary to decimal"));
            this.operations.Add(new Twocomplementtodecimal("Decimal", "Binary (2 complement) to decimal"));
            this.operations.Add(new Octaltodecimal("Decimal", "Octal to decimal"));
            this.operations.Add(new Hexadecimaltodecimal("Decimal", "Hexadecimal to decimal"));
        }

        public int Exit(){
            return this.operations.Count + 1;
        }

        public int GetNumberOperations(){
            return this.operations.Count;
        }

        public int PrintOperations(){
            //Console.Clear();
            Console.WriteLine("----------------------------------------");
            for(int i = 1; i <= this.operations.Count; i++){
                Console.WriteLine($" {i}. {this.operations[i-1].GetDefinition()}");
            }
            Console.WriteLine($" {this.Exit()}. Exit");
            Console.WriteLine("----------------------------------------");
            string tmp = Console.ReadLine();
            if(tmp == "") return this.Exit();

            int option = Int32.Parse(tmp);
            return (option < 1 || option > this.GetNumberOperations()) ? this.Exit(): option;
        }

        public string PerformConversion(int op, string input){
            this.operations[op-1].Validate(input);
            if(this.operations[op-1].NeedBitSize()){
                Console.Write("How many bits should I use: ");
                int bits = Int32.Parse(Console.ReadLine());
                return this.operations[op-1].Change(input, bits);
            }
            return this.operations[op-1].Change(input);
        }

        public void PrintConversion(int op, string input, string output){
            this.operations[op-1].PrintConversion(input, output);
        }
    }
}