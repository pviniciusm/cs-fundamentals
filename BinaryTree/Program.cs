/**
 * Program to exercise some binary tree concepts
 */

namespace BinaryTree
{
    internal class Program
    {
        public enum Options
        {
            Simple,
            Complex,
            Exercise
        }

        static BinaryTree GetTestCase(Options option)
        {
            BinaryTree tree = new BinaryTree();

            switch (option) 
            {
                case Options.Simple:
                    tree.Add(1);
                    tree.Add(2);
                    tree.Add(3);
                    break;
                case Options.Complex:
                    tree.Add(10);
                    tree.Add(5);
                    tree.Add(15);
                    tree.Add(4);
                    tree.Add(6);
                    tree.Add(11);
                    tree.Add(17);
                    tree.Add(13);
                    break;
                case Options.Exercise:
                    tree.Add(3);
                    tree.Add(2);
                    tree.Add(5);
                    tree.Add(1);
                    tree.Add(4);
                    tree.Add(6);
                    tree.Add(7);
                    break;
                default:
                    break;
            }

            return tree;
        }

        static void Main(string[] args)
        {
            BinaryTree tree = GetTestCase(Options.Exercise);
            
            // Pre-order search
            Console.WriteLine("- PreOrder:");
            tree.ReadPreOrder();

            // Left side search
            Console.WriteLine("- LeftSide:");
            tree.ReadLeftSide();

            // Outline view
            Console.WriteLine("- Outline:");
            LeftSideView leftSideView = new LeftSideView();
            leftSideView.ReadOutline(tree.Root);

            foreach (int item in leftSideView.result)
            {
                Console.WriteLine(item);
            }

            // Max height
            TreeHeight treeHeightInst = new TreeHeight();
            treeHeightInst.GetHeight(tree.Root);

            Console.WriteLine("Tree height: ");
            Console.WriteLine(treeHeightInst.maxHeight.ToString());

            // Longest path 
            foreach (int item in treeHeightInst.LongestPath(tree.Root))
            {
                Console.WriteLine(item);
            }
        }

    }
}