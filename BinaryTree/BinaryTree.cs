using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        // Addd a value to the tree based on a binary search approach
        public void Add(int value)
        {
            if (this.Root == null)
            {
                this.Root = new Node(value);
                return;
            }

            this.Root.Add(value);
        }

        public void ReadLeftSide()
        {
            Console.WriteLine(this.Root.ReadLeftSide());
        }

        public void ReadPreOrder()
        {
            this.Root.ReadPreOrder();
        }
    }
}
