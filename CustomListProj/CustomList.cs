using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class  CustomList<T>
    {
       
        private T[] items;
        private int count;
        private int capacity;
       
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
                //if (index < 0 && index >= items.Length)
                    //throw new IndexOutOfRangeException("Index out of range");

                return items[index];
            }

            set
            {
                //if (index < 0 || index >= items.Length)
                //    throw new IndexOutOfRangeException("Index out of range");

                items[index] = value;
            }
        }
        public void Add(T item)
        {
            T[] temp = new T[capacity];
            
            //inserting into the array
            if (count == 0)
            {
                items[count] = item;
                count++;
            }
            else if (count > 0 && count < 4)
            {
                items[count] = item;
                count++;
            }
            else if (count >= 4 && items.Length >=4)
            {

               

                //foreach (T element in items)
                //{
                //    temp[index] = element;
                //   //if (items.Length > 5)
                //   // {
                //   //     temp[index] = element;
                //   // }
                //    index++;

                //}
                for (int i = 0; i < count; i++)
                {
                    temp[i] = items[i];
                    
                    
                }
                
                items = new T[capacity *= 2];
               
                for (int i = 0; i < count; i++)
                {
                    items[i] = temp[i];
                   
                }
                items[count] = item;
                //foreach(T elements in temp)
                //{
                //    items[copyIndex] = elements;
                //    copyIndex++;
                //}
                // items[copyIndex] = item;
                //copyIndex++;
                count++;
            }
            //if count and capacity are equal
            //then increase capacity
            //copy values over to new array

        }



    }
}
