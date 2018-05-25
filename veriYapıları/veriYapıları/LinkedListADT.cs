using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veriYapıları
{
    public abstract class LinkedListADT
    {
        public LinkedListNode Head;
        public int Size = 0;
        public abstract void Insert(Urun2 urun);
        public abstract void Delete(int position);
        public abstract LinkedListNode GetElement(int position);
    }
}
