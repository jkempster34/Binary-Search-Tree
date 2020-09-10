using System;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public BinaryTree()
        {
            Count = 0;
        }

        public Node Root { get; set; }
        public int Count { get; set; }

        public string FindNodeNameByValue(int nodeValue)
        {
            Node node = FindNodeRecursive(Root, nodeValue);
            return node.Name;
        }

        public bool AddNode(Node nodeToAdd)
        {
            bool nodeAdded = false;

            try
            {
                Root = AddNodeRecursive(Root, nodeToAdd);
                nodeAdded = true;
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            return nodeAdded;
        }

        private Node FindNodeRecursive(Node currentNode, int nodeValueToFind)
        {
            IncrementCount();

            if (currentNode.Value == nodeValueToFind)
            {
                return currentNode;
            }
            else if (currentNode.Value > nodeValueToFind)
            {
                return FindNodeRecursive(currentNode.LesserNode, nodeValueToFind);
            }
            else if (currentNode.Value < nodeValueToFind)
            {
                return FindNodeRecursive(currentNode.GreaterNode, nodeValueToFind);
            }
            else return new Node();
        }

        private Node AddNodeRecursive(Node currentNode, Node nodeToAdd)
        {
            if (currentNode == null) // Exit conditon
            {
                return nodeToAdd;
            }
            else if (nodeToAdd.Value > currentNode.Value)
            {
                currentNode.GreaterNode = AddNodeRecursive(currentNode.GreaterNode, nodeToAdd);
            }
            else if (nodeToAdd.Value < currentNode.Value)
            {
                currentNode.LesserNode = AddNodeRecursive(currentNode.LesserNode, nodeToAdd);
            }
            else if (nodeToAdd.Value == currentNode.Value)
            {
                throw new ArgumentException("Cannot add node. A Node already exists with this value");
            }

            return currentNode;
        }

        private void IncrementCount() => Count++;
    }
}
