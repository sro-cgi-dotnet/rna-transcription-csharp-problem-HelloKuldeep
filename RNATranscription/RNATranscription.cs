using System;

namespace RNATranscriptionModule{
    public static class RnaTranscription{
        public static string ToRna(string nucleotide){
            int n = nucleotide.Length;
            string nucleotide2 = null;
            for(int i = 0; i < n; i++){
                switch (nucleotide[i]){
                    case 'G':
                        nucleotide2 += 'C';
                        break;
                    case 'C':
                        nucleotide2 += 'G';
                        break;
                    case 'T':
                        nucleotide2 += 'A';
                        break;
                    case 'A':
                        nucleotide2 += 'U';
                        break;
                    default:
                        break;
                }
            }
            return nucleotide2;
        }
    }
}