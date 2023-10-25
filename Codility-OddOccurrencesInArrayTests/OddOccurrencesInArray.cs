using Codility_OddOccurrencesInArray;

namespace Codility_OddOccurrencesInArrayTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestSingleUnpairedElement()
        {
            Solution solution = new Solution();
            int[] inputArray = { 7 };
            int expected = 7;
            int result = solution.solution(inputArray);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestUnpairedElementInMiddle()
        {
            Solution solution = new Solution();
            int[] inputArray = { 9, 3, 9, 3, 9, 7, 9 };
            int expected = 7;
            int result = solution.solution(inputArray);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestUnpairedElementAtStart()
        {
            Solution solution = new Solution();
            int[] inputArray = { 5, 4, 4, 3, 3, 2, 2, 1, 1 };
            int expected = 5;
            int result = solution.solution(inputArray);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestUnpairedElementAtEnd()
        {
            Solution solution = new Solution();
            int[] inputArray = { 2, 2, 4, 4, 3, 3, 1, 1, 6 };
            int expected = 6;
            int result = solution.solution(inputArray);
            Assert.Equal(expected, result);
        }
    }
}