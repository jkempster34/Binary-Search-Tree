using System;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public string FindNodeNameByValue(int nodeValue)
        {
            return "name";
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

    }
}
