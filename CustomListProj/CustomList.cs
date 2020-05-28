using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class  CustomList<T> : IEnumerable
    {
       
        private T[] items;
        private int count;
        private int capacity;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity;  } }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 && index >= count)
                throw new IndexOutOfRangeException("Index out of range");

                return items[index];
            }

            set
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Index out of range");

                items[index] = value;
            }
        }
        public void Add(T item)
        {
            if (count >= capacity)
            {
                T[] temp = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                }

                items = new T[capacity *= 2];

                for (int i = 0; i < count; i++)
                {
                    items[i] = temp[i];
                }
            }
                items[count] = item;
                
                count++;
           
        }

        public bool Remove(T item)
        {
            int flag = 0;
            T[] temp = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
               if(!Equals(items[i], item))
                {
                    temp[j] = items[i];
                }
                else
                {
                    j--;
                    flag = 1;
                }
               
            }

            for (int i = 0; i < count - 1; i++)
            {
                items[i] = temp[i];
            }

            count--;
      
            if (flag == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < items.Length; i++)
            {
               yield return items[i];
            }
            yield return "Finished Iterating";
        }

        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (items[i] != null)
                {
                    returnString.Append(items[i].ToString());
                }
            }
            return returnString.ToString();
        }

       
    }
}
