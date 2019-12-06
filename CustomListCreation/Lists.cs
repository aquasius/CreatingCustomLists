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
        private T[] list;
        private int capacity;
        private int count;

        
        public T this[int i]
        {
            get
            {
                return list[i];
            }
            set
            {
                list[i] = value;
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
            list = new T[capacity];
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
                    temp[i] = list[i];
                }
                temp[count] = item;

                list = temp;
                
             
            }
            else
            {
                list[count] = item;
            }
            count++;
        }

        public bool Remove(T item)
        {
            T[] temp = new T[count -1];
            bool indexFound = false;
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                {
                    indexFound = true;
                }

                if (!list[i].Equals(item))
                {
                    temp[i] = list[i];
                   
                }


            }
            list = temp;
            count--;
            return indexFound;


        }
    }
}
