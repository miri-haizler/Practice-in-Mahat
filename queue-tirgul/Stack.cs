﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_tirgul
{
    internal class Stack<T>
    {
        private Node1<T> head;//ראש רשימה מקושרת שם נשמרים הנתונים 
        public void Push(T value) => head = new Node1<T>(value, head);//דחיפה למחסנית 
        public T Pop()//שולפת אחבר אחרון  במסנית
        {
            T temp = head.GetValue();
            head = head.GetNext();
            return temp;
        }
        public T Top() => head.GetValue();//מציץ על איבר ראשון מבלי לנתק מהמחסנית 
        public bool IsEmpty() => head == null;
        public override string ToString()
        {
            string str = "";
            Node1<T> node = head;
            while (node != null)
            {
                str += node.ToString();
                node = node.GetNext();
            }
            return str + "\n";
        }
    }
}
