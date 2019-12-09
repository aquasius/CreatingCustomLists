using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListCreation
{
    public class CustomLists<T> : IEnumerator
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

            if (count == capacity)
            {
                capacity *= 2;
                T[] temp = new T[capacity];
                for (int i = 0; i < count; i++)
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
            T[] temp = new T[capacity];
            bool indexFound = false;
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                if (list[i].Equals(item))
                {
                    indexFound = true;
                }

                if (!list[i].Equals(item))
                {
                    temp[j] = list[i];
                    j++;
                }


            }
            list = temp;
            count--;
            return indexFound;
        }


        public override string ToString()
        {
            string stringToReturn = "";
            for (int i = 0; i < count; i++)
            {
                Convert.ToString(list[i]);
                stringToReturn += list[i];
            }
            return stringToReturn;
        }

        public static CustomLists<T> operator +(CustomLists<T> listOne, CustomLists<T> listTwo)
        {
            CustomLists<T> arrayHolder = new CustomLists<T>();

            for (int i = 0; i < listOne.count; i++)
            {
                arrayHolder.Add(listOne[i]);
            }
            for (int i = 0; i < listOne.count; i++)
            {
                arrayHolder.Add(listTwo[i]);
            }
            return arrayHolder;



        }




    }        
        

    
}
