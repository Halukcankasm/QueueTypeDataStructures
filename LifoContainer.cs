using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTypeDataStructures
{
    public class LifoContainer
    {
        private object[] items { get; set; }
        private int index = 0;
        public int Count 
        {
            get => items.Length;
        }
        public LifoContainer() 
        {
            items = new object[5];
        }

        public LifoContainer(int capasity)
        {
            items = new object[capasity];
        }

        public void Push(object item) 
        {            
            CheckCapasity();
            items[index] = item;
            index++;
        }

        public object Pop()
        {
            if (CheckItems())
            {
                object returnItem = items[index -1];
                index--;
                EditPopItem();
                return returnItem;
            }
            else
            {
                return "";
            }
            
            
        }

        private void EditPopItem()
        {
            items = items.Take(index).ToArray();
        }

        private bool CheckItems()
        {
            if (index <= 0)
            {
                Console.WriteLine("Sırada Eleman Bulunmamaktadır.");
                return false;
            }
            return true;
        }

        private void CheckCapasity()
        {
            object[] array = items;
            if (items.Length  < index +1)
            {
                Array.Resize(ref array, items.Length + 1);
            }
            items = array;
        }
    }
}
