using System;

namespace Binary_Search_Tree

{
   
    /// <summary>
    /// Generic Binary search tree is defined
    /// Due to generic class, Icomparable method is defined to use CompareTo inside the program
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BST<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BST<T> LeftTree { get; set; }
        public BST<T> RightTree { get; set; }

        /// <summary>
        /// constructor and pass parameter
        /// </summary>
        /// <param name="nodeData"></param>
        public BST(T nodeData)
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }

        int LeftCount = 0;
        int RightCount = 0;
        //bool result = false;

        public void Insert(T item)//create method and pass parameter item
        {
            T currentNodeValue = NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (LeftTree == null)
                    LeftTree = new BST<T>(item);
                else
                    LeftTree.Insert(item);
            }
            else
            {
                if (RightTree == null)
                    RightTree = new BST<T>(item);
                else
                    RightTree.Insert(item);
            }
        }

        /// <summary>
        /// Get size of Binary Search Tree
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("\nSize " + (1 + LeftCount + RightCount));
        }
        public void Display()
        {
            if (LeftTree != null)
            {
                LeftCount++;
                LeftTree.Display();
            }
            Console.Write(NodeData.ToString() + "-->");
            if (RightTree != null)
            {
                RightCount++;
                RightTree.Display();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------Welcome To Binary Search Tree--------");
            Console.WriteLine();
            BST<int> bST = new BST<int>(56);
            bST.Insert(30);
            bST.Insert(70);
            bST.Insert(22);
            bST.Insert(40);
            bST.Insert(60);
            bST.Insert(95);
            bST.Insert(11);
            bST.Insert(65);
            bST.Insert(3);
            bST.Insert(16);
            bST.Insert(63);
            bST.Insert(67);

            bST.GetSize();
            bST.Display();


            Console.Read();
        }
    }
}


