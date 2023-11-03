using Codility_CountNonDivisible;

namespace Codility_CountNonDivisibleTests
{
    public class SolutionTests
    {
        [Fact]
        public void Solution_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[] { };

            // Act
            int[] result = solution.solution(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Solution_InputWithinValidRange_ReturnsCorrectResult()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[] { 1, 2, 3, 4, 5 };

            // Act
            int[] result = solution.solution(input);

            // Assert
            Assert.Equal(new int[] { 4, 3, 3, 2, 3 }, result);
        }

        [Fact]
        public void Solution_InputWithDuplicateNumbers_ReturnsCorrectResult()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[] { 1, 2, 2, 3, 3, 3 };

            // Act
            int[] result = solution.solution(input);

            // Assert
            Assert.Equal(new int[] { 5, 3, 3, 2, 2, 2 }, result);
        }

        [Fact]
        public void Solution_InputWithLargeValues_ReturnsCorrectResult()
        {
            // Arrange
            Solution solution = new Solution();
            int[] input = new int[] { 1000, 2000, 3000, 4000, 5000 };

            // Act
            int[] result = solution.solution(input);

            // Assert
            Assert.Equal(new int[] { 4, 3, 3, 2, 3 }, result);
        }
    }
}