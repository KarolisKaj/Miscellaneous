using System;

namespace LongestCommonSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonSebsequence.LongestCommonSequence("AHGC", "ABC"));
            Console.Read();
        }
    }

    public static class LongestCommonSebsequence
    {
        public static int LongestCommonSequence(string seq1, string seq2, int seq1Index = 0, int seq2Index = 0)
        {
            if (String.IsNullOrWhiteSpace(seq1) || String.IsNullOrWhiteSpace(seq1))
                return 0;

            if (seq1.Length <= seq1Index || seq2.Length <= seq2Index)
                return 0;

            if (seq1[seq1Index] == seq2[seq2Index])
                return 1 + LongestCommonSequence(seq1, seq2, seq1Index + 1, seq2Index + 1);
            else
                return Math.Max(LongestCommonSequence(seq1, seq2, seq1Index + 1, seq2Index), LongestCommonSequence(seq1, seq2, seq1Index, seq2Index + 1));
        }
    }
}
