using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeHeight
    {
        public int maxHeight = -1;

        /// <summary>
        /// Calculates the maxHeight of a tree and stores the value on a property
        /// </summary>
        /// <param name="root">Tree root node</param>
        /// <param name="initialHeight">Initial height to calculate</param>
        public void GetHeight(Node root, int initialHeight = 0)
        {
            if(root == null)
            {
                return;
            }

            if(initialHeight > maxHeight)
            {
                maxHeight++;
            }

            this.GetHeight(root.left, initialHeight + 1);
            this.GetHeight(root.right, initialHeight + 1);
        }

        /// <summary>
        /// Calculates and returns the longest path (the one with max height) of a provided tree.
        /// </summary>
        /// <param name="root">Tree root node</param>
        /// <returns>A list of nodes representing a path</returns>
        public List<int> LongestPath(Node root)
        {
            if(root == null)
            {
                return new List<int>();
            }


            List<int> leftPath = this.LongestPath(root.left);
            List<int> rightPath = this.LongestPath(root.right);

            List<int> resultList = new List<int>();
            resultList.Insert(0, root.value);
            resultList.AddRange(leftPath.Count > rightPath.Count ? leftPath : rightPath);

            return resultList;
        }
    }
}
