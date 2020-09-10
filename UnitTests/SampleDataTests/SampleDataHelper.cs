using BinarySearchTree;
using System.Collections.Generic;

namespace UnitTests.SampleDataTests
{
    public static class SampleDataHelper
    {
        public static BinaryTree BuildTreeFromSampleData(BinaryTree binaryTree)
        {
            Dictionary<int, string> sampleData = SampleData.sampleData;

            foreach (var column in sampleData)
            {
                Node nodeToAdd = new Node()
                {
                    Name = column.Value,
                    Value = column.Key
                };

                binaryTree.AddNode(nodeToAdd);
            }
            return binaryTree;
        }
    }
}
