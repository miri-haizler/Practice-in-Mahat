using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_tirgul
{
    internal class Node1<T>
    {
          T value;
        Node1<T>  next;
        public Node1(T value)
        {
            this.value = value;
        }
        public Node1(T value, Node1<T> next)
        {
            this.value = value;
            this.next = next;
        }
        
         public void SetValue(T value)=>this.value = value;
        public void SetNext(Node1<T>next)=>this.next = next;
        public T GetValue() => this.value;
        public Node1<T>GetNext() => this.next;
       public bool HasNext() => next != null;
        public override string ToString() => value.ToString()+" ";
        
    }
}
