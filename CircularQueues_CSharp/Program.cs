using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            /*Initializing the values of the variabels REAR and FRONT to -1 to indicate that the queue is initially empty. */
            FRONT = -1;
            REAR = -1;
        }

        public void insert(int element)
        {
            /* The following statement checks whether the queue is empty. If the queue is empty, then the value of the REAR and FRONT variable is set to 0. */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }

        }
    }
}