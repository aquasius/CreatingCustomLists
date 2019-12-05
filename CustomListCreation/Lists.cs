using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListCreation
{
    public class CustomLists<T>
    {
        //member variables
        private T[] items;
        private int capacity;
        private int count;


        //constructor
        public CustomLists()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }


        //member methods
        public void Add(T item)
        {
            if(count == capacity)
            {
                capacity *= 2;
            }
        }


    }
}
