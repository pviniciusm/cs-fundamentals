using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class LeftSideView
    {
        public List<int> result = new List<int>();
        public int checkHeight = 0;

        /// <summary>
        /// Read the outline nodes of a tree
        /// </summary>
        /// <param name="root">Tree roor node</param>
        public void ReadOutline(Node root)
        {
            this.Read(root.left, 0, true);
            this.result.Add(root.value);
            this.Read(root.right, this.checkHeight, false);
        }

        /// <summary>
        /// Read the left or right side view of a tree
        /// </summary>
        /// <param name="root">Tree root node</param>
        /// <param name="height">View height</param>
        /// <param name="isLeft">View side to consider</param>
        public void Read(Node root, int height, bool isLeft)
        {
            if (root == null)
            {
                return;
            }

            if (height >= checkHeight)
            {
                result.Add(root.value);
                checkHeight++;
            }

            this.Read(isLeft ? root.left : root.right, height + 1, isLeft);
            this.Read(isLeft ? root.right : root.left, height + 1, isLeft);
        }
    }

}
