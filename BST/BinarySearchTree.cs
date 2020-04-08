using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    public class BinarySearchTree
    {

        
         public class Node
        {
            public int data;
            public Node leftChild;
            public Node rightChild;
        }
        public Node root;

        public BinarySearchTree()
        {
            root = null;
        }
        
        public void AddToTree(int add)
        {
            Node newNode = new Node();
            newNode.data = add;
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                Node temp = root;
                Node parent;
                while (true)
                {
                    parent = temp;
                    if(add < temp.data)
                    {
                        temp = temp.leftChild;
                        if(temp == null)
                        {
                            parent.leftChild = newNode;
                            break;
                        }
                        else
                        {
                            temp = temp.rightChild;
                            if(temp == null)
                            {
                                parent.rightChild = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }
        public bool Find(int value)
        {
            if(root == null)
            {
                return false;
            }
            else if(value < root.data)
            {
                
                return Find(value);
            }
            else
        }

    }
}

