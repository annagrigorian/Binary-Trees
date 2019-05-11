using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    class BinaryTree<T>
    {
        protected class Node<T>
        {
            public T Value { get; set; }
            public Node<T> LeftChild;
            public Node<T> RightChild;

            public Node(T val, Node<T> left = null, Node<T> right = null)
            {
                Value = val;
                LeftChild = left;
                RightChild = right;
            }

            public Node()
            {
                //Value = null;
                LeftChild = null;
                RightChild = null;
            }
        }

        protected Node<T> root;

        public bool IsEmpty => root == null;

        public T RootValue
        {
            get
            {
                if (IsEmpty)
                    throw new Exception("brrrrrrrrr");
                else return root.Value;
            }

            set
            {
                if (IsEmpty)
                    root = new Node<T>(value);
                else root.Value = value;
            }
        }

        public BinaryTree()
        { }

        public BinaryTree(T val)
        {
            root = new Node<T>(val);
        }

        public BinaryTree(T val, BinaryTree<T> left, BinaryTree<T> right)
        {
            root = new Node<T>();
            root.LeftChild = left.root;
        }

        public void AttachLeftTree(BinaryTree<T> left)
        {
            if (IsEmpty)
                throw new Exception("br");
            if (root.LeftChild != null)
                throw new Exception("ty");
            else this.root.LeftChild = left.root;
        }

        public void AttachRightTree(BinaryTree<T> right)
        {
            if (IsEmpty)
                throw new Exception("br");
            if (root.RightChild != null)
                throw new Exception("ty");
            else this.root.RightChild = right.root;
        }

        public void AttachLeftNode(T val)
        {
            if (IsEmpty)
                throw new Exception("br");
            if (root.LeftChild != null)
                throw new Exception("ty");
            else root.LeftChild = new Node<T>(val);
        }

        public void AttachRightNode(T val)
        {
            if (IsEmpty)
                throw new Exception("br");
            if (root.RightChild != null)
                throw new Exception("ty");
            else root.RightChild = new Node<T>(val);
        }
    }
}
