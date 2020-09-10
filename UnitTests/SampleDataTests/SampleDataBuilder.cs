using BinarySearchTree;
using System.Collections.Generic;

namespace UnitTests.SampleDataTests
{
    public static class SampleDataBuilder
    {
        public static BinaryTree BuildTreeFromSampleData(BinaryTree binaryTree)
        {
            Dictionary<int, string> sampleData = SampleData.sampleData;

            foreach (var row in sampleData)
            {
                Node nodeToAdd = new Node()
                {
                    Name = row.Value,
                    Value = row.Key
                };

                binaryTree.AddNode(nodeToAdd);
            }
            return binaryTree;
        }
    }
}
