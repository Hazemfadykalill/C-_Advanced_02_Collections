using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Collections;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Runtime.CompilerServices;
using C__Advanced_02_Collections;

namespace Assignment_Advanced_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            /*⮚	Write a Report about all Collections Given in the Session and Compare
             * [Structure, Time Complexity, and Business Case With Implemented Examples]
             */

            #region Report
            //Solution
            /*        CollectionType     Structure  Time Complexity(Access)    Time Complexity(Insertion/ Deletion)	Use Case
        ArrayList     Non-generic Array  O(1)	    O(n)                        Legacy code, mixed types
        List<T>       Generic Array      O(1)	    O(n)                        Homogeneous data, type safety
        Queue<T>      FIFO               O(n)       O(1)                        Order of processing is important
        Stack< T>     LIFO               O(n)       O(1)                        Backtracking and undo mechanisms
        LinkedList<T> Doubly-LinkedList  O(n)       O(1)                        Frequent insertions/ deletions
            */
            #endregion

            #region ArrayList Implementation
            //ArrayList Implementation

            //ArrayList Names = new ArrayList();


            //Names.Add("Hazem");
            //Names.Add("Fady");
            //Names.Add("1236");



            //// Removing an element
            //Names.Remove("1236");

            //// Iterating through elements
            //foreach (var name in Names)
            //{
            //    Console.Write(" "+ " "+ name);
            //}

            //Console.WriteLine("\n\n ============ ============ ============");  
            #endregion

            #region List Implementation
            //List Generics Implementation

            //List<string> Names = new List<string>(4);


            //Names.Add("Hazem");
            //Names.Add("Fady");
            //Names.Add("Mohamed");
            //Names.Add("Khalil");





            //// Iterating through elements
            //foreach (var name in Names)
            //{
            //    Console.Write(" " + " " + name);
            //}

            //Console.WriteLine("\n\n ============ ============ ============");

            #endregion

            #region Queue Implementation

            //Queue<int> queue = new Queue<int>();

            //// Adding elements
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);

            //// Removing elements
            //Console.WriteLine("Removed: " + queue.Dequeue());

            //// Peeking at the head
            //Console.WriteLine("Head: " + queue.Peek());

            //// Iterating through elements
            //foreach (int number in queue)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region Stack Implementation

            //Stack<string> stack = new Stack<string>();

            // Adding elements
            //stack.Push("A");
            //stack.Push("B");
            //stack.Push("C");

            //// Removing elements
            //Console.WriteLine("Popped: " + stack.Pop());

            //// Peeking at the top Without Removing
            //Console.WriteLine("Top: " + stack.Peek());

            //// Iterating through elements
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            #endregion


            #region LinkedList Implementation
            //LinkedList<string> playlist = new LinkedList<string>();

            // Adding elements
            //playlist.AddLast("Song 1");
            //playlist.AddLast("Song 2");
            //playlist.AddLast("Song 3");

            //// Adding elements at specific positions
            //playlist.AddFirst("Intro");
            //playlist.AddLast("Outro");

            //// Removing elements
            //playlist.Remove("Song 2");

            //// Iterating through elements
            //foreach (string song in playlist)
            //{
            //    Console.WriteLine(song);
            //}
            #endregion
            #endregion



            #region Part02


            #region Q01
            /*1.You are given an ArrayList containing a sequence of elements.
             * try to reverse the order of elements in the ArrayList
             * in-place(in the same arrayList) without using the built-in Reverse.
             * Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
             */

            //ArrayList arrayList = new ArrayList(5) { 1,2,3,4,5};
            //Helper.ReverseArrayList(arrayList);


            #endregion


            #region Q02
            /*2.You are given a list of integers. Your task is to find and return a new list 
             * containing only the even numbers from the given list.
             */

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,14};
            //List<int> list02= Helper.EvenNumberINList(list);
            //for (int i = 0; i < list02.Count; i++)
            //{
            //    Console.Write(" "+ " "+list02[i]); 
            
            //}

            #endregion

            #region Q03
            /*3.implement a custom list called FixedSizeList<T> with a predetermined capacity.
             * This list should not allow more elements than its capacity and should provide clear messages
             * if one tries to exceed it or access invalid indices.
             * Requirements:
             */
            //1.Create a generic class named FixedSizeList<T>.
            //2.Implement a constructor that takes the fixed capacity of the list as a parameter.
            //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
            //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.


            //FixedSizeList<int> list = new FixedSizeList<int>(4);
            //list.Add(1);
            //Console.WriteLine(list.Get(0));
          

            #endregion


            #endregion
        }
    }
}
