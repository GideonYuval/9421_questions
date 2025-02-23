﻿using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using TreeDLR;

namespace _9421_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BinNode<string> tree = VisualTree<string>.GetTree();




        }

        // Tree 1                        Tree 2                        Tree 3                        Tree 4
        //          1                            1                            -1                             m
        //       /     \                      /     \                      /     \                      /     \
        //      3       2                    2       3                   -2      3                    a       r
        //     /       / \                  / \     / \                 /  \    /  \                 / \     / \
        //    9       6   8                4   5   6   7             -4    5  6   -7               z   d   e   w
        //     \
        //      7


        //Q1
        //parameter - tree of ints
        //return - int
        //return sum of all even nodes

        static int SumEven(BinNode<int> root)
        {
            return 0;
        }

        //Q2
        //parameter - tree of ints
        //return - void
        //print POST-ORDER values of all left children
        //use Tree1
        static void PrintPOLeft(BinNode<int> root)
        {

        }

        //Q3
        //parameter - tree of ints
        //return - void
        //print POST-ORDER values of all left children with negative values
        //use Tree3

        static void PrintPOLeftNegative(BinNode<int> root)
        {

        }

        //Q4
        //parameter - tree of chars, all non-capital, e.g. 'a'
        //return - nothing
        //update all chars to the following char: 'a'->'b', 'b'->'c', 'z'->'a
        //use tree4 to test
        //tip: needs casting. try shifting chars in Main before implementing here...
        static void CharShift(BinNode<char> root)
        {

        }

        //Q5
        //parameter - tree of ints
        //return - void
        //print IN-ORDER: for each node - print the value of the child which is closest to node value
        //                              - if only one child - print the value of that child
        //use Tree1

        static void ClosestChild(BinNode<int> root)
        {


        }

        //Q6
        //parameter - tree of ints
        //return - int - number of leaves (no children)
        //use tree1 and tree2

        static int CountLeaves(BinNode<int> root)
        {
            return 0;
        }

        //Q6
        //parameter - tree of ints
        //return - true - if all left children are smaller than right children. false otherwise
        //use: tree1 (true), tree2 (false)
        static bool AllLeftLTRight(BinNode<int> root)
        {
            return false;
        }





        static BinNode<string> Days()
        {
            BinNode<string> root = new BinNode<string>("Sunday");
            root.SetLeft(new BinNode<string>("monday"));
            root.GetLeft().SetLeft(new BinNode<string>("tuesday"));
            root.GetLeft().SetRight(new BinNode<string>("Wednesday"));
            root.GetLeft().GetRight().SetRight(new BinNode<string>("Thursday"));
            root.SetRight(new BinNode<string>("friday"));
            root.GetRight().SetLeft(new BinNode<string>("Saturday"));
            return root;
        }

        // Tree structure:
        //          Sunday
        //         /      \
        //      monday    friday
        //     /    \       /
        //  tuesday Wednesday Saturday
        //                 \
        //                 Thursday

        public static BinNode<int> BuildTree1()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> node3 = new BinNode<int>(3);
            node3.SetLeft(new BinNode<int>(9));
            node3.GetLeft().SetRight(new BinNode<int>(7));

            // Right subtree
            BinNode<int> node2 = new BinNode<int>(2);
            node2.SetLeft(new BinNode<int>(6));
            node2.SetRight(new BinNode<int>(8)); // Hidden child set to 8

            // Attach left and right subtrees to root
            root.SetLeft(node3);
            root.SetRight(node2);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      3       2
        //     /       / \
        //    9       6   8
        //     \
        //      7

        static BinNode<int> BuildTree2()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(2);
            leftChild.SetLeft(new BinNode<int>(4));
            leftChild.SetRight(new BinNode<int>(5));

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3);
            rightChild.SetLeft(new BinNode<int>(6));
            rightChild.SetRight(new BinNode<int>(7));

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      2       3
        //     / \     / \
        //    4   5   6   7

        static BinNode<int> BuildTree3()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(-1); // Root value is negative

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(-2); // Left child of root
            leftChild.SetLeft(new BinNode<int>(-4));       // Left child of node -2
            leftChild.SetRight(new BinNode<int>(5));       // Right child of node -2

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3); // Right child of root
            rightChild.SetLeft(new BinNode<int>(6));       // Left child of node 3
            rightChild.SetRight(new BinNode<int>(-7));     // Right child of node 3 (negative)

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //         -1
        //       /    \
        //     -2      3
        //    /  \    /  \
        //  -4    5  6   -7

        static BinNode<char> BuildTree4()
        {
            // Root node
            BinNode<char> root = new BinNode<char>('m'); // Root value

            // Left subtree
            BinNode<char> leftChild = new BinNode<char>('a'); // Left child of root
            leftChild.SetLeft(new BinNode<char>('z'));       // Left child of node 'a'
            leftChild.SetRight(new BinNode<char>('d'));      // Right child of node 'a'

            // Right subtree
            BinNode<char> rightChild = new BinNode<char>('r'); // Right child of root
            rightChild.SetLeft(new BinNode<char>('e'));        // Left child of node 'r'
            rightChild.SetRight(new BinNode<char>('w'));       // Right child of node 'r'

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }
        // Tree structure:
        //          m
        //       /     \
        //      a       r
        //     / \     / \
        //    z   d   e   w


    }
}
