using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        private T[] array = new T[4];
        private int count;
        private int capacity;
        

        public T this[int i]
        {
            get => array[i]; 
            set => array[i] = value; 
        }

        public int Count
        {
            get => count;
        }

        public int Capacity
        {
            get => capacity;
            set => capacity = value;
        }

        public CustomList()
        {
           
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                capacity += 4;
                T[] myList = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    myList[i] = array[i];
                }

                array = myList;
            }

            array[count] = item;
            count++;
        }

        public bool Remove(T item)
        {
            //compare index to item to remove
            //if item already exists in list, remove it 
            //shift remaining items to remove gaps

            T[] reducedArray = new T[count];

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    ResizeArray(i);
                    return true;
                }
                else
                    reducedArray[i] = array[i];
                                 
            }
            return false;
        }

        public void ResizeArray(int index)
            {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            }
    }
}
