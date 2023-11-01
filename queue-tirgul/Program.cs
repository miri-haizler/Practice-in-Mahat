using queue_tirgul;

//חוברת מיקוד
//עמוד 9 שאלה 1

static void First(Node1<int> chain)
{
    Node1<int> tmp = new Node1<int>(0);
    for (; chain.GetNext().GetNext()!=null; chain.GetNext().GetNext())
    {
        tmp = chain.GetNext();
        chain.SetNext(chain);
        chain.GetNext().SetNext(chain);
        //}
        //for (; chain.GetNext() != null; tmp = chain.GetNext(),
        //    chain.GetNext().SetValue(chain.GetValue()), chain.SetNext(tmp); chain.GetNext().GetNext());
    }
}
    Node1<int> node1 = new Node1<int>(1);
    node1.SetNext(new Node1<int>(2));
    node1.GetNext().SetNext(new Node1<int>(3));
    node1.GetNext().GetNext().SetNext(new Node1<int>(4));
   // for (; node1 != null; Console.Write(node1 + " "), node1 = node1.GetNext()) ;
    First(node1);


//עמוד 13 שאלה 1

//static Queue1<int> queue2(int num)
//{
//    Queue1<int> queue1 = new Queue1<int>();
//    for (int i = 1; i <=num; i++)
//    {
//        for (int j = i; j >0; j--)
//        {
//            queue1.Insert(i);
//        }
//    }
//    return queue1;
//}
//static bool queue3(Queue1<int> queue, int num)
//{
//    Queue1<int> queue1 = new Queue1<int>();
//    queue1 = queue2(num);

//    while (!queue1.IsEmpty() && !queue.IsEmpty())
//    {
//        if (queue1.Remove()!=queue.Remove())
//        {
//            return false;
//        }

//    }
//    if (!queue1.IsEmpty() || !queue.IsEmpty())
//    {
//        return false;
//    }
//    return true;
//}

//Queue1<int> queue = new Queue1<int>();
//queue.Insert(1);
//queue.Insert(2);
//queue.Insert(3);
//queue.Insert(3);
//queue.Insert(3);
//queue.Insert(3);
//queue.Insert(4);
//queue.Insert(4);
//queue.Insert(4);
//queue.Insert(4);

//Console.WriteLine(queue2(4));
//Console.WriteLine(queue3(queue,4));
