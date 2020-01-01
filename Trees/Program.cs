using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.right.right = new Node(5);
            tree.root.left.left.left = new Node(6);
            tree.root.right.right.right = new Node(7);

            Console.WriteLine("Level Order traversal of binary tree is : ");
            Console.WriteLine();
            tree.reverseLevelOrder(tree.root);
            Console.WriteLine();
            Console.WriteLine();

        }


    }


    public class Node
    {
        public int data;
        public Node left, right;
        
        public Node(int data)
        {
            this.data = data;
        }
    }

    public class BinaryTree
    {

        public Node root;


        /* Compute the "height" of a tree --  
        the number of nodes along the longest  
        path from the root node down to the  
        farthest leaf node.*/
        int height(Node node)
        {
            if (node == null)
                return 0;
            else
            {
                int rHeight = height(node.right);
                int lHeight = height(node.left);

                if (rHeight > lHeight)
                {
                    return rHeight + 1;
                }
                else
                {
                    return lHeight + 1;
                }
            }
        }


        /* Print nodes at a given level */
        public void printGivenLevel(Node node, int level)
        {
            if (node == null)
                return;
            if (level == 1)
                Console.Write(node.data + " ");
            else if (level > 1)
            {
                printGivenLevel(node.right, level - 1);
                printGivenLevel(node.left, level - 1);
            }
        }


        /* Function to print REVERSE  
        level order traversal a tree*/            
        public void reverseLevelOrder(Node node)
        {
            if (node == null)
                return;
            int h = height(node);
            for (int i = h; i > 0; i--)
            {
                printGivenLevel(node, i);
            }   
        }
    }
}
