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
                T[] temp = new T[capacity];
                //move values to it
                //destroy and recreate original 
                //move values back to original
            }
            else
            {
                items[count] = item;
            }
            count++;
        }


    }
}
