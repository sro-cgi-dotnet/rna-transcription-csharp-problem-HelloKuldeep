using System;
using System.Text;
namespace RNATranscriptionModule{
    public static class RnaTranscription{
        public static string ToRna(String nucleotide){
            int n = nucleotide.Length;
            StringBuilder nucleotide2 = new StringBuilder(""); //To avoid immutable property of String
            for(int i = 0; i < n; i++){
                switch (nucleotide[i]){
                    case 'G':
                        nucleotide2.Append("C");
                        break;
                    case 'C':
                        nucleotide2.Append("G");
                        break;
                    case 'T':
                        nucleotide2.Append("A");
                        break;
                    case 'A':
                        nucleotide2.Append("U");
                        break;
                    default:
                        throw (new ArgumentException("Invalid DNA Sequence. Error: " + nucleotide[i]));
                        break;
                }
            }
            return nucleotide2.ToString();
        }
    }
}