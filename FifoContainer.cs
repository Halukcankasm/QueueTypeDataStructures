using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTypeDataStructures
{
    public class FifoContainer
    {
        #region Properties
        public object[] items { get; set; }

        private int index = 0;

        private int peekCounter = 0;
        public int Count { get => index; } 
        #endregion

        #region Constructers
        public FifoContainer()
        {
            items = new object[5];
        }

        public FifoContainer(Int32 capasity)
        {
            items = new object[capasity];
        }
        #endregion

        #region Methods

        /// <summary>
        /// Add item to the last of array
        /// </summary>
        /// <param name="item"></param>
        public void Enqueue(object item)
        {
            CheckArraySize();
            items[index] = item;
            index++;
        }

        /// <summary>
        /// Get First item what pick up the firt item
        /// </summary>
        /// <returns></returns>
        public object Dequeue()
        {
            if (Count == 0)
            {
                Console.WriteLine("Sırada Elaman bulunmamaktadır");
                return null;
            }
            object returnValue = items[0];
            CheckArrayFifo();
            index--;
            return returnValue;
        }

        /// <summary>
        /// Get first item but dont pick up item from array
        /// </summary>
        /// <returns></returns>
        public object Peek()
        {
            if (Count == 0)
            {
                Console.WriteLine("Sırada Elaman bulunmamaktadır");
                return null;
            }
            if (peekCounter > index - 1)
            {
                Console.WriteLine("Sırada Eleman bulunmamaktadır");
                return null;
            }
            object returnValue = items[peekCounter];
            peekCounter++;
            return returnValue;
        }

        private void CheckArrayFifo()
        {
            items = items.Skip(1).Take(index - 1).ToArray();
        }

        private void CheckArraySize()
        {
            object[] array = items;
            if (items.Length == index)
            {
                Array.Resize<Object>(ref array, items.Length + 1);
            }
            items = array;
        } 
        #endregion
    }
}
