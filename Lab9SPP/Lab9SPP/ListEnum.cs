using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9SPP
{
    public class ListEnum<T> : IEnumerator<T>
    {

        private DynamicList<T> list;
        private int position = -1;
        public ListEnum(DynamicList<T> list)
        {
            this.list = list;
        }

        public T Current
        {
            get
            {
                try
                {
                    return (T)list[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position++;
            return (position < list.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
