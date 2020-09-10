using BinarySearchTree;
using Xunit;

namespace UnitTests.BinaryTreeTests
{
    public class AddNodeTests
    {
        [Fact]
        public void AddNode_WithSingleNode_SetsNodeAsRoot()
        {
            // Arrange
            const int nodeValue = 1;
            BinaryTree tree = new BinaryTree();
            Node nodeToAdd = new Node() { Value = nodeValue };

            // Act
            tree.AddNode(nodeToAdd);

            // Assert
            Assert.Equal(expected: nodeValue, actual: tree.Root.Value);
        }

        [Fact]
        public void AddNode_WithGreaterValueThanFirstNode_IsSetAsGreaterNode()
        {
            // Arrange
            const int secondNodeValue = 2;
            BinaryTree tree = new BinaryTree();
            Node rootNode = new Node() { Value = 1 };
            Node secondNode = new Node() { Value = secondNodeValue };

            // Act
            tree.AddNode(rootNode);
            tree.AddNode(secondNode);

            // Assert
            Assert.Equal(expected: secondNodeValue, actual: tree.Root.GreaterNode.Value);
        }

        [Fact]
        public void AddNode_WithLowerValueThanFirstNode_IsSetAsLesserNode()
        {
            // Arrange
            const int secondNodeValue = 1;
            BinaryTree tree = new BinaryTree();
            Node rootNode = new Node() { Value = 2 };
            Node secondNode = new Node() { Value = secondNodeValue };

            // Act
            tree.AddNode(rootNode);
            tree.AddNode(secondNode);

            // Assert
            Assert.Equal(expected: secondNodeValue, actual: tree.Root.LesserNode.Value);
        }


        [Fact]
        public void AddNode_WithValueThatAlreadyExists_ReturnsFalse()
        {
            // Arrange
            const int nodeValue = 1;
            BinaryTree tree = new BinaryTree();
            Node firstNode = new Node() { Value = nodeValue };
            Node secondNode = new Node() { Value = nodeValue };

            // Act
            tree.AddNode(firstNode);
            bool nodeAdded = tree.AddNode(secondNode);

            // Assert
            Assert.False(nodeAdded);
        }

        [Fact]
        public void AddNode_WithValueThatIsNew_ReturnsTrue()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            Node firstNode = new Node() { Value = 1 };
            Node secondNode = new Node() { Value = 2 };

            // Act
            tree.AddNode(firstNode);
            bool nodeAdded = tree.AddNode(secondNode);

            // Assert
            Assert.True(nodeAdded);
        }

        [Fact]
        public void AddNodes_ToDepthOfTwoWithLowerValues_SetsNodesCorrectly()
        {
            // Arrange
            const int rootNodeValue = 3;
            const int secondNodeValue = 2;
            const int thirdNodeValue = 1;
            BinaryTree tree = new BinaryTree();
            Node rootNode = new Node() { Value = rootNodeValue };
            Node secondNode = new Node() { Value = secondNodeValue };
            Node thirdNode = new Node() { Value = thirdNodeValue };

            // Act
            tree.AddNode(rootNode);
            tree.AddNode(secondNode);
            tree.AddNode(thirdNode);

            // Assert
            Assert.Equal(expected: thirdNodeValue, actual: tree.Root.LesserNode.LesserNode.Value);
        }

        [Fact]
        public void AddNodes_ToDepthOfTwoWithGreaterValues_SetsNodesCorrectly()
        {
            // Arrange
            const int rootNodeValue = 1;
            const int secondNodeValue = 2;
            const int thirdNodeValue = 3;
            BinaryTree tree = new BinaryTree();
            Node rootNode = new Node() { Value = rootNodeValue };
            Node secondNode = new Node() { Value = secondNodeValue };
            Node thirdNode = new Node() { Value = thirdNodeValue };

            // Act
            tree.AddNode(rootNode);
            tree.AddNode(secondNode);
            tree.AddNode(thirdNode);

            // Assert
            Assert.Equal(expected: thirdNodeValue, actual: tree.Root.GreaterNode.GreaterNode.Value);
        }

        [Fact]
        public void AddNodes_WithMixedValues_SetsNodesCorrectly()
        {
            // Arrange
            const int rootNodeValue = 2;
            const int secondNodeValue = 1;
            const int thirdNodeValue = 3;
            BinaryTree tree = new BinaryTree();
            Node rootNode = new Node() { Value = rootNodeValue };
            Node secondNode = new Node() { Value = secondNodeValue };
            Node thirdNode = new Node() { Value = thirdNodeValue };

            // Act
            tree.AddNode(rootNode);
            tree.AddNode(secondNode);
            tree.AddNode(thirdNode);

            // Assert
            Assert.Equal(expected: secondNodeValue, actual: tree.Root.LesserNode.Value);
            Assert.Equal(expected: thirdNodeValue, actual: tree.Root.GreaterNode.Value);
        }
    }
}
