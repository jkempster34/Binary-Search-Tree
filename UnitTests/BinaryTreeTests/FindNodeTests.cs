using BinarySearchTree;
using Xunit;

namespace UnitTests.BinaryTreeTests
{
    public class FindNodeTests
    {
        [Fact]
        public void FindNodeName_WhenTreeHasSingleNode_ReturnsNameOfNode()
        {
            // Arrange
            const int nodeValue = 1;
            const string nodeName = "Lemur";
            BinaryTree tree = new BinaryTree();
            Node nodeToAdd = new Node() { 
                Value = nodeValue,
                Name = nodeName
            };

            // Act
            tree.AddNode(nodeToAdd);
            string result = tree.FindNodeNameByValue(nodeValue);

            // Assert
            Assert.Equal(expected: nodeName, actual: result);
        }

        [Fact]
        public void FindNodeName_WhenTreeHasADepthOfTwoAndNodeValueIsLowerThanRoot_ReturnsNameOfNode()
        {
            // Arrange
            const int valueToFind = 1;
            const string nameToFind = "Goat";
            BinaryTree tree = new BinaryTree();
            Node firstNodeToAdd = new Node()
            {
                Value = 2,
                Name = "Lemur"
            };
            Node secondNodeToAdd = new Node()
            {
                Value = valueToFind,
                Name = nameToFind
            };

            // Act
            tree.AddNode(firstNodeToAdd);
            tree.AddNode(secondNodeToAdd);
            string result = tree.FindNodeNameByValue(valueToFind);

            // Assert
            Assert.Equal(expected: nameToFind, actual: result);
        }

        [Fact]
        public void FindNodeName_WhenTreeHasADepthOfTwoAndNodeValueIsGreaterThanRoot_ReturnsNameOfNode()
        {
            // Arrange
            const int valueToFind = 2;
            const string nameToFind = "Goat";
            BinaryTree tree = new BinaryTree();
            Node firstNodeToAdd = new Node()
            {
                Value = 1,
                Name = "Lemur"
            };
            Node secondNodeToAdd = new Node()
            {
                Value = valueToFind,
                Name = nameToFind
            };

            // Act
            tree.AddNode(firstNodeToAdd);
            tree.AddNode(secondNodeToAdd);
            string result = tree.FindNodeNameByValue(valueToFind);

            // Assert
            Assert.Equal(expected: nameToFind, actual: result);
        }
    }
}
