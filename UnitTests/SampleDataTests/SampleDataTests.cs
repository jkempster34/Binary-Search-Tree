using BinarySearchTree;
using Xunit;

namespace UnitTests.SampleDataTests
{
    public class SampleDataTests
    {
        [Fact]
        public void FindNodeName_AtDepthOfTwo_ReturnsNameOfNode()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            SampleDataHelper.BuildTreeFromSampleData(binaryTree);

            // Assert
            Assert.Equal(expected: "Snake", actual: binaryTree.Root.LesserNode.Name);
        }

        [Fact]
        public void FindNodeName_AtDepthOfFour_ReturnsNameOfNode()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            SampleDataHelper.BuildTreeFromSampleData(binaryTree);

            // Assert
            Assert.Equal(expected: "Civet", actual: 
                binaryTree.Root.LesserNode.GreaterNode.LesserNode.LesserNode.Name);
        }
    }
}
