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
            SampleDataBuilder.BuildTreeFromSampleData(binaryTree);

            // Assert
            Assert.Equal(expected: "Snake", actual: binaryTree.Root.LesserNode.Name);
        }

        [Fact]
        public void FindNodeName_AtDepthOfFive_ReturnsNameOfNode()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            SampleDataBuilder.BuildTreeFromSampleData(binaryTree);

            // Assert
            Assert.Equal(expected: "Civet", actual: 
                binaryTree.Root.LesserNode.GreaterNode.LesserNode.LesserNode.Name);
        }

        [Fact]
        public void FindNodeName_AtDepthOfFive_SearchesFewestNodes()
        {
            // Arrange
            BinaryTree binaryTree = new BinaryTree();

            // Act
            SampleDataBuilder.BuildTreeFromSampleData(binaryTree);
            binaryTree.FindNodeNameByValue(11);

            // Assert
            Assert.Equal(expected: 5, actual: binaryTree.Count);
        }
    }
}
