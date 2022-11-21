
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    public class ClassQueue
    {
        public void queue()
        {


            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);
            //callerIds.Clear();
            Console.WriteLine(callerIds.Dequeue());

            foreach (var id in callerIds)
                Console.Write(id);
           
        }
    }
}
