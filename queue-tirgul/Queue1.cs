using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_tirgul
{
        public class Queue1<T>
        {
            T value;
            Node1<T> head, tail;
            public Queue1()
            {

            }
            public void Insert(T value)
            {
                if (head == null)
                {
                    tail = new Node1<T>(value);
                    head = tail;
                }
                else
                {
                    tail.SetNext(new Node1<T>(value));
                    tail = tail.GetNext();
                }
            }
            public T Remove()
            {
                T temp = head.GetValue();
                head = head.GetNext();
                return temp;

            }
            public T Head() => head.GetValue();//הצצה לראש 
            public bool IsEmpty() => head == null;
            public override string ToString()
            {
                string str = "";
                Node1<T> node = head;
                while (node != null)
                {
                    str += node.ToString() + " ";
                    node = node.GetNext();
                }
                return str + "\n";
            }
        }
    
}
