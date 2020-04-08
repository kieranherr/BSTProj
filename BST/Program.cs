using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree newTree = new BinarySearchTree();
            newTree.AddToTree(45);
            newTree.AddToTree(50);
            newTree.AddToTree(2);
            newTree.AddToTree(15);
            newTree.AddToTree(80);
        }
    }
}
