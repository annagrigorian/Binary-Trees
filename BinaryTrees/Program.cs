using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> t1 = new BinaryTree<int>(5);
            BinaryTree<int> t2 = new BinaryTree<int>(15);
            BinaryTree<int> t = new BinaryTree<int>(25, t1, t2);
        }
    }
}
