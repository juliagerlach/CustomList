using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        private T[] array = new T[4];
        private int count;
        private int capacity;
        private T combine;
        private CustomList<T> x;

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

        public T Combine
        {
            get => combine;
            set => combine = value;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return array[i];
            }
        }
        public CustomList()
        {
           
        }

        public CustomList(CustomList<T> x)
        {
            this.x = x;
        }

        public static CustomList<T> operator+ (CustomList<T> x, CustomList<T> y)
        {
            CustomList <T> list = new CustomList<T>();
            //come back to finish this!
            for (int i = 0; i < list.count; i++)
                list.Add(x[i]);

            for (int i = 0; i < list.count; i++)
                list.Add(y[i]);
            return list;
        }

        public static CustomList<T> operator -(CustomList<T> x, CustomList<T> y)
        {
            CustomList<T> list = new CustomList<T>();
            //come back to finish this!
            for (int i = 0; i < list.count; i++)
                list.Remove(x[i]);

            for (int i = 0; i < list.count; i++)
                list.Remove(y[i]);
            return list;
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
            T[] reducedArray = new T[count];

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    ShiftArray(i);
                    return true;
                }
                else
                    reducedArray[i] = array[i];                          
            }
            return false;
        }

        public void ShiftArray(int index)
            {
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            }

        public override string ToString()
        {
            string arrayString = "";

            for (int i = 0; i < array.Length; i++)
            {
                arrayString += array[i];
            }

            return arrayString;
        }

        public void Zip(CustomList<T> oddNumbers, CustomList<T> evenNumbers)
        {
            int oddCount = oddNumbers.Count;
            int evenCount = Count;
            count += oddCount;
            T[] newArray = new T[Count];
            

            for (int i = 0; i < Count; i++)
            {
                if(oddCount == 3)
                {
                    newArray[i] = oddNumbers[i];
                    oddCount--;
                }
                else if (evenCount == 3)
                {
                    newArray[i] = evenNumbers[i - 1];
                    evenCount--;
                }
                else if (oddCount ==2)
                {
                    newArray[i] = oddNumbers[i -1];
                    oddCount--;
                }
                else if (evenCount == 2)
                {
                    newArray[i] = evenNumbers[i - 2];
                    evenCount--;
                }
                else if (oddCount == 1)
                {
                    newArray[i] = oddNumbers[i - 2];
                    oddCount--;
                }
                else if (evenCount == 1)
                {
                    newArray[i] = evenNumbers[i - 3];
                    evenCount--;
                }
                else
                {

                }
            }
            count = newArray.Length;
            array = newArray;
        }
    }
}
