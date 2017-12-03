using Xunit;

namespace LongestCommonSubsequence.Tests
{
    public class LongestCommonSebsequenceTests
    {
        [Theory]
        [InlineData("ABC", "ABC", 3)]
        [InlineData("AKKKKKK", "AKKKKKK", 7)]
        [InlineData("AFMJA", "AF", 2)]
        [InlineData("AMMA", "AMA", 3)]
        [InlineData("KJASHASDH", "PLASJDSDH", 5)]
        [InlineData("PLASJDSDH", "KJASHASDH", 5)]
        public void ConfirmThatSequenceFindinIsCorrect(string seq1, string seq2, int resultExpected)
        {
            // Arrange.
            // Act.
            var result = LongestCommonSebsequence.LongestCommonSequence(seq1, seq2);

            // Assert.
            Xunit.Assert.Equal(resultExpected, result);
        }
    }
}
