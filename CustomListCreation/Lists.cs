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

        
        public T this[int i]
        {
            get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }
        
        public int Count
        {
            get
            {
                return count;
            }
        }

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
                for(int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }
                temp[count] = item;

                items = temp;
                
             
            }
            else
            {
                items[count] = item;
            }
            count++;
        }


    }
}
