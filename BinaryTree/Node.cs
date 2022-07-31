using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        public int value;
        public Node? left;
        public Node? right;
        public Node(int value)
        {
            this.value = value;
        }

        /// <summary>
        /// Recursively reads the most left nodes of a tree
        /// </summary>
        /// <returns></returns>
        public string ReadLeftSide()
        {
            if (left == null)
            {
                return this.value.ToString();
            }

            return String.Format("{0} {1}", this.left.ReadLeftSide(), this.value);
        }

        /// <summary>
        /// Reads the node children at pre-order 
        /// </summary>
        public void ReadPreOrder()
        {
            if (this.left != null) this.left.ReadPreOrder();
            Console.WriteLine(this.value.ToString());
            if (this.right != null) this.right.ReadPreOrder();

        }

        /// <summary>
        /// Adds a child based on a binary tree search approach.
        /// Bigger values go to the right; Smaller ones go to the left.
        /// </summary>
        /// <param name="value">Value to add</param>
        public void Add(int value)
        {
            if (value < this.value)
            {
                Console.WriteLine("Value " + value + " is going to the left of " + this.value);
                if (left == null)
                {
                    left = new Node(value);
                    return;
                }

                left.Add(value);
                return;
            }

            if (right == null)
            {
                Console.WriteLine("Value " + value + " is going to the right of " + this.value);
                right = new Node(value);
                return;
            }

            right.Add(value);
        }
    }
}
