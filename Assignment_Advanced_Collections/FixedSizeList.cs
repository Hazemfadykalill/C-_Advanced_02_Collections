using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_Collections
{
    public class FixedSizeList<T>
    {

         T[] items; // Array to hold the elements
         int count; // Number of elements currently in the list
         int capacity; // Fixed capacity of the list

        // Constructor to initialize the list with a specified capacity
        #region Constructor
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            this.capacity = capacity;
            items = new T[capacity];
            count = 0;
        } 
        #endregion

        // Adds an element to the list
        public void Add(T item)
        {
            if (count >= capacity)
            {
                throw new InvalidOperationException("Cannot add more elements. The list is full.");
            }

            items[count] = item;
            count++;
        }

        // Retrieves an element at a specific index
        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }

        // Returns the number of elements currently in the list
        public int Count
        {
            get { return count; }
        }

        // Returns the fixed capacity of the list
        public int Capacity
        {
            get { return capacity; }
        }

        

    }
}
