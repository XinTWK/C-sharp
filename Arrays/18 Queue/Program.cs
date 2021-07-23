using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //// defining a queue of integers
            //Queue<int> queue = new Queue<int>();

            //// printing the element at the front of the queue
            //queue.Enqueue(1);
            //Console.WriteLine("The value at the front of the queue is : {0}", queue.Peek());
            //queue.Enqueue(2);
            //Console.WriteLine("Top value in the queue is : {0}", queue.Peek());
            //queue.Enqueue(3);
            ////int queueItem = queue.Dequeue();
            ////Console.WriteLine("The front value {0} was removed from the queue",queueItem);
            //Console.WriteLine("Top value in the queue is : {0}", queue.Peek());

            //while (queue.Count > 0)
            //{
            //    // Dequeue() will return the element that was removed form the queue
            //    Console.WriteLine("The front value {0} was removed from the queue", queue.Dequeue());
            //    // print the queue count
            //    Console.WriteLine("Current queue count is : {0}", queue.Count);
            //}

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecieveOrdersFromBranch1())
            {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrdersFromBranch2())
            {
                // add each order to the queue
                ordersQueue.Enqueue(o);
            }

            // as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                // remove the order at the front of the queue
                // and store it in a variable called currentOrder
                Order currentOrder = ordersQueue.Dequeue();
                // process the order
                currentOrder.ProcessOrder();
            }


            Console.ReadKey();
        }

        // this method will create an array of orders an return it
        static Order[] RecieveOrdersFromBranch1()
        {
            // creating new orders array
            Order[] orders = new Order[] {
            new Order(1, 5),
            new Order(2, 4),
            new Order(6, 10)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            // creating new orders array and initializing it with some objects of type Order
            Order[] orders = new Order[] {
            new Order(3, 5),
            new Order(4, 4),
            new Order(5, 10)
            };
            // return the array of orders that we created
            return orders;
        }

    }

    // a class named order we will use it to store instances of it inside a queue because
    class Order
    {
        // order ID
        public int OrderId { get; set; }

        // quantity of the order
        public int OrderQuantity { get; set; }

        // simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        // print message on the screen that the order was processed
        public void ProcessOrder()
        {
            // print the message
            Console.WriteLine($"Order {OrderId} processed!");
        }



    }

}
