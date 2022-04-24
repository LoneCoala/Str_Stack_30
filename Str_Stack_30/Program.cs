using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Str_Stack_30
{
    class Tree
    {
        class Node
        {
            public char data;
            public Node left, right;
        };

        static void printLeafNodes(Node root, Queue<Char> leafs)
        {
 

            // если нулл, вернуть ничего
            if (root == null)
                return;

            // если это листок, напечатать его содержимое    
            if (root.left == null &&
                root.right == null)
            {
                leafs.Enqueue(root.data);
                //Console.Write(root.data + " ");
                return;
            }
            // если левый потомок существует, искать лист
            // рекурсия
            if (root.left != null)
                printLeafNodes(root.left, leafs);

            // If правый потомок существует, искать лист
            // рекурсия
            if (root.right != null)
                printLeafNodes(root.right, leafs);
        }
        static Node newNode(char data)
        {
            Node temp = new Node();
            temp.data = data;
            temp.left = null;
            temp.right = null;
            return temp;
        }

        public static void Main()
        {
            Node root = newNode('a');
            root.left = newNode('b');
            root.right = newNode('c');
            root.left.left = newNode('d');
            root.right.left = newNode('e');
            root.right.right = newNode('f');
            root.right.left.left = newNode('g');
            root.right.left.right = newNode('h');
            root.right.right.left = newNode('j');
            root.right.right.right = newNode('k');
            root.right.right.right.left = newNode('P');
            Queue<Char> leafs = new Queue<Char> { };

            printLeafNodes(root, leafs);
            while(leafs.Count != 0)
            {
                Console.WriteLine(leafs.Dequeue());

            }

          
        }
    }

}