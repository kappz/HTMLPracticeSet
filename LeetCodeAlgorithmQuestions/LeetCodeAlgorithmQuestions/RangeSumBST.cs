using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAlgorithmQuestions
{
    public class TreeNode
    {
        public TreeNode(int x) {
            val = x;
        }
        private int val;
        public TreeNode left;
        public TreeNode right;
   }

    public class BinaryTree
    {
        private TreeNode root;
        private int height;

        BinaryTree()
        {
            root = null;
            height = 0;
        }

        public TreeNode getRoot()
        {
            return root;
        }
        public int getHeight()
        {
            return height;
        }

        public void insert(int value)
        {
            int currentHeight = 1;
            if (root == null)
            {
                root = new TreeNode((value));
                height = currentHeight;
            }
            else
            {
                insertRecursion(root, value, currentHeight);
            }
        }

        private TreeNode insertRecursion(TreeNode currentNode, int value, int currentHeight)
        {
            if (currentNode == null)
            {
                currentNode = new TreeNode((value));
            }
            else
            {
                if (currentNode.getKey() >= value)
                {
                    ++currentHeight;
                    currentNode.left = insertRecursion(currentNode.left, value, currentHeight);
                }
                else if (currentNode.getKey() < value)
                {
                    ++currentHeight;
                    currentNode.right = insertRecursion(currentNode.right, value, currentHeight);
                }
            }
            if (currentHeight > height)
            {
                height = currentHeight;
            }
            return currentNode;
        }
        public class RangeSumBST
    {
        
    }
}
